namespace PonteDouradaM2_v2
{
    partial class SolicitacoesForm
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            dgvSolicitacoes = new DataGridView();
            NomeColumn = new DataGridViewTextBoxColumn();
            TipoColumn = new DataGridViewTextBoxColumn();
            FornecedorColumn = new DataGridViewTextBoxColumn();
            DataColumn = new DataGridViewTextBoxColumn();
            novoBtn = new Button();
            editarBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSolicitacoes).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(10, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(427, 192);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Uber Move", 35.9999962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(553, 63);
            label1.Name = "label1";
            label1.Size = new Size(361, 72);
            label1.TabIndex = 1;
            label1.Text = "Solicitações";
            // 
            // dgvSolicitacoes
            // 
            dgvSolicitacoes.BackgroundColor = Color.White;
            dgvSolicitacoes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSolicitacoes.Columns.AddRange(new DataGridViewColumn[] { NomeColumn, TipoColumn, FornecedorColumn, DataColumn });
            dgvSolicitacoes.Location = new Point(11, 213);
            dgvSolicitacoes.Name = "dgvSolicitacoes";
            dgvSolicitacoes.RowHeadersVisible = false;
            dgvSolicitacoes.RowHeadersWidth = 51;
            dgvSolicitacoes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSolicitacoes.Size = new Size(1127, 382);
            dgvSolicitacoes.TabIndex = 2;
            // 
            // NomeColumn
            // 
            dataGridViewCellStyle1.Font = new Font("Uber Move", 13.8F, FontStyle.Bold);
            NomeColumn.DefaultCellStyle = dataGridViewCellStyle1;
            NomeColumn.HeaderText = "Id";
            NomeColumn.MinimumWidth = 6;
            NomeColumn.Name = "NomeColumn";
            NomeColumn.Width = 125;
            // 
            // TipoColumn
            // 
            dataGridViewCellStyle2.Font = new Font("Uber Move", 13.8F, FontStyle.Bold);
            TipoColumn.DefaultCellStyle = dataGridViewCellStyle2;
            TipoColumn.HeaderText = "Tipo";
            TipoColumn.MinimumWidth = 6;
            TipoColumn.Name = "TipoColumn";
            TipoColumn.Width = 500;
            // 
            // FornecedorColumn
            // 
            dataGridViewCellStyle3.Font = new Font("Uber Move", 13.8F, FontStyle.Bold);
            FornecedorColumn.DefaultCellStyle = dataGridViewCellStyle3;
            FornecedorColumn.HeaderText = "Fornecedor";
            FornecedorColumn.MinimumWidth = 6;
            FornecedorColumn.Name = "FornecedorColumn";
            FornecedorColumn.Width = 300;
            // 
            // DataColumn
            // 
            dataGridViewCellStyle4.Font = new Font("Uber Move", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DataColumn.DefaultCellStyle = dataGridViewCellStyle4;
            DataColumn.HeaderText = "Data de cadastro";
            DataColumn.MinimumWidth = 6;
            DataColumn.Name = "DataColumn";
            DataColumn.Width = 223;
            // 
            // novoBtn
            // 
            novoBtn.BackColor = Color.White;
            novoBtn.Location = new Point(995, 608);
            novoBtn.Name = "novoBtn";
            novoBtn.Size = new Size(143, 47);
            novoBtn.TabIndex = 3;
            novoBtn.Text = "Novo";
            novoBtn.UseVisualStyleBackColor = false;
            novoBtn.Click += novoBtn_Click;
            // 
            // editarBtn
            // 
            editarBtn.BackColor = Color.White;
            editarBtn.Location = new Point(792, 608);
            editarBtn.Name = "editarBtn";
            editarBtn.Size = new Size(186, 47);
            editarBtn.TabIndex = 4;
            editarBtn.Text = "Editar";
            editarBtn.UseVisualStyleBackColor = false;
            editarBtn.Click += editarBtn_Click;
            // 
            // SolicitacoesForm
            // 
            AutoScaleDimensions = new SizeF(16F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gold;
            Controls.Add(editarBtn);
            Controls.Add(novoBtn);
            Controls.Add(dgvSolicitacoes);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Font = new Font("Uber Move", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(6, 5, 6, 5);
            Name = "SolicitacoesForm";
            Size = new Size(1149, 668);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSolicitacoes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private DataGridView dgvSolicitacoes;
        private Button novoBtn;
        private Button editarBtn;
        private DataGridViewTextBoxColumn NomeColumn;
        private DataGridViewTextBoxColumn TipoColumn;
        private DataGridViewTextBoxColumn FornecedorColumn;
        private DataGridViewTextBoxColumn DataColumn;
    }
}
