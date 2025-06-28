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

namespace PonteDouradaM2_v2
{
    public partial class ProdutosForm : UserControl
    {
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
                }
            }
        }
    }
}
