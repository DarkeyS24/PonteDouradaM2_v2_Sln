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
                        pessoaId = solicitacao.Cliente.PessoaId;
                        clienteId = solicitacao.ClienteId;
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
            solicitacaoForm.Show();
        }
    }
}
