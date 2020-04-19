namespace TechStore.View
{
    partial class frmCadastroFornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroFornecedor));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvFornecedor = new System.Windows.Forms.DataGridView();
            this.fornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.tbId = new System.Windows.Forms.TextBox();
            this.lbId = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.btnBuscarEmail = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.btnBuscarInscMunicipal = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.mtbInscMunicipal = new System.Windows.Forms.MaskedTextBox();
            this.btnBuscarInscEstadual = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.mtbInscEstadual = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbCidade = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mtbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.tbBairro = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbComplemento = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnBuscarCep = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.mtbCep = new System.Windows.Forms.MaskedTextBox();
            this.mtbCnpj = new System.Windows.Forms.MaskedTextBox();
            this.tbNumero = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbEndereco = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscarCnpj = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscarNome = new System.Windows.Forms.Button();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.techStoreDataSet = new TechStore.TechStoreDataSet();
            this.fornecedorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fornecedorTableAdapter = new TechStore.TechStoreDataSetTableAdapters.fornecedorTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.techStoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAlterar);
            this.panel1.Controls.Add(this.btnLimpar);
            this.panel1.Controls.Add(this.btnExcluir);
            this.panel1.Controls.Add(this.btnRegistrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 73);
            this.panel1.TabIndex = 5;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAlterar.Location = new System.Drawing.Point(74, 4);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(68, 65);
            this.btnAlterar.TabIndex = 1;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLimpar.Location = new System.Drawing.Point(214, 4);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(68, 65);
            this.btnLimpar.TabIndex = 3;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExcluir.Location = new System.Drawing.Point(144, 4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(68, 65);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistrar.Image")));
            this.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRegistrar.Location = new System.Drawing.Point(4, 4);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(68, 65);
            this.btnRegistrar.TabIndex = 0;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvFornecedor);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(784, 388);
            this.panel2.TabIndex = 6;
            // 
            // dgvFornecedor
            // 
            this.dgvFornecedor.AllowUserToAddRows = false;
            this.dgvFornecedor.AllowUserToDeleteRows = false;
            this.dgvFornecedor.AutoGenerateColumns = false;
            this.dgvFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFornecedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14});
            this.dgvFornecedor.DataSource = this.fornecedorBindingSource1;
            this.dgvFornecedor.Location = new System.Drawing.Point(3, 272);
            this.dgvFornecedor.Name = "dgvFornecedor";
            this.dgvFornecedor.ReadOnly = true;
            this.dgvFornecedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFornecedor.Size = new System.Drawing.Size(778, 113);
            this.dgvFornecedor.TabIndex = 6;
            this.dgvFornecedor.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFornecedor_CellDoubleClick);
            // 
            // fornecedorBindingSource
            // 
            this.fornecedorBindingSource.DataMember = "fornecedor";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbEstado);
            this.groupBox1.Controls.Add(this.tbId);
            this.groupBox1.Controls.Add(this.lbId);
            this.groupBox1.Controls.Add(this.tbEmail);
            this.groupBox1.Controls.Add(this.btnBuscarEmail);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.btnBuscarInscMunicipal);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.mtbInscMunicipal);
            this.groupBox1.Controls.Add(this.btnBuscarInscEstadual);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.mtbInscEstadual);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tbCidade);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.mtbTelefone);
            this.groupBox1.Controls.Add(this.tbBairro);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbComplemento);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnBuscarCep);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.mtbCep);
            this.groupBox1.Controls.Add(this.mtbCnpj);
            this.groupBox1.Controls.Add(this.tbNumero);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbEndereco);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnBuscarCnpj);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnBuscarNome);
            this.groupBox1.Controls.Add(this.tbNome);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(4, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(777, 260);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastrar fornecedor";
            // 
            // cbEstado
            // 
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "Acre",
            "Alagoas",
            "Amapá",
            "Amazonas",
            "Bahia",
            "Ceará",
            "Distrito Federal",
            "Espírito Santo",
            "Goiás",
            "Maranhão",
            "Mato Grosso",
            "Mato Grosso do Sul",
            "Minas Gerais",
            "Pará",
            "Paraíba",
            "Paraná",
            "Pernambuco",
            "Piauí",
            "Rio de Janeiro",
            "Rio Grande do Norte",
            "Rio Grande do Sul",
            "Rondônia",
            "Roraima",
            "Santa Catarina",
            "São Paulo",
            "Sergipe",
            "Tocantins"});
            this.cbEstado.Location = new System.Drawing.Point(226, 175);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(165, 21);
            this.cbEstado.TabIndex = 13;
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(11, 40);
            this.tbId.Name = "tbId";
            this.tbId.ReadOnly = true;
            this.tbId.Size = new System.Drawing.Size(57, 20);
            this.tbId.TabIndex = 0;
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(8, 23);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(18, 13);
            this.lbId.TabIndex = 35;
            this.lbId.Text = "ID";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(380, 224);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(323, 20);
            this.tbEmail.TabIndex = 18;
            // 
            // btnBuscarEmail
            // 
            this.btnBuscarEmail.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarEmail.Image")));
            this.btnBuscarEmail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarEmail.Location = new System.Drawing.Point(709, 223);
            this.btnBuscarEmail.Name = "btnBuscarEmail";
            this.btnBuscarEmail.Size = new System.Drawing.Size(63, 23);
            this.btnBuscarEmail.TabIndex = 19;
            this.btnBuscarEmail.Text = "Buscar";
            this.btnBuscarEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarEmail.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(377, 208);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 13);
            this.label13.TabIndex = 31;
            this.label13.Text = "E-mail";
            // 
            // btnBuscarInscMunicipal
            // 
            this.btnBuscarInscMunicipal.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarInscMunicipal.Image")));
            this.btnBuscarInscMunicipal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarInscMunicipal.Location = new System.Drawing.Point(301, 223);
            this.btnBuscarInscMunicipal.Name = "btnBuscarInscMunicipal";
            this.btnBuscarInscMunicipal.Size = new System.Drawing.Size(63, 23);
            this.btnBuscarInscMunicipal.TabIndex = 17;
            this.btnBuscarInscMunicipal.Text = "Buscar";
            this.btnBuscarInscMunicipal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarInscMunicipal.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(192, 208);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "Inscrição Municipal";
            // 
            // mtbInscMunicipal
            // 
            this.mtbInscMunicipal.Location = new System.Drawing.Point(195, 224);
            this.mtbInscMunicipal.Mask = "0000000000-0";
            this.mtbInscMunicipal.Name = "mtbInscMunicipal";
            this.mtbInscMunicipal.Size = new System.Drawing.Size(100, 20);
            this.mtbInscMunicipal.TabIndex = 16;
            this.mtbInscMunicipal.ValidatingType = typeof(int);
            // 
            // btnBuscarInscEstadual
            // 
            this.btnBuscarInscEstadual.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarInscEstadual.Image")));
            this.btnBuscarInscEstadual.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarInscEstadual.Location = new System.Drawing.Point(117, 223);
            this.btnBuscarInscEstadual.Name = "btnBuscarInscEstadual";
            this.btnBuscarInscEstadual.Size = new System.Drawing.Size(63, 23);
            this.btnBuscarInscEstadual.TabIndex = 15;
            this.btnBuscarInscEstadual.Text = "Buscar";
            this.btnBuscarInscEstadual.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarInscEstadual.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 208);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Inscrição Estadual";
            // 
            // mtbInscEstadual
            // 
            this.mtbInscEstadual.Location = new System.Drawing.Point(11, 224);
            this.mtbInscEstadual.Mask = "000.000.000.000";
            this.mtbInscEstadual.Name = "mtbInscEstadual";
            this.mtbInscEstadual.Size = new System.Drawing.Size(100, 20);
            this.mtbInscEstadual.TabIndex = 14;
            this.mtbInscEstadual.ValidatingType = typeof(int);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(223, 161);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Estado";
            // 
            // tbCidade
            // 
            this.tbCidade.Location = new System.Drawing.Point(11, 176);
            this.tbCidade.Name = "tbCidade";
            this.tbCidade.Size = new System.Drawing.Size(197, 20);
            this.tbCidade.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 161);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Cidade";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(600, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Telefone";
            // 
            // mtbTelefone
            // 
            this.mtbTelefone.Location = new System.Drawing.Point(603, 128);
            this.mtbTelefone.Mask = "(00) 0000-0000";
            this.mtbTelefone.Name = "mtbTelefone";
            this.mtbTelefone.Size = new System.Drawing.Size(100, 20);
            this.mtbTelefone.TabIndex = 11;
            // 
            // tbBairro
            // 
            this.tbBairro.Location = new System.Drawing.Point(429, 128);
            this.tbBairro.Name = "tbBairro";
            this.tbBairro.Size = new System.Drawing.Size(168, 20);
            this.tbBairro.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(426, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Bairro";
            // 
            // tbComplemento
            // 
            this.tbComplemento.Location = new System.Drawing.Point(11, 128);
            this.tbComplemento.Name = "tbComplemento";
            this.tbComplemento.Size = new System.Drawing.Size(408, 20);
            this.tbComplemento.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Complemento";
            // 
            // btnBuscarCep
            // 
            this.btnBuscarCep.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarCep.Image")));
            this.btnBuscarCep.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarCep.Location = new System.Drawing.Point(709, 85);
            this.btnBuscarCep.Name = "btnBuscarCep";
            this.btnBuscarCep.Size = new System.Drawing.Size(63, 23);
            this.btnBuscarCep.TabIndex = 8;
            this.btnBuscarCep.Text = "Buscar";
            this.btnBuscarCep.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarCep.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(600, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "CEP";
            // 
            // mtbCep
            // 
            this.mtbCep.Location = new System.Drawing.Point(603, 86);
            this.mtbCep.Mask = "00000-000";
            this.mtbCep.Name = "mtbCep";
            this.mtbCep.Size = new System.Drawing.Size(100, 20);
            this.mtbCep.TabIndex = 7;
            this.mtbCep.ValidatingType = typeof(int);
            // 
            // mtbCnpj
            // 
            this.mtbCnpj.Location = new System.Drawing.Point(588, 41);
            this.mtbCnpj.Mask = "00.000.000/0000-00";
            this.mtbCnpj.Name = "mtbCnpj";
            this.mtbCnpj.Size = new System.Drawing.Size(111, 20);
            this.mtbCnpj.TabIndex = 3;
            this.mtbCnpj.ValidatingType = typeof(int);
            // 
            // tbNumero
            // 
            this.tbNumero.Location = new System.Drawing.Point(486, 86);
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.Size = new System.Drawing.Size(111, 20);
            this.tbNumero.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(483, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Número";
            // 
            // tbEndereco
            // 
            this.tbEndereco.Location = new System.Drawing.Point(11, 86);
            this.tbEndereco.Name = "tbEndereco";
            this.tbEndereco.Size = new System.Drawing.Size(469, 20);
            this.tbEndereco.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Endereço";
            // 
            // btnBuscarCnpj
            // 
            this.btnBuscarCnpj.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarCnpj.Image")));
            this.btnBuscarCnpj.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarCnpj.Location = new System.Drawing.Point(705, 40);
            this.btnBuscarCnpj.Name = "btnBuscarCnpj";
            this.btnBuscarCnpj.Size = new System.Drawing.Size(63, 23);
            this.btnBuscarCnpj.TabIndex = 4;
            this.btnBuscarCnpj.Text = "Buscar";
            this.btnBuscarCnpj.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarCnpj.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(585, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "CNPJ";
            // 
            // btnBuscarNome
            // 
            this.btnBuscarNome.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarNome.Image")));
            this.btnBuscarNome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarNome.Location = new System.Drawing.Point(513, 40);
            this.btnBuscarNome.Name = "btnBuscarNome";
            this.btnBuscarNome.Size = new System.Drawing.Size(63, 23);
            this.btnBuscarNome.TabIndex = 2;
            this.btnBuscarNome.Text = "Buscar";
            this.btnBuscarNome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarNome.UseVisualStyleBackColor = true;
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(82, 41);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(425, 20);
            this.tbNome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome/Razão social";
            // 
            // techStoreDataSet
            // 
            this.techStoreDataSet.DataSetName = "TechStoreDataSet";
            this.techStoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fornecedorBindingSource1
            // 
            this.fornecedorBindingSource1.DataMember = "fornecedor";
            this.fornecedorBindingSource1.DataSource = this.techStoreDataSet;
            // 
            // fornecedorTableAdapter
            // 
            this.fornecedorTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idfornecedor";
            this.dataGridViewTextBoxColumn1.HeaderText = "idfornecedor";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "cnpj";
            this.dataGridViewTextBoxColumn3.HeaderText = "cnpj";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "endereco";
            this.dataGridViewTextBoxColumn4.HeaderText = "endereco";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "numero";
            this.dataGridViewTextBoxColumn5.HeaderText = "numero";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "cep";
            this.dataGridViewTextBoxColumn6.HeaderText = "cep";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "complemento";
            this.dataGridViewTextBoxColumn7.HeaderText = "complemento";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "bairro";
            this.dataGridViewTextBoxColumn8.HeaderText = "bairro";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "telefone";
            this.dataGridViewTextBoxColumn9.HeaderText = "telefone";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "cidade";
            this.dataGridViewTextBoxColumn10.HeaderText = "cidade";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "estado";
            this.dataGridViewTextBoxColumn11.HeaderText = "estado";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "insc_estadual";
            this.dataGridViewTextBoxColumn12.HeaderText = "insc_estadual";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "insc_municipal";
            this.dataGridViewTextBoxColumn13.HeaderText = "insc_municipal";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "email";
            this.dataGridViewTextBoxColumn14.HeaderText = "email";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // frmCadastroFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmCadastroFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Fornecedor";
            this.Load += new System.EventHandler(this.frmCadastroFornecedor_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.techStoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvFornecedor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbNumero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbEndereco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuscarCnpj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscarNome;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbCidade;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mtbTelefone;
        private System.Windows.Forms.TextBox tbBairro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbComplemento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnBuscarCep;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mtbCep;
        private System.Windows.Forms.MaskedTextBox mtbCnpj;
        private System.Windows.Forms.Button btnBuscarInscMunicipal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox mtbInscMunicipal;
        private System.Windows.Forms.Button btnBuscarInscEstadual;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox mtbInscEstadual;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Button btnBuscarEmail;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.BindingSource fornecedorBindingSource;
        public System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.ComboBox cbEstado;
        private TechStoreDataSet techStoreDataSet;
        private System.Windows.Forms.BindingSource fornecedorBindingSource1;
        private TechStoreDataSetTableAdapters.fornecedorTableAdapter fornecedorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
    }
}