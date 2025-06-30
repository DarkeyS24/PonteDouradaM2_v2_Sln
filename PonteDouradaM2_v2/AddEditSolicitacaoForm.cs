using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using PonteDouradaM2_v2.Context;
using PonteDouradaM2_v2.Models;

namespace PonteDouradaM2_v2
{
    public partial class AddEditSolicitacaoForm : Form
    {
        private int action;
        private Solicitacao solicitacao;
        private List<ProdutoSolicitacao> solicitacoesP;
        private SolicitacoesForm form;
        private int pessoaId;
        private int clienteId;
        public AddEditSolicitacaoForm()
        {
            InitializeComponent();
            List<string> tipos = new List<string>
            {
                "Medicina",
                "Equipamento"
            };
            tipoCb.DataSource = tipos;
        }

        public void setAction(int action)
        {
            this.action = action;
        }

        public void SetSearchedTable()
        {
            dgvPesquisados.Rows.Clear();
            using (var context = new SessaoXContext())
            {
                List<Produto> list = [];
                if (tipoCb.SelectedIndex == 0)
                {
                    if (!string.IsNullOrEmpty(nomeTxt.Text))
                    {
                        list = context.Produtos
                            .Include(p => p.Fornecedor)
                            .Where(p => p.Nome.Contains(nomeTxt.Text) && p.Tipo == "Medicamento")
                            .ToList();
                    }
                    else
                    {
                        list = context.Produtos
                            .Include(p => p.Fornecedor)
                            .Where(p => p.Tipo == "Medicamento")
                            .ToList();
                    }
                }
                else if (tipoCb.SelectedIndex == 1)
                {
                    if (!string.IsNullOrEmpty(nomeTxt.Text))
                    {
                        list = context.Produtos
                            .Include(p => p.Fornecedor)
                            .Where(p => p.Nome.Contains(nomeTxt.Text) && p.Tipo == "Equipamento")
                            .ToList();
                    }
                    else
                    {
                        list = context.Produtos
                            .Include(p => p.Fornecedor)
                            .Where(p => p.Tipo == "Equipamento")
                            .ToList();
                    }
                }

                if (list.Count() > 0)
                {
                    foreach (var item in list)
                    {
                        dgvPesquisados.Rows.Add(item.Nome, item.Fornecedor.RazaoSocial);
                    }
                }
            }
        }

        private void searchPb_Click(object sender, EventArgs e)
        {
            SetSearchedTable();
        }

        private void adicionarBtn_Click(object sender, EventArgs e)
        {
            if (dgvPesquisados.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvPesquisados.SelectedRows[0];
                using (var context = new SessaoXContext())
                {
                    var produto = context.Produtos
                        .Include(p => p.Fornecedor)
                        .FirstOrDefault(p => p.Nome == selectedRow.Cells[0].Value.ToString() &&
                                             p.Fornecedor.RazaoSocial == selectedRow.Cells[1].Value.ToString());

                    dgvAdicionados.Rows.Add(
                        produto.Nome,
                        produto.Fornecedor.RazaoSocial
                    );
                }
            }
        }

        public void setPrevForm(SolicitacoesForm form, int pessoaId, int clienteId)
        {
            this.form = form;
            this.pessoaId = pessoaId;
            this.clienteId = clienteId;
        }

        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            form.setDataGridView(pessoaId);
            form.Enabled = true;
            this.Close();
        }

        public void setSolicitacao(List<ProdutoSolicitacao> solicitacao)
        {
            foreach (var item in solicitacao)
            {
                dgvAdicionados.Rows.Add(
                    item.Produto.Nome,
                    item.Produto.Fornecedor.RazaoSocial
                );
            }
            this.solicitacao = solicitacao.ElementAt(0).Solicitcao;
            this.solicitacoesP = solicitacao;
            descTxt.Text = this.solicitacao.Descricao;
            validadePicker.Value = DateTime.Parse(this.solicitacao.Validade.ToString("dd/MM/yyyy"));
        }

        private void salvarBtn_Click(object sender, EventArgs e)
        {
            var booleano = IsEmptyFields();
            if (booleano)
            {
                using (var context = new SessaoXContext())
                {
                    if (action == 0)
                    {
                        Solicitacao solicitacaoEF = new Solicitacao()
                        {
                            ClienteId = clienteId,
                            Cliente = context.Clientes
                                .Include(c => c.Pessoa)
                                .FirstOrDefault(c => c.PessoaId == pessoaId),
                            Descricao = descTxt.Text,
                            DataCadastro = DateOnly.FromDateTime(DateTime.Now),
                            Validade = DateOnly.FromDateTime((validadePicker.Value))
                        };
                        context.Solicitacaos.Add(solicitacaoEF);
                        context.SaveChanges();
                        foreach (DataGridViewRow row in dgvAdicionados.Rows)
                        {
                            if (row.Cells[0].Value != null)
                            {
                                var produtoNome = row.Cells[0].Value.ToString();
                                var fornecedorRazaoSocial = row.Cells[1].Value.ToString();
                                var produto = context.Produtos
                                    .Include(p => p.Fornecedor)
                                    .FirstOrDefault(p => p.Nome == produtoNome && p.Fornecedor.RazaoSocial == fornecedorRazaoSocial);
                                if (produto != null)
                                {
                                    ProdutoSolicitacao produtoSolicitacao = new ProdutoSolicitacao
                                    {
                                        ProdutoId = produto.Id,
                                        Solicitcao = solicitacaoEF
                                    };
                                    context.ProdutoSolicitacaos.Add(produtoSolicitacao);
                                }
                            }
                        }
                        context.SaveChanges();
                        MessageBox.Show("Solicitação criada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        form.setDataGridView(pessoaId);
                        form.Enabled = true;
                        this.Close();
                    }
                    else if (action == 1)
                    {
                        ProdutoSolicitacao produtos;

                        foreach (DataGridViewRow row in dgvAdicionados.Rows)
                        {
                            if(row.Cells[0].Value != null)
                            {
                                if (!solicitacoesP.Any(sp => sp.Produto.Nome == row.Cells[0].Value.ToString()))
                                {
                                    var produto = context.Produtos
                                        .Include(p => p.Fornecedor)
                                        .FirstOrDefault(p => p.Nome == row.Cells[0].Value.ToString() &&
                                                             p.Fornecedor.RazaoSocial == row.Cells[1].Value.ToString());
                                    if (produto != null)
                                    {
                                        produtos = new ProdutoSolicitacao
                                        {
                                            ProdutoId = produto.Id,
                                            Produto = produto,
                                            Solicitcao = solicitacao,
                                            SolicitcaoId = solicitacao.Id
                                        };
                                        solicitacoesP.Add(produtos);
                                    }
                                }
                            }
                        }

                        if (IsEmptyFields())
                        {
                            solicitacao.Descricao = descTxt.Text;
                            solicitacao.Validade = DateOnly.FromDateTime(validadePicker.Value);
                            try
                            {
                                foreach (var item in solicitacoesP)
                                {
                                    //item.Produto.Fornecedor = context.Fornecedors.FirstOrDefault(f => f.Id == item.Produto.FornecedorId);
                                    context.ChangeTracker.Clear();
                                    if (item.Id > 0)
                                    {
                                        context.Update(item);
                                    }
                                    else
                                    {
                                        context.Add(item);
                                    }
                                }
                                context.Update(solicitacao);
                                context.SaveChanges();
                                MessageBox.Show($"Solicitação atualizada com sucesso.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                form.setDataGridView(pessoaId);
                                form.Enabled = true;
                                this.Close();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Exception: {ex.Message}","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
        }

        private bool IsEmptyFields()
        {
            if (dgvAdicionados.Rows.Count > 0)
            {
                if (validadePicker.Value >= DateTime.Now.AddDays(15))
                {
                    if (validadePicker.Value.Day % 5 == 0)
                    {
                        if (!string.IsNullOrEmpty(descTxt.Text))
                        {
                            if (descTxt.Text.Length > 50 && descTxt.Text.Length < 200)
                            {
                                return true;
                            }
                            else
                            {
                                MessageBox.Show("A descrição deve ter entre 50 e 200 caracteres.", "Descrição inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return false;
                            }
                        }
                        else
                        {
                            MessageBox.Show("A descrição não pode estar vazia.", "Descrição inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("A validade deve ser um múltiplo de 5 dias.", "Validade inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("A validade deve ser de pelo menos 15 dias a partir de hoje.", "Validade inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Adicione pelo menos um produto à solicitação.", "Solicitação sem produtos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }
    }
}
