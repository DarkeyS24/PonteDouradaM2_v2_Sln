namespace PonteDouradaM2_v2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            usuarioTxt = new TextBox();
            label1 = new Label();
            entrarBtn = new Button();
            cadastroLink = new LinkLabel();
            label2 = new Label();
            senhaTxt = new TextBox();
            label3 = new Label();
            label4 = new Label();
            solicitacoesForm1 = new SolicitacoesForm();
            produtosForm1 = new ProdutosForm();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Gold;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(0, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(534, 668);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // usuarioTxt
            // 
            usuarioTxt.BorderStyle = BorderStyle.FixedSingle;
            usuarioTxt.Font = new Font("Uber Move", 16.1999989F, FontStyle.Bold);
            usuarioTxt.Location = new Point(713, 294);
            usuarioTxt.Name = "usuarioTxt";
            usuarioTxt.Size = new Size(373, 40);
            usuarioTxt.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Uber Move", 16.1999989F, FontStyle.Bold);
            label1.Location = new Point(585, 297);
            label1.Name = "label1";
            label1.Size = new Size(108, 32);
            label1.TabIndex = 2;
            label1.Text = "Usuario";
            // 
            // entrarBtn
            // 
            entrarBtn.Font = new Font("Uber Move", 16.1999989F, FontStyle.Bold);
            entrarBtn.Location = new Point(925, 478);
            entrarBtn.Name = "entrarBtn";
            entrarBtn.Size = new Size(161, 46);
            entrarBtn.TabIndex = 3;
            entrarBtn.Text = "Entrar";
            entrarBtn.UseVisualStyleBackColor = true;
            entrarBtn.Click += entrarBtn_Click;
            // 
            // cadastroLink
            // 
            cadastroLink.AutoSize = true;
            cadastroLink.Font = new Font("Uber Move", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cadastroLink.Location = new Point(794, 570);
            cadastroLink.Name = "cadastroLink";
            cadastroLink.Size = new Size(123, 24);
            cadastroLink.TabIndex = 4;
            cadastroLink.TabStop = true;
            cadastroLink.Text = "Cadastre-se";
            cadastroLink.LinkClicked += cadastroLink_LinkClicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Uber Move", 16.1999989F, FontStyle.Bold);
            label2.Location = new Point(585, 387);
            label2.Name = "label2";
            label2.Size = new Size(91, 32);
            label2.TabIndex = 5;
            label2.Text = "Senha";
            // 
            // senhaTxt
            // 
            senhaTxt.BorderStyle = BorderStyle.FixedSingle;
            senhaTxt.Font = new Font("Uber Move", 16.1999989F, FontStyle.Bold);
            senhaTxt.Location = new Point(713, 384);
            senhaTxt.Name = "senhaTxt";
            senhaTxt.Size = new Size(373, 40);
            senhaTxt.TabIndex = 6;
            senhaTxt.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Gold;
            label3.Font = new Font("Uber Move", 35.9999962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(653, 63);
            label3.Name = "label3";
            label3.Size = new Size(190, 72);
            label3.TabIndex = 7;
            label3.Text = "Ponte";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Uber Move", 35.9999962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Gold;
            label4.Location = new Point(809, 125);
            label4.Name = "label4";
            label4.Size = new Size(267, 72);
            label4.TabIndex = 8;
            label4.Text = "Dourada";
            // 
            // solicitacoesForm1
            // 
            solicitacoesForm1.BackColor = Color.Gold;
            solicitacoesForm1.Font = new Font("Uber Move", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            solicitacoesForm1.Location = new Point(0, -1);
            solicitacoesForm1.Margin = new Padding(6, 5, 6, 5);
            solicitacoesForm1.Name = "solicitacoesForm1";
            solicitacoesForm1.Size = new Size(1155, 666);
            solicitacoesForm1.TabIndex = 9;
            solicitacoesForm1.Visible = false;
            // 
            // produtosForm1
            // 
            produtosForm1.BackColor = Color.Gold;
            produtosForm1.Font = new Font("Uber Move", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            produtosForm1.Location = new Point(0, -1);
            produtosForm1.Margin = new Padding(6, 5, 6, 5);
            produtosForm1.Name = "produtosForm1";
            produtosForm1.Size = new Size(1155, 666);
            produtosForm1.TabIndex = 10;
            produtosForm1.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1151, 661);
            Controls.Add(produtosForm1);
            Controls.Add(solicitacoesForm1);
            Controls.Add(label3);
            Controls.Add(senhaTxt);
            Controls.Add(label2);
            Controls.Add(cadastroLink);
            Controls.Add(entrarBtn);
            Controls.Add(label1);
            Controls.Add(usuarioTxt);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ponte Dourada";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox usuarioTxt;
        private Label label1;
        private Button entrarBtn;
        private LinkLabel cadastroLink;
        private Label label2;
        private TextBox senhaTxt;
        private Label label3;
        private Label label4;
        private SolicitacoesForm solicitacoesForm1;
        private ProdutosForm produtosForm1;
    }
}
