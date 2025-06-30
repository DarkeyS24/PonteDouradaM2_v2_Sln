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
    public partial class ProdutosForm : UserControl
    {
        private Pessoa? pessoa;
        private Fornecedor? fornecedor;
        public ProdutosForm()
        {
            InitializeComponent();
        }

        public void setDataGridView(int pessoaId)
        {
            using (var context = new SessaoXContext())
            {
                var list = context.Produtos.Include(s => s.ProdutoSolicitacaos).Include(s => s.Fornecedor).Where(s => s.Fornecedor.PessoaId == pessoaId).ToList();

                if (list.Count() > 0)
                {
                    dgvProdutos.Rows.Clear();
                    foreach (var produto in list)
                    {
                        dgvProdutos.Rows.Add(
                            produto.Nome,
                            produto.Tipo,
                            produto.Fornecedor.RazaoSocial,
                            produto.DataCadastro.ToString("dd/MM/yyyy")
                        );
                    }
                    fornecedor = context.Fornecedors.Include(f => f.Pessoa).FirstOrDefault(f => f.PessoaId == pessoaId);
                    pessoa = fornecedor?.Pessoa;
                }
            }
        }

        private void novoBtn_Click(object sender, EventArgs e)
        {
            AddEditProdutoForm addEditProdutoForm = new AddEditProdutoForm();
            addEditProdutoForm.setAction(0);
            addEditProdutoForm.setPrevForm(this, pessoa, fornecedor);
            this.Enabled = false;
            addEditProdutoForm.Show();
        }

        private void editarBtn_Click(object sender, EventArgs e)
        {
            AddEditProdutoForm addEditProdutoForm = new AddEditProdutoForm();
            if (dgvProdutos.Rows.Count > 0)
            {
                DataGridViewRow row = dgvProdutos.Rows[0];
                using (var context = new SessaoXContext())
                {
                    var produto = context.Produtos.Include(p => p.Fornecedor).FirstOrDefault(p => p.Nome == row.Cells[0].Value.ToString() && p.Fornecedor.RazaoSocial == fornecedor.RazaoSocial);
                    addEditProdutoForm.setAction(1);
                    addEditProdutoForm.setPrevForm(this, pessoa, fornecedor);
                    addEditProdutoForm.setProduto(produto);
                    this.Enabled = false;
                    addEditProdutoForm.Show();
                }
            }
        }
    }
}
