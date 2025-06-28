namespace PonteDouradaM2_v2
{
    partial class ProdutosForm
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
            editarBtn = new Button();
            novoBtn = new Button();
            dgvProdutos = new DataGridView();
            NomeColumn = new DataGridViewTextBoxColumn();
            TipoColumn = new DataGridViewTextBoxColumn();
            FornecedorColumn = new DataGridViewTextBoxColumn();
            DataColumn = new DataGridViewTextBoxColumn();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // editarBtn
            // 
            editarBtn.BackColor = Color.White;
            editarBtn.Location = new Point(792, 610);
            editarBtn.Name = "editarBtn";
            editarBtn.Size = new Size(186, 47);
            editarBtn.TabIndex = 9;
            editarBtn.Text = "Editar";
            editarBtn.UseVisualStyleBackColor = false;
            // 
            // novoBtn
            // 
            novoBtn.BackColor = Color.White;
            novoBtn.Location = new Point(995, 610);
            novoBtn.Name = "novoBtn";
            novoBtn.Size = new Size(143, 47);
            novoBtn.TabIndex = 8;
            novoBtn.Text = "Novo";
            novoBtn.UseVisualStyleBackColor = false;
            // 
            // dgvSolicitacoes
            // 
            dgvProdutos.BackgroundColor = Color.White;
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutos.Columns.AddRange(new DataGridViewColumn[] { NomeColumn, TipoColumn, FornecedorColumn, DataColumn });
            dgvProdutos.Location = new Point(11, 215);
            dgvProdutos.Name = "dgvSolicitacoes";
            dgvProdutos.RowHeadersVisible = false;
            dgvProdutos.RowHeadersWidth = 51;
            dgvProdutos.Size = new Size(1127, 382);
            dgvProdutos.TabIndex = 7;
            // 
            // NomeColumn
            // 
            dataGridViewCellStyle1.Font = new Font("Uber Move", 13.8F, FontStyle.Bold);
            NomeColumn.DefaultCellStyle = dataGridViewCellStyle1;
            NomeColumn.HeaderText = "Nome";
            NomeColumn.MinimumWidth = 6;
            NomeColumn.Name = "NomeColumn";
            NomeColumn.Width = 300;
            // 
            // TipoColumn
            // 
            dataGridViewCellStyle2.Font = new Font("Uber Move", 13.8F, FontStyle.Bold);
            TipoColumn.DefaultCellStyle = dataGridViewCellStyle2;
            TipoColumn.HeaderText = "Tipo";
            TipoColumn.MinimumWidth = 6;
            TipoColumn.Name = "TipoColumn";
            TipoColumn.Width = 300;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Uber Move", 35.9999962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(553, 65);
            label1.Name = "label1";
            label1.Size = new Size(282, 72);
            label1.TabIndex = 6;
            label1.Text = "Produtos";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(10, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(427, 192);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Produtos
            // 
            AutoScaleDimensions = new SizeF(16F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gold;
            Controls.Add(editarBtn);
            Controls.Add(novoBtn);
            Controls.Add(dgvProdutos);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Font = new Font("Uber Move", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(6, 5, 6, 5);
            Name = "Produtos";
            Size = new Size(1149, 668);
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button editarBtn;
        private Button novoBtn;
        private DataGridView dgvProdutos;
        private DataGridViewTextBoxColumn NomeColumn;
        private DataGridViewTextBoxColumn TipoColumn;
        private DataGridViewTextBoxColumn FornecedorColumn;
        private DataGridViewTextBoxColumn DataColumn;
        private Label label1;
        private PictureBox pictureBox1;
    }
}
