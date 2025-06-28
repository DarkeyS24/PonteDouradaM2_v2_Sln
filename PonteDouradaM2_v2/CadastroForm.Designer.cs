namespace PonteDouradaM2_v2
{
    partial class CadastroForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            nomeTxt = new TextBox();
            perfilCb = new ComboBox();
            label2 = new Label();
            socialLbl = new Label();
            socialTxt = new TextBox();
            label4 = new Label();
            telTxt = new TextBox();
            cnpjLbl = new Label();
            documentoTxt = new TextBox();
            label7 = new Label();
            rePswdTxt = new TextBox();
            label8 = new Label();
            pswdTxt = new TextBox();
            label9 = new Label();
            usuarioTxt = new TextBox();
            button1 = new Button();
            cpfLbl = new Label();
            nascLbl = new Label();
            nascPicker = new DateTimePicker();
            cancelarBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(150, 25);
            label1.Name = "label1";
            label1.Size = new Size(77, 32);
            label1.TabIndex = 0;
            label1.Text = "Perfil";
            // 
            // nomeTxt
            // 
            nomeTxt.Location = new Point(247, 94);
            nomeTxt.Name = "nomeTxt";
            nomeTxt.Size = new Size(299, 40);
            nomeTxt.TabIndex = 1;
            // 
            // perfilCb
            // 
            perfilCb.FormattingEnabled = true;
            perfilCb.Location = new Point(247, 22);
            perfilCb.Name = "perfilCb";
            perfilCb.Size = new Size(299, 40);
            perfilCb.TabIndex = 2;
            perfilCb.SelectedIndexChanged += perfilCb_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(136, 97);
            label2.Name = "label2";
            label2.Size = new Size(91, 32);
            label2.TabIndex = 3;
            label2.Text = "Nome";
            // 
            // socialLbl
            // 
            socialLbl.AutoSize = true;
            socialLbl.Location = new Point(60, 169);
            socialLbl.Name = "socialLbl";
            socialLbl.Size = new Size(167, 32);
            socialLbl.TabIndex = 5;
            socialLbl.Text = "Razão social";
            socialLbl.Visible = false;
            // 
            // socialTxt
            // 
            socialTxt.Location = new Point(247, 166);
            socialTxt.Name = "socialTxt";
            socialTxt.Size = new Size(299, 40);
            socialTxt.TabIndex = 4;
            socialTxt.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(105, 312);
            label4.Name = "label4";
            label4.Size = new Size(122, 32);
            label4.TabIndex = 9;
            label4.Text = "Telefone";
            // 
            // telTxt
            // 
            telTxt.Location = new Point(247, 309);
            telTxt.Name = "telTxt";
            telTxt.Size = new Size(299, 40);
            telTxt.TabIndex = 8;
            // 
            // cnpjLbl
            // 
            cnpjLbl.AutoSize = true;
            cnpjLbl.Location = new Point(147, 240);
            cnpjLbl.Name = "cnpjLbl";
            cnpjLbl.Size = new Size(80, 32);
            cnpjLbl.TabIndex = 7;
            cnpjLbl.Text = "CNPJ";
            cnpjLbl.Visible = false;
            // 
            // documentoTxt
            // 
            documentoTxt.Location = new Point(247, 237);
            documentoTxt.Name = "documentoTxt";
            documentoTxt.Size = new Size(299, 40);
            documentoTxt.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 526);
            label7.Name = "label7";
            label7.Size = new Size(211, 32);
            label7.TabIndex = 15;
            label7.Text = "Confirme senha";
            // 
            // rePswdTxt
            // 
            rePswdTxt.Location = new Point(247, 523);
            rePswdTxt.Name = "rePswdTxt";
            rePswdTxt.Size = new Size(299, 40);
            rePswdTxt.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(136, 452);
            label8.Name = "label8";
            label8.Size = new Size(91, 32);
            label8.TabIndex = 13;
            label8.Text = "Senha";
            // 
            // pswdTxt
            // 
            pswdTxt.Location = new Point(247, 452);
            pswdTxt.Name = "pswdTxt";
            pswdTxt.Size = new Size(299, 40);
            pswdTxt.TabIndex = 12;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(119, 383);
            label9.Name = "label9";
            label9.Size = new Size(108, 32);
            label9.TabIndex = 11;
            label9.Text = "Usuario";
            // 
            // usuarioTxt
            // 
            usuarioTxt.Location = new Point(247, 380);
            usuarioTxt.Name = "usuarioTxt";
            usuarioTxt.Size = new Size(299, 40);
            usuarioTxt.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(395, 595);
            button1.Name = "button1";
            button1.Size = new Size(151, 40);
            button1.TabIndex = 16;
            button1.Text = "Salvar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // cpfLbl
            // 
            cpfLbl.AutoSize = true;
            cpfLbl.Location = new Point(163, 240);
            cpfLbl.Name = "cpfLbl";
            cpfLbl.Size = new Size(64, 32);
            cpfLbl.TabIndex = 17;
            cpfLbl.Text = "CPF";
            // 
            // nascLbl
            // 
            nascLbl.AutoSize = true;
            nascLbl.Location = new Point(4, 172);
            nascLbl.Name = "nascLbl";
            nascLbl.Size = new Size(223, 32);
            nascLbl.TabIndex = 18;
            nascLbl.Text = "Data nascimento";
            // 
            // nascPicker
            // 
            nascPicker.Format = DateTimePickerFormat.Short;
            nascPicker.Location = new Point(247, 166);
            nascPicker.Name = "nascPicker";
            nascPicker.Size = new Size(299, 40);
            nascPicker.TabIndex = 19;
            // 
            // cancelarBtn
            // 
            cancelarBtn.Location = new Point(222, 595);
            cancelarBtn.Name = "cancelarBtn";
            cancelarBtn.Size = new Size(151, 40);
            cancelarBtn.TabIndex = 20;
            cancelarBtn.Text = "Cancelar";
            cancelarBtn.UseVisualStyleBackColor = true;
            cancelarBtn.Click += cancelarBtn_Click;
            // 
            // CadastroForm
            // 
            AutoScaleDimensions = new SizeF(16F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.Gold;
            ClientSize = new Size(571, 666);
            Controls.Add(cancelarBtn);
            Controls.Add(nascPicker);
            Controls.Add(nascLbl);
            Controls.Add(cpfLbl);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(rePswdTxt);
            Controls.Add(label8);
            Controls.Add(pswdTxt);
            Controls.Add(label9);
            Controls.Add(usuarioTxt);
            Controls.Add(label4);
            Controls.Add(telTxt);
            Controls.Add(cnpjLbl);
            Controls.Add(documentoTxt);
            Controls.Add(socialLbl);
            Controls.Add(socialTxt);
            Controls.Add(label2);
            Controls.Add(perfilCb);
            Controls.Add(nomeTxt);
            Controls.Add(label1);
            Font = new Font("Uber Move", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(6, 5, 6, 5);
            Name = "CadastroForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ponte Dourada";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox nomeTxt;
        private ComboBox perfilCb;
        private Label label2;
        private Label socialLbl;
        private TextBox socialTxt;
        private Label label4;
        private TextBox telTxt;
        private Label cnpjLbl;
        private TextBox documentoTxt;
        private Label label7;
        private TextBox rePswdTxt;
        private Label label8;
        private TextBox pswdTxt;
        private Label label9;
        private TextBox usuarioTxt;
        private Button button1;
        private Label cpfLbl;
        private Label nascLbl;
        private DateTimePicker nascPicker;
        private Button cancelarBtn;
    }
}