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
    public partial class SolicitacoesForm : UserControl
    {
        private int pessoaId;
        private int clienteId;
        public SolicitacoesForm()
        {
            InitializeComponent();
            
        }

        public void setDataGridView(int pessoaId)
        {
            using (var context = new SessaoXContext())
            {
                var list = context.Solicitacaos.Include(s => s.ProdutoSolicitacaos).Include(s => s.Cliente).Where(s => s.Cliente.PessoaId == pessoaId).ToList();

                if (list.Count() > 0)
                {
                    dgvSolicitacoes.Rows.Clear();
                    foreach (var solicitacao in list)
                    {
                        solicitacao.ProdutoSolicitacaos.ElementAt(0).Produto = context.Produtos
                            .Include(p => p.Fornecedor)
                            .FirstOrDefault(p => p.Id == solicitacao.ProdutoSolicitacaos.ElementAt(0).ProdutoId);

                        dgvSolicitacoes.Rows.Add(
                            solicitacao.Id,
                            solicitacao.Descricao,
                            solicitacao.ProdutoSolicitacaos.ElementAt(0).Produto.Fornecedor.RazaoSocial,
                            solicitacao.DataCadastro.ToString("dd/MM/yyyy")
                        );
                        this.pessoaId = solicitacao.Cliente.PessoaId;
                        this.clienteId = solicitacao.ClienteId;
                    }
                }
            }
        }

        private void novoBtn_Click(object sender, EventArgs e)
        {
            AddEditSolicitacaoForm solicitacaoForm = new AddEditSolicitacaoForm();
            solicitacaoForm.setAction(0);
            solicitacaoForm.SetSearchedTable();
            solicitacaoForm.setPrevForm(this, pessoaId, clienteId);
            this.Enabled = false;
            solicitacaoForm.Height = 800;
            solicitacaoForm.Show();
        }

        private void editarBtn_Click(object sender, EventArgs e)
        {
            using (var context = new SessaoXContext())
            {
                if (dgvSolicitacoes.SelectedRows.Count > 0)
                {
                    int id = Convert.ToInt32(dgvSolicitacoes.SelectedRows[0].Cells[0].Value);
                    var solicitacao = context.ProdutoSolicitacaos
                        .Include(ps => ps.Produto)
                        .ThenInclude(p => p.Fornecedor)
                        .Where(s => s.SolicitcaoId == id).ToList();
                    if (solicitacao != null)
                    {
                        AddEditSolicitacaoForm solicitacaoForm = new AddEditSolicitacaoForm();
                        solicitacaoForm.setAction(1);
                        solicitacaoForm.SetSearchedTable();
                        solicitacaoForm.setPrevForm(this, pessoaId, clienteId);
                        solicitacaoForm.setSolicitacao(solicitacao);
                        this.Enabled = false;
                        solicitacaoForm.Height = 800;
                        solicitacaoForm.Show();
                    }
                }
            }
        }
    }
}
