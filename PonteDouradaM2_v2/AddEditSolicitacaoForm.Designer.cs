namespace PonteDouradaM2_v2
{
    partial class AddEditSolicitacaoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditSolicitacaoForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            label1 = new Label();
            tipoCb = new ComboBox();
            nomeTxt = new TextBox();
            searchPb = new PictureBox();
            dgvPesquisados = new DataGridView();
            NomeColumn = new DataGridViewTextBoxColumn();
            FornecedorColumn = new DataGridViewTextBoxColumn();
            validadePicker = new DateTimePicker();
            descTxt = new RichTextBox();
            cancelarBtn = new Button();
            salvarBtn = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dgvAdicionados = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            adicionarBtn = new Button();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)searchPb).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPesquisados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAdicionados).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(99, 35);
            label1.Name = "label1";
            label1.Size = new Size(70, 32);
            label1.TabIndex = 0;
            label1.Text = "Tipo";
            // 
            // tipoCb
            // 
            tipoCb.FormattingEnabled = true;
            tipoCb.Location = new Point(192, 32);
            tipoCb.Name = "tipoCb";
            tipoCb.Size = new Size(277, 40);
            tipoCb.TabIndex = 1;
            // 
            // nomeTxt
            // 
            nomeTxt.Location = new Point(192, 96);
            nomeTxt.Name = "nomeTxt";
            nomeTxt.Size = new Size(277, 40);
            nomeTxt.TabIndex = 2;
            // 
            // searchPb
            // 
            searchPb.Image = (Image)resources.GetObject("searchPb.Image");
            searchPb.Location = new Point(475, 96);
            searchPb.Name = "searchPb";
            searchPb.Size = new Size(45, 40);
            searchPb.SizeMode = PictureBoxSizeMode.Zoom;
            searchPb.TabIndex = 3;
            searchPb.TabStop = false;
            searchPb.Click += searchPb_Click;
            // 
            // dgvPesquisados
            // 
            dgvPesquisados.BackgroundColor = Color.White;
            dgvPesquisados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPesquisados.Columns.AddRange(new DataGridViewColumn[] { NomeColumn, FornecedorColumn });
            dgvPesquisados.Location = new Point(12, 216);
            dgvPesquisados.Name = "dgvPesquisados";
            dgvPesquisados.RowHeadersVisible = false;
            dgvPesquisados.RowHeadersWidth = 51;
            dgvPesquisados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPesquisados.Size = new Size(594, 204);
            dgvPesquisados.TabIndex = 4;
            // 
            // NomeColumn
            // 
            dataGridViewCellStyle1.Font = new Font("Uber Move", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NomeColumn.DefaultCellStyle = dataGridViewCellStyle1;
            NomeColumn.HeaderText = "Nome";
            NomeColumn.MinimumWidth = 6;
            NomeColumn.Name = "NomeColumn";
            NomeColumn.Width = 290;
            // 
            // FornecedorColumn
            // 
            dataGridViewCellStyle2.Font = new Font("Uber Move", 13.8F, FontStyle.Bold);
            FornecedorColumn.DefaultCellStyle = dataGridViewCellStyle2;
            FornecedorColumn.HeaderText = "Fornecedor";
            FornecedorColumn.MinimumWidth = 6;
            FornecedorColumn.Name = "FornecedorColumn";
            FornecedorColumn.Width = 300;
            // 
            // validadePicker
            // 
            validadePicker.Format = DateTimePickerFormat.Short;
            validadePicker.Location = new Point(192, 776);
            validadePicker.Name = "validadePicker";
            validadePicker.Size = new Size(277, 40);
            validadePicker.TabIndex = 5;
            // 
            // descTxt
            // 
            descTxt.BackColor = Color.White;
            descTxt.BorderStyle = BorderStyle.FixedSingle;
            descTxt.Location = new Point(192, 843);
            descTxt.Name = "descTxt";
            descTxt.Size = new Size(379, 136);
            descTxt.TabIndex = 6;
            descTxt.Text = "";
            // 
            // cancelarBtn
            // 
            cancelarBtn.Location = new Point(239, 1008);
            cancelarBtn.Name = "cancelarBtn";
            cancelarBtn.Size = new Size(144, 42);
            cancelarBtn.TabIndex = 7;
            cancelarBtn.Text = "Cancelar";
            cancelarBtn.UseVisualStyleBackColor = true;
            cancelarBtn.Click += cancelarBtn_Click;
            // 
            // salvarBtn
            // 
            salvarBtn.Location = new Point(427, 1008);
            salvarBtn.Name = "salvarBtn";
            salvarBtn.Size = new Size(144, 42);
            salvarBtn.TabIndex = 8;
            salvarBtn.Text = "Salvar";
            salvarBtn.UseVisualStyleBackColor = true;
            salvarBtn.Click += salvarBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(78, 99);
            label2.Name = "label2";
            label2.Size = new Size(91, 32);
            label2.TabIndex = 9;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 181);
            label3.Name = "label3";
            label3.Size = new Size(268, 32);
            label3.TabIndex = 10;
            label3.Text = "Resultados da busca";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 496);
            label4.Name = "label4";
            label4.Size = new Size(268, 32);
            label4.TabIndex = 12;
            label4.Text = "Resultados da busca";
            // 
            // dgvAdicionados
            // 
            dgvAdicionados.BackgroundColor = Color.White;
            dgvAdicionados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAdicionados.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2 });
            dgvAdicionados.Location = new Point(12, 531);
            dgvAdicionados.Name = "dgvAdicionados";
            dgvAdicionados.RowHeadersVisible = false;
            dgvAdicionados.RowHeadersWidth = 51;
            dgvAdicionados.Size = new Size(594, 204);
            dgvAdicionados.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewCellStyle3.Font = new Font("Uber Move", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewTextBoxColumn1.HeaderText = "Nome";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 290;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewCellStyle4.Font = new Font("Uber Move", 13.8F, FontStyle.Bold);
            dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewTextBoxColumn2.HeaderText = "Fornecedor";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 300;
            // 
            // adicionarBtn
            // 
            adicionarBtn.Location = new Point(326, 426);
            adicionarBtn.Name = "adicionarBtn";
            adicionarBtn.Size = new Size(280, 42);
            adicionarBtn.TabIndex = 13;
            adicionarBtn.Text = "Adicionar produto";
            adicionarBtn.UseVisualStyleBackColor = true;
            adicionarBtn.Click += adicionarBtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(46, 782);
            label5.Name = "label5";
            label5.Size = new Size(123, 32);
            label5.TabIndex = 14;
            label5.Text = "Validade";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(28, 845);
            label6.Name = "label6";
            label6.Size = new Size(141, 32);
            label6.TabIndex = 15;
            label6.Text = "Descrição";
            // 
            // AddEditSolicitacaoForm
            // 
            AutoScaleDimensions = new SizeF(16F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.Gold;
            ClientSize = new Size(618, 1077);
            ControlBox = false;
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(adicionarBtn);
            Controls.Add(label4);
            Controls.Add(dgvAdicionados);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(salvarBtn);
            Controls.Add(cancelarBtn);
            Controls.Add(descTxt);
            Controls.Add(validadePicker);
            Controls.Add(dgvPesquisados);
            Controls.Add(searchPb);
            Controls.Add(nomeTxt);
            Controls.Add(tipoCb);
            Controls.Add(label1);
            Font = new Font("Uber Move", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(6, 5, 6, 5);
            Name = "AddEditSolicitacaoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nova Solicitação";
            ((System.ComponentModel.ISupportInitialize)searchPb).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPesquisados).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAdicionados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox tipoCb;
        private TextBox nomeTxt;
        private PictureBox searchPb;
        private DataGridView dgvPesquisados;
        private DateTimePicker validadePicker;
        private RichTextBox descTxt;
        private DataGridViewTextBoxColumn NomeColumn;
        private DataGridViewTextBoxColumn FornecedorColumn;
        private Button cancelarBtn;
        private Button salvarBtn;
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridView dgvAdicionados;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private Button adicionarBtn;
        private Label label5;
        private Label label6;
    }
}