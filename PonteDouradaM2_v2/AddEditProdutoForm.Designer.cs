namespace PonteDouradaM2_v2
{
    partial class AddEditProdutoForm
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
            salvarBtn = new Button();
            cancelarBtn = new Button();
            label1 = new Label();
            tipoCb = new ComboBox();
            nomeTxt = new TextBox();
            validadePicker = new DateTimePicker();
            descTxt = new RichTextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // salvarBtn
            // 
            salvarBtn.Location = new Point(428, 393);
            salvarBtn.Name = "salvarBtn";
            salvarBtn.Size = new Size(150, 46);
            salvarBtn.TabIndex = 0;
            salvarBtn.Text = "Salvar";
            salvarBtn.UseVisualStyleBackColor = true;
            salvarBtn.Click += salvarBtn_Click;
            // 
            // cancelarBtn
            // 
            cancelarBtn.Location = new Point(255, 393);
            cancelarBtn.Name = "cancelarBtn";
            cancelarBtn.Size = new Size(150, 46);
            cancelarBtn.TabIndex = 1;
            cancelarBtn.Text = "Cancelar";
            cancelarBtn.UseVisualStyleBackColor = true;
            cancelarBtn.Click += cancelarBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(91, 25);
            label1.Name = "label1";
            label1.Size = new Size(70, 32);
            label1.TabIndex = 2;
            label1.Text = "Tipo";
            // 
            // tipoCb
            // 
            tipoCb.FormattingEnabled = true;
            tipoCb.Location = new Point(193, 22);
            tipoCb.Name = "tipoCb";
            tipoCb.Size = new Size(260, 40);
            tipoCb.TabIndex = 3;
            // 
            // nomeTxt
            // 
            nomeTxt.BackColor = Color.White;
            nomeTxt.BorderStyle = BorderStyle.FixedSingle;
            nomeTxt.Location = new Point(192, 92);
            nomeTxt.Name = "nomeTxt";
            nomeTxt.Size = new Size(261, 40);
            nomeTxt.TabIndex = 4;
            // 
            // validadePicker
            // 
            validadePicker.Format = DateTimePickerFormat.Short;
            validadePicker.Location = new Point(192, 166);
            validadePicker.Name = "validadePicker";
            validadePicker.Size = new Size(261, 40);
            validadePicker.TabIndex = 5;
            // 
            // descTxt
            // 
            descTxt.Location = new Point(192, 244);
            descTxt.Name = "descTxt";
            descTxt.Size = new Size(386, 128);
            descTxt.TabIndex = 6;
            descTxt.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 94);
            label2.Name = "label2";
            label2.Size = new Size(91, 32);
            label2.TabIndex = 7;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 174);
            label3.Name = "label3";
            label3.Size = new Size(123, 32);
            label3.TabIndex = 8;
            label3.Text = "Validade";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 247);
            label4.Name = "label4";
            label4.Size = new Size(141, 32);
            label4.TabIndex = 9;
            label4.Text = "Descrição";
            // 
            // AddEditProdutoForm
            // 
            AutoScaleDimensions = new SizeF(16F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gold;
            ClientSize = new Size(604, 463);
            ControlBox = false;
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(descTxt);
            Controls.Add(validadePicker);
            Controls.Add(nomeTxt);
            Controls.Add(tipoCb);
            Controls.Add(label1);
            Controls.Add(cancelarBtn);
            Controls.Add(salvarBtn);
            Font = new Font("Uber Move", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(6, 5, 6, 5);
            Name = "AddEditProdutoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddEditProdutoForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button salvarBtn;
        private Button cancelarBtn;
        private Label label1;
        private ComboBox tipoCb;
        private TextBox nomeTxt;
        private DateTimePicker validadePicker;
        private RichTextBox descTxt;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}