using PonteDouradaM2_v2.Context;

namespace PonteDouradaM2_v2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void entrarBtn_Click(object sender, EventArgs e)
        {
            login();
        }

        private void login()
        {
            using (var context = new SessaoXContext())
            {
                if (string.IsNullOrEmpty(usuarioTxt.Text))
                {
                    MessageBox.Show("Por favor, insira o seu usuário.");
                    return;
                }
                else if (string.IsNullOrEmpty(senhaTxt.Text))
                {
                    MessageBox.Show("Por favor, insira a senha.");
                    return;
                }
                else
                {
                    var usuario = context.Usuarios
                        .FirstOrDefault(u => u.Login == usuarioTxt.Text && u.SenhaHash == senhaTxt.Text);
                    if (usuario != null)
                    {
                        MessageBox.Show($"Bem-vindo, {usuario.Login}!");
                        if (usuario.Perfil == "Fornecedor")
                        {
                            var pessoaId = usuario.PessoaId;
                            produtosForm1.setDataGridView(pessoaId);
                            produtosForm1.Visible = true;
                        }
                        else
                        {
                            var pessoaId = usuario.PessoaId;
                            solicitacoesForm1.setDataGridView(pessoaId);
                            solicitacoesForm1.Visible = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuário ou senha inválidos.");
                    }
                }
            }
        }

        private void cadastroLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CadastroForm cadastroForm = new CadastroForm();
            cadastroForm.Show();
        }

        private void senhaTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                login();
            }
        }
    }
}
