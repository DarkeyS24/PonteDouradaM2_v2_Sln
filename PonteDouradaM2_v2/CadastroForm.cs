using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PonteDouradaM2_v2.Context;
using PonteDouradaM2_v2.Models;

namespace PonteDouradaM2_v2
{
    public partial class CadastroForm : Form
    {
        private Fornecedor fornecedor;
        private Cliente cliente;
        private Usuario usuario;
        private Pessoa pessoa;

        public CadastroForm()
        {
            InitializeComponent();
            List<String> perfiles = new List<string>
            {
                "Fornecedor",
                "Cliente"
            };
            perfilCb.DataSource = perfiles;
        }

        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void perfilCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (perfilCb.SelectedIndex == 0)
            {
                cnpjLbl.Visible = true;
                cpfLbl.Visible = false;

                nascLbl.Visible = false;
                nascPicker.Visible = false;

                socialLbl.Visible = true;
                socialTxt.Visible = true;
            }
            else if (perfilCb.SelectedIndex == 1)
            {
                cnpjLbl.Visible = false;
                cpfLbl.Visible = true;

                nascLbl.Visible = true;
                nascPicker.Visible = true;

                socialLbl.Visible = false;
                socialTxt.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (perfilCb.SelectedIndex == 0)
            {
                if (string.IsNullOrEmpty(nomeTxt.Text))
                {
                    MessageBox.Show("O campo Nome é obrigatório.", "Campo vazío", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (string.IsNullOrEmpty(socialTxt.Text))
                {
                    MessageBox.Show("O campo Razão Social é obrigatório.", "Campo vazío", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (string.IsNullOrEmpty(documentoTxt.Text))
                {
                    MessageBox.Show("O campo CNPJ é obrigatório.", "Campo vazío", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (string.IsNullOrEmpty(telTxt.Text))
                {
                    MessageBox.Show("O campo Telefone é obrigatório.", "Campo vazío", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (string.IsNullOrEmpty(usuarioTxt.Text))
                {
                    MessageBox.Show("O campo usuario é obrigatório.", "Campo vazío", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (string.IsNullOrEmpty(pswdTxt.Text))
                {
                    MessageBox.Show("O campo senha é obrigatório.", "Campo vazío", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (string.IsNullOrEmpty(rePswdTxt.Text))
                {
                    MessageBox.Show("confirme a senha.", "Campo vazío", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (rePswdTxt.Text != pswdTxt.Text)
                {
                    MessageBox.Show("As senhas não conferem.", "Senhas diferentes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    pessoa = new Pessoa
                    {
                        Nome = nomeTxt.Text,
                        Telefone = telTxt.Text
                    };
                    fornecedor = new Fornecedor
                    {
                        RazaoSocial = socialTxt.Text,
                        Cnpj = documentoTxt.Text
                    };
                    usuario = new Usuario
                    {
                        Login = usuarioTxt.Text,
                        SenhaHash = pswdTxt.Text,
                        Perfil = "Fornecedor",
                    };

                    using (var context = new SessaoXContext())
                    {
                        context.Pessoas.Add(pessoa);
                        try
                        {
                            context.SaveChanges();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Erro ao cadastrar fornecedor: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        fornecedor.PessoaId = pessoa.Id;
                        fornecedor.Pessoa = pessoa;
                        usuario.PessoaId = pessoa.Id;
                        usuario.Pessoa = pessoa;

                        try
                        {
                            context.Fornecedors.Add(fornecedor);
                            context.Usuarios.Add(usuario);
                            context.SaveChanges();
                            MessageBox.Show("Usuario cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Erro ao cadastrar fornecedor: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
            } else if (perfilCb.SelectedIndex == 1)
            {
                if (string.IsNullOrEmpty(nomeTxt.Text))
                {
                    MessageBox.Show("O campo Nome é obrigatório.", "Campo vazío", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (nascPicker.Value.AddYears(18) > DateTime.Now)
                {
                    MessageBox.Show("Usuario menor de 18 anos, não é possivel criar o usuario.", "Campo vazío", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (string.IsNullOrEmpty(documentoTxt.Text))
                {
                    MessageBox.Show("O campo CPF é obrigatório.", "Campo vazío", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (string.IsNullOrEmpty(telTxt.Text))
                {
                    MessageBox.Show("O campo Telefone é obrigatório.", "Campo vazío", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (string.IsNullOrEmpty(usuarioTxt.Text))
                {
                    MessageBox.Show("O campo usuario é obrigatório.", "Campo vazío", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (string.IsNullOrEmpty(pswdTxt.Text))
                {
                    MessageBox.Show("O campo senha é obrigatório.", "Campo vazío", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (string.IsNullOrEmpty(rePswdTxt.Text))
                {
                    MessageBox.Show("confirme a senha.", "Campo vazío", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (rePswdTxt.Text != pswdTxt.Text)
                {
                    MessageBox.Show("As senhas não conferem.", "Senhas diferentes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    pessoa = new Pessoa
                    {
                        Nome = nomeTxt.Text,
                        Telefone = telTxt.Text
                    };
                    cliente = new Cliente
                    {
                        DataNascimento = DateOnly.FromDateTime(nascPicker.Value),
                        Cpf = documentoTxt.Text
                    };
                    usuario = new Usuario
                    {
                        Login = usuarioTxt.Text,
                        SenhaHash = pswdTxt.Text,
                        Perfil = "Fornecedor",
                    };

                    using (var context = new SessaoXContext())
                    {
                        context.Pessoas.Add(pessoa);
                        try
                        {
                            context.SaveChanges();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Erro ao cadastrar fornecedor: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        cliente.PessoaId = pessoa.Id;
                        cliente.Pessoa = pessoa;
                        usuario.PessoaId = pessoa.Id;
                        usuario.Pessoa = pessoa;

                        try
                        {
                            context.Clientes.Add(cliente);
                            context.Usuarios.Add(usuario);
                            context.SaveChanges();
                            MessageBox.Show("Usuario cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Erro ao cadastrar fornecedor: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
            }
        }
    }
}
