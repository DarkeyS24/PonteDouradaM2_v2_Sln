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
    public partial class AddEditProdutoForm : Form
    {
        private ProdutosForm form;
        private Pessoa pessoa;
        private Fornecedor fornecedor;
        private int action;
        private Produto produto;

        public AddEditProdutoForm()
        {
            InitializeComponent();
            List<string> tipos = new List<string>
            {
                "Medicamento",
                "Equipamento"
            };
            tipoCb.DataSource = tipos;
        }

        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            form.setDataGridView(pessoa.Id);
            form.Enabled = true;
            this.Close();
        }

        private void salvarBtn_Click(object sender, EventArgs e)
        {
            if (IsEmptyFields())
            {
                Produto produto = new Produto()
                {
                    Nome = nomeTxt.Text,
                    Tipo = tipoCb.SelectedItem.ToString(),
                    Id = (action == 1)? this.produto.Id : 0,
                    Descricao = descTxt.Text,
                    Validade = DateOnly.FromDateTime(validadePicker.Value),
                    DataCadastro = DateOnly.FromDateTime(DateTime.Now),
                    FornecedorId = fornecedor.Id,
                    Fornecedor = fornecedor
                };
                if (action == 0)
                {
                    if (!ProductExist())
                    {
                        using (var context = new SessaoXContext())
                        {
                            context.Produtos.Add(produto);
                            try
                            {
                                context.SaveChanges();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Erro ao cadastrar produto: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Produto já cadastrado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else if (action == 1)
                {
                    using (var context = new SessaoXContext())
                    {
                        var existingProduct = context.Produtos.Find(produto.Id);
                        if (existingProduct != null)
                        {
                            context.Entry(produto).State = EntityState.Detached;
                        }

                        produto.ProdutoSolicitacaos = this.produto.ProdutoSolicitacaos;
                        produto.AtendimentoProdutos = this.produto.AtendimentoProdutos;
                        context.Produtos.Update(produto);
                        try
                        {
                            context.SaveChanges();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erro ao atualizar produto: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
            }
        }

        //---------------------------------------------------------------

        public void setAction(int action)
        {
            this.action = action;
        }

        public void setPrevForm(ProdutosForm form, Pessoa pessoa, Fornecedor fornecedor)
        {
            this.form = form;
            this.pessoa = pessoa;
            this.fornecedor = fornecedor;
        }

        public void setProduto(Produto produto)
        {
            if (produto.Tipo == "Medicamento")
            {
                tipoCb.SelectedIndex = 0;
            }
            else
            {
                tipoCb.SelectedIndex = 1;
            }
            nomeTxt.Text = produto.Nome;
            descTxt.Text = produto.Descricao;
            validadePicker.Value = new DateTime(produto.Validade, new TimeOnly(0,0,0));
            this.produto = produto;
        }

        private bool ProductExist()
        {
            Produto? produto = new Produto();
            using (var context = new SessaoXContext())
            {
                produto = context.Produtos
                     .Include(p => p.Fornecedor)
                     .AsNoTracking()
                     .FirstOrDefault(p => p.Nome == nomeTxt.Text && p.Fornecedor.RazaoSocial == fornecedor.RazaoSocial);

                if (produto != null)
                {
                    return true;
                }
                return false;
            }
        }

        private bool IsEmptyFields()
        {
            if (!string.IsNullOrEmpty(nomeTxt.Text))
            {
               
                        if (validadePicker.Value > DateTime.Now.Date)
                        {
                            if (!string.IsNullOrEmpty(descTxt.Text))
                            {
                                if (descTxt.Text.Length > 20 && descTxt.Text.Length < 150)
                                {
                                    return true;
                                }
                                else
                                {
                                    MessageBox.Show("A descrição deve ter entre 20 e 150 caracteres.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return false;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Preencha o campo descriçâo.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return false;
                            }
                        }
                        else
                        {
                            MessageBox.Show("A validade deve ser maior que a data atual.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }
            }
            else
            {
                MessageBox.Show("Preencha o campo Nome.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }
    }
}
