namespace TechStore.View
{
    partial class frmEstoque
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
            this.components = new System.ComponentModel.Container();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvEstoque = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbProduto = new System.Windows.Forms.TextBox();
            this.entradaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.techStoreDataSet = new TechStore.TechStoreDataSet();
            this.entradaTableAdapter = new TechStore.TechStoreDataSetTableAdapters.entradaTableAdapter();
            this.estoqueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estoqueTableAdapter = new TechStore.TechStoreDataSetTableAdapters.estoqueTableAdapter();
            this.estoqueBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idestoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fk_produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtd_produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoque)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.entradaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techStoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvEstoque);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(431, 461);
            this.panel2.TabIndex = 1;
            // 
            // dgvEstoque
            // 
            this.dgvEstoque.AllowUserToAddRows = false;
            this.dgvEstoque.AllowUserToDeleteRows = false;
            this.dgvEstoque.AutoGenerateColumns = false;
            this.dgvEstoque.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstoque.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idestoque,
            this.fk_produto,
            this.produtoDataGridViewTextBoxColumn,
            this.qtd_produto});
            this.dgvEstoque.DataSource = this.estoqueBindingSource1;
            this.dgvEstoque.Location = new System.Drawing.Point(4, 58);
            this.dgvEstoque.Name = "dgvEstoque";
            this.dgvEstoque.ReadOnly = true;
            this.dgvEstoque.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEstoque.Size = new System.Drawing.Size(422, 400);
            this.dgvEstoque.TabIndex = 1;
            this.dgvEstoque.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEstoque_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbProduto);
            this.groupBox1.Location = new System.Drawing.Point(4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 49);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar produto";
            // 
            // tbProduto
            // 
            this.tbProduto.Location = new System.Drawing.Point(8, 20);
            this.tbProduto.Name = "tbProduto";
            this.tbProduto.Size = new System.Drawing.Size(407, 20);
            this.tbProduto.TabIndex = 4;
            this.tbProduto.TextChanged += new System.EventHandler(this.tbProduto_TextChanged);
            // 
            // entradaBindingSource
            // 
            this.entradaBindingSource.DataMember = "entrada";
            this.entradaBindingSource.DataSource = this.techStoreDataSet;
            // 
            // techStoreDataSet
            // 
            this.techStoreDataSet.DataSetName = "TechStoreDataSet";
            this.techStoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // entradaTableAdapter
            // 
            this.entradaTableAdapter.ClearBeforeFill = true;
            // 
            // estoqueBindingSource
            // 
            this.estoqueBindingSource.DataMember = "estoque";
            this.estoqueBindingSource.DataSource = this.techStoreDataSet;
            // 
            // estoqueTableAdapter
            // 
            this.estoqueTableAdapter.ClearBeforeFill = true;
            // 
            // estoqueBindingSource1
            // 
            this.estoqueBindingSource1.DataMember = "estoque";
            this.estoqueBindingSource1.DataSource = this.techStoreDataSet;
            // 
            // idestoque
            // 
            this.idestoque.DataPropertyName = "idestoque";
            this.idestoque.HeaderText = "idestoque";
            this.idestoque.Name = "idestoque";
            this.idestoque.ReadOnly = true;
            // 
            // fk_produto
            // 
            this.fk_produto.DataPropertyName = "fk_produto";
            this.fk_produto.HeaderText = "fk_produto";
            this.fk_produto.Name = "fk_produto";
            this.fk_produto.ReadOnly = true;
            // 
            // produtoDataGridViewTextBoxColumn
            // 
            this.produtoDataGridViewTextBoxColumn.DataPropertyName = "produto";
            this.produtoDataGridViewTextBoxColumn.HeaderText = "produto";
            this.produtoDataGridViewTextBoxColumn.Name = "produtoDataGridViewTextBoxColumn";
            this.produtoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qtd_produto
            // 
            this.qtd_produto.DataPropertyName = "qtd_produto";
            this.qtd_produto.HeaderText = "qtd_produto";
            this.qtd_produto.Name = "qtd_produto";
            this.qtd_produto.ReadOnly = true;
            // 
            // frmEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 461);
            this.Controls.Add(this.panel2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estoque";
            this.Load += new System.EventHandler(this.frmEstoque_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoque)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.entradaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techStoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbProduto;
        private System.Windows.Forms.DataGridView dgvEstoque;
        private TechStoreDataSet techStoreDataSet;
        private System.Windows.Forms.BindingSource entradaBindingSource;
        private TechStoreDataSetTableAdapters.entradaTableAdapter entradaTableAdapter;
        private System.Windows.Forms.BindingSource estoqueBindingSource;
        private TechStoreDataSetTableAdapters.estoqueTableAdapter estoqueTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idestoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn fk_produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn produtoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtd_produto;
        private System.Windows.Forms.BindingSource estoqueBindingSource1;
    }
}