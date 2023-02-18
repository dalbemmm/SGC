namespace UI
{
    partial class frmCad_Pessoas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCad_Pessoas));
            this.lbTitulo = new System.Windows.Forms.Label();
            this.lbCod = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtRG = new System.Windows.Forms.TextBox();
            this.lbRG = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.lbCPF = new System.Windows.Forms.Label();
            this.lbSexo = new System.Windows.Forms.Label();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.lbStatus = new System.Windows.Forms.Label();
            this.dtpDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.lbDtNascimento = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbCEP = new System.Windows.Forms.Label();
            this.mkCEP = new System.Windows.Forms.MaskedTextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lbCidade = new System.Windows.Forms.Label();
            this.txtUF = new System.Windows.Forms.TextBox();
            this.lbUF = new System.Windows.Forms.Label();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.lbLogradouro = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lbNumero = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lbBairro = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.lbComplemento = new System.Windows.Forms.Label();
            this.lbTelefone = new System.Windows.Forms.Label();
            this.cbRedesSociais = new System.Windows.Forms.ComboBox();
            this.lbRedesSociais = new System.Windows.Forms.Label();
            this.lvRedesSociais = new System.Windows.Forms.ListView();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAddRede = new System.Windows.Forms.Button();
            this.btnExcluirRede = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.cbTipoTelefone = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExcluiTelefone = new System.Windows.Forms.Button();
            this.btnAddTelefone = new System.Windows.Forms.Button();
            this.lvTelefone = new System.Windows.Forms.ListView();
            this.tIPOTELEFONEBUSINESSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tIPOTELEFONEBUSINESSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTitulo.Location = new System.Drawing.Point(199, 9);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(232, 21);
            this.lbTitulo.TabIndex = 0;
            this.lbTitulo.Text = "..:: CADASTRO DE PESSOAS ::..";
            // 
            // lbCod
            // 
            this.lbCod.AutoSize = true;
            this.lbCod.Location = new System.Drawing.Point(12, 42);
            this.lbCod.Name = "lbCod";
            this.lbCod.Size = new System.Drawing.Size(46, 15);
            this.lbCod.TabIndex = 1;
            this.lbCod.Text = "Código";
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(12, 60);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(57, 23);
            this.txtCod.TabIndex = 2;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(12, 114);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(604, 23);
            this.txtNome.TabIndex = 1;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            this.txtNome.Leave += new System.EventHandler(this.txtNome_Leave);
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(12, 96);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(40, 15);
            this.lbNome.TabIndex = 3;
            this.lbNome.Text = "Nome";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.Location = new System.Drawing.Point(75, 55);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(31, 31);
            this.btnPesquisar.TabIndex = 26;
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtRG
            // 
            this.txtRG.Location = new System.Drawing.Point(12, 161);
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(146, 23);
            this.txtRG.TabIndex = 2;
            this.txtRG.Leave += new System.EventHandler(this.txtRG_Leave);
            // 
            // lbRG
            // 
            this.lbRG.AutoSize = true;
            this.lbRG.Location = new System.Drawing.Point(12, 143);
            this.lbRG.Name = "lbRG";
            this.lbRG.Size = new System.Drawing.Size(22, 15);
            this.lbRG.TabIndex = 6;
            this.lbRG.Text = "RG";
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(164, 161);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(173, 23);
            this.txtCPF.TabIndex = 3;
            this.txtCPF.Leave += new System.EventHandler(this.txtCPF_Leave);
            // 
            // lbCPF
            // 
            this.lbCPF.AutoSize = true;
            this.lbCPF.Location = new System.Drawing.Point(164, 143);
            this.lbCPF.Name = "lbCPF";
            this.lbCPF.Size = new System.Drawing.Size(28, 15);
            this.lbCPF.TabIndex = 8;
            this.lbCPF.Text = "CPF";
            // 
            // lbSexo
            // 
            this.lbSexo.AutoSize = true;
            this.lbSexo.Location = new System.Drawing.Point(346, 143);
            this.lbSexo.Name = "lbSexo";
            this.lbSexo.Size = new System.Drawing.Size(32, 15);
            this.lbSexo.TabIndex = 10;
            this.lbSexo.Text = "Sexo";
            // 
            // cbSexo
            // 
            this.cbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Location = new System.Drawing.Point(346, 161);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(123, 23);
            this.cbSexo.TabIndex = 4;
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(486, 60);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(130, 23);
            this.cbStatus.TabIndex = 27;
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(486, 42);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(39, 15);
            this.lbStatus.TabIndex = 12;
            this.lbStatus.Text = "Status";
            // 
            // dtpDataNascimento
            // 
            this.dtpDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNascimento.Location = new System.Drawing.Point(479, 161);
            this.dtpDataNascimento.Name = "dtpDataNascimento";
            this.dtpDataNascimento.Size = new System.Drawing.Size(137, 23);
            this.dtpDataNascimento.TabIndex = 5;
            // 
            // lbDtNascimento
            // 
            this.lbDtNascimento.AutoSize = true;
            this.lbDtNascimento.Location = new System.Drawing.Point(479, 143);
            this.lbDtNascimento.Name = "lbDtNascimento";
            this.lbDtNascimento.Size = new System.Drawing.Size(98, 15);
            this.lbDtNascimento.TabIndex = 15;
            this.lbDtNascimento.Text = "Data Nascimento";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(12, 205);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(604, 23);
            this.txtEmail.TabIndex = 6;
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(12, 187);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(41, 15);
            this.lbEmail.TabIndex = 16;
            this.lbEmail.Text = "E-mail";
            // 
            // lbCEP
            // 
            this.lbCEP.AutoSize = true;
            this.lbCEP.Location = new System.Drawing.Point(12, 236);
            this.lbCEP.Name = "lbCEP";
            this.lbCEP.Size = new System.Drawing.Size(28, 15);
            this.lbCEP.TabIndex = 18;
            this.lbCEP.Text = "CEP";
            // 
            // mkCEP
            // 
            this.mkCEP.Location = new System.Drawing.Point(12, 254);
            this.mkCEP.Mask = "00000-000";
            this.mkCEP.Name = "mkCEP";
            this.mkCEP.Size = new System.Drawing.Size(104, 23);
            this.mkCEP.TabIndex = 7;
            this.mkCEP.Leave += new System.EventHandler(this.mkCEP_Leave);
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(130, 254);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(321, 23);
            this.txtCidade.TabIndex = 8;
            this.txtCidade.Leave += new System.EventHandler(this.txtCidade_Leave);
            // 
            // lbCidade
            // 
            this.lbCidade.AutoSize = true;
            this.lbCidade.Location = new System.Drawing.Point(130, 236);
            this.lbCidade.Name = "lbCidade";
            this.lbCidade.Size = new System.Drawing.Size(44, 15);
            this.lbCidade.TabIndex = 20;
            this.lbCidade.Text = "Cidade";
            // 
            // txtUF
            // 
            this.txtUF.Location = new System.Drawing.Point(461, 254);
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(155, 23);
            this.txtUF.TabIndex = 9;
            this.txtUF.Leave += new System.EventHandler(this.txtUF_Leave);
            // 
            // lbUF
            // 
            this.lbUF.AutoSize = true;
            this.lbUF.Location = new System.Drawing.Point(461, 236);
            this.lbUF.Name = "lbUF";
            this.lbUF.Size = new System.Drawing.Size(21, 15);
            this.lbUF.TabIndex = 22;
            this.lbUF.Text = "UF";
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Location = new System.Drawing.Point(12, 308);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(439, 23);
            this.txtLogradouro.TabIndex = 10;
            this.txtLogradouro.TextChanged += new System.EventHandler(this.txtLogradouro_TextChanged);
            this.txtLogradouro.Leave += new System.EventHandler(this.txtLogradouro_Leave);
            // 
            // lbLogradouro
            // 
            this.lbLogradouro.AutoSize = true;
            this.lbLogradouro.Location = new System.Drawing.Point(12, 290);
            this.lbLogradouro.Name = "lbLogradouro";
            this.lbLogradouro.Size = new System.Drawing.Size(69, 15);
            this.lbLogradouro.TabIndex = 24;
            this.lbLogradouro.Text = "Logradouro";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(461, 308);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(155, 23);
            this.txtNumero.TabIndex = 11;
            this.txtNumero.Leave += new System.EventHandler(this.txtNumero_Leave);
            // 
            // lbNumero
            // 
            this.lbNumero.AutoSize = true;
            this.lbNumero.Location = new System.Drawing.Point(461, 290);
            this.lbNumero.Name = "lbNumero";
            this.lbNumero.Size = new System.Drawing.Size(51, 15);
            this.lbNumero.TabIndex = 26;
            this.lbNumero.Text = "Número";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(12, 359);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(294, 23);
            this.txtBairro.TabIndex = 12;
            this.txtBairro.Leave += new System.EventHandler(this.txtBairro_Leave);
            // 
            // lbBairro
            // 
            this.lbBairro.AutoSize = true;
            this.lbBairro.Location = new System.Drawing.Point(12, 341);
            this.lbBairro.Name = "lbBairro";
            this.lbBairro.Size = new System.Drawing.Size(38, 15);
            this.lbBairro.TabIndex = 28;
            this.lbBairro.Text = "Bairro";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(322, 359);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(294, 23);
            this.txtComplemento.TabIndex = 13;
            this.txtComplemento.Leave += new System.EventHandler(this.txtComplemento_Leave);
            // 
            // lbComplemento
            // 
            this.lbComplemento.AutoSize = true;
            this.lbComplemento.Location = new System.Drawing.Point(322, 341);
            this.lbComplemento.Name = "lbComplemento";
            this.lbComplemento.Size = new System.Drawing.Size(84, 15);
            this.lbComplemento.TabIndex = 30;
            this.lbComplemento.Text = "Complemento";
            // 
            // lbTelefone
            // 
            this.lbTelefone.AutoSize = true;
            this.lbTelefone.Location = new System.Drawing.Point(12, 437);
            this.lbTelefone.Name = "lbTelefone";
            this.lbTelefone.Size = new System.Drawing.Size(51, 15);
            this.lbTelefone.TabIndex = 32;
            this.lbTelefone.Text = "Telefone";
            // 
            // cbRedesSociais
            // 
            this.cbRedesSociais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRedesSociais.FormattingEnabled = true;
            this.cbRedesSociais.Location = new System.Drawing.Point(12, 529);
            this.cbRedesSociais.Name = "cbRedesSociais";
            this.cbRedesSociais.Size = new System.Drawing.Size(252, 23);
            this.cbRedesSociais.TabIndex = 18;
            // 
            // lbRedesSociais
            // 
            this.lbRedesSociais.AutoSize = true;
            this.lbRedesSociais.Location = new System.Drawing.Point(12, 511);
            this.lbRedesSociais.Name = "lbRedesSociais";
            this.lbRedesSociais.Size = new System.Drawing.Size(77, 15);
            this.lbRedesSociais.TabIndex = 34;
            this.lbRedesSociais.Text = "Redes Sociais";
            // 
            // lvRedesSociais
            // 
            this.lvRedesSociais.Location = new System.Drawing.Point(322, 511);
            this.lvRedesSociais.Name = "lvRedesSociais";
            this.lvRedesSociais.Size = new System.Drawing.Size(294, 97);
            this.lvRedesSociais.TabIndex = 36;
            this.lvRedesSociais.UseCompatibleStateImageBehavior = false;
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(533, 631);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(83, 34);
            this.btnFechar.TabIndex = 25;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpar.Location = new System.Drawing.Point(101, 631);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(83, 34);
            this.btnLimpar.TabIndex = 23;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGravar.Location = new System.Drawing.Point(12, 631);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(83, 34);
            this.btnGravar.TabIndex = 22;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(199, 631);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(83, 34);
            this.btnExcluir.TabIndex = 24;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAddRede
            // 
            this.btnAddRede.Image = ((System.Drawing.Image)(resources.GetObject("btnAddRede.Image")));
            this.btnAddRede.Location = new System.Drawing.Point(270, 511);
            this.btnAddRede.Name = "btnAddRede";
            this.btnAddRede.Size = new System.Drawing.Size(36, 25);
            this.btnAddRede.TabIndex = 20;
            this.btnAddRede.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddRede.UseVisualStyleBackColor = true;
            this.btnAddRede.Click += new System.EventHandler(this.btnAddRede_Click);
            // 
            // btnExcluirRede
            // 
            this.btnExcluirRede.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluirRede.Image")));
            this.btnExcluirRede.Location = new System.Drawing.Point(270, 542);
            this.btnExcluirRede.Name = "btnExcluirRede";
            this.btnExcluirRede.Size = new System.Drawing.Size(36, 25);
            this.btnExcluirRede.TabIndex = 21;
            this.btnExcluirRede.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluirRede.UseVisualStyleBackColor = true;
            this.btnExcluirRede.Click += new System.EventHandler(this.btnExcluirRede_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(12, 573);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(294, 23);
            this.txtUsuario.TabIndex = 19;
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Location = new System.Drawing.Point(12, 555);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(47, 15);
            this.lbUsuario.TabIndex = 44;
            this.lbUsuario.Text = "Usuário";
            // 
            // cbTipoTelefone
            // 
            this.cbTipoTelefone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoTelefone.FormattingEnabled = true;
            this.cbTipoTelefone.Location = new System.Drawing.Point(12, 411);
            this.cbTipoTelefone.Name = "cbTipoTelefone";
            this.cbTipoTelefone.Size = new System.Drawing.Size(252, 23);
            this.cbTipoTelefone.TabIndex = 14;
            this.cbTipoTelefone.SelectedIndexChanged += new System.EventHandler(this.cbTipoTelefone_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 393);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 46;
            this.label1.Text = "Tipo Telefone";
            // 
            // btnExcluiTelefone
            // 
            this.btnExcluiTelefone.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluiTelefone.Image")));
            this.btnExcluiTelefone.Location = new System.Drawing.Point(270, 419);
            this.btnExcluiTelefone.Name = "btnExcluiTelefone";
            this.btnExcluiTelefone.Size = new System.Drawing.Size(36, 25);
            this.btnExcluiTelefone.TabIndex = 17;
            this.btnExcluiTelefone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluiTelefone.UseVisualStyleBackColor = true;
            this.btnExcluiTelefone.Click += new System.EventHandler(this.btnExcluiTelefone_Click);
            // 
            // btnAddTelefone
            // 
            this.btnAddTelefone.Image = ((System.Drawing.Image)(resources.GetObject("btnAddTelefone.Image")));
            this.btnAddTelefone.Location = new System.Drawing.Point(270, 388);
            this.btnAddTelefone.Name = "btnAddTelefone";
            this.btnAddTelefone.Size = new System.Drawing.Size(36, 25);
            this.btnAddTelefone.TabIndex = 16;
            this.btnAddTelefone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddTelefone.UseVisualStyleBackColor = true;
            this.btnAddTelefone.Click += new System.EventHandler(this.button2_Click);
            // 
            // lvTelefone
            // 
            this.lvTelefone.Location = new System.Drawing.Point(322, 393);
            this.lvTelefone.Name = "lvTelefone";
            this.lvTelefone.Size = new System.Drawing.Size(294, 97);
            this.lvTelefone.TabIndex = 50;
            this.lvTelefone.UseCompatibleStateImageBehavior = false;
            this.lvTelefone.View = System.Windows.Forms.View.List;
            // 
            // tIPOTELEFONEBUSINESSBindingSource
            // 
            this.tIPOTELEFONEBUSINESSBindingSource.DataSource = typeof(BUSINESS.TIPO_TELEFONE_BUSINESS);
            this.tIPOTELEFONEBUSINESSBindingSource.CurrentChanged += new System.EventHandler(this.tIPOTELEFONEBUSINESSBindingSource_CurrentChanged);
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(12, 455);
            this.txtTelefone.Mask = "(00) 00000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(294, 23);
            this.txtTelefone.TabIndex = 15;
            // 
            // frmCad_Pessoas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(638, 670);
            this.ControlBox = false;
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.lvTelefone);
            this.Controls.Add(this.btnExcluiTelefone);
            this.Controls.Add(this.btnAddTelefone);
            this.Controls.Add(this.cbTipoTelefone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lbUsuario);
            this.Controls.Add(this.btnExcluirRede);
            this.Controls.Add(this.btnAddRede);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.lvRedesSociais);
            this.Controls.Add(this.cbRedesSociais);
            this.Controls.Add(this.lbRedesSociais);
            this.Controls.Add(this.lbTelefone);
            this.Controls.Add(this.txtComplemento);
            this.Controls.Add(this.lbComplemento);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.lbBairro);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lbNumero);
            this.Controls.Add(this.txtLogradouro);
            this.Controls.Add(this.lbLogradouro);
            this.Controls.Add(this.txtUF);
            this.Controls.Add(this.lbUF);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.lbCidade);
            this.Controls.Add(this.mkCEP);
            this.Controls.Add(this.lbCEP);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbDtNascimento);
            this.Controls.Add(this.dtpDataNascimento);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.cbSexo);
            this.Controls.Add(this.lbSexo);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.lbCPF);
            this.Controls.Add(this.txtRG);
            this.Controls.Add(this.lbRG);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.lbCod);
            this.Controls.Add(this.lbTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCad_Pessoas";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmCad_Pessoas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tIPOTELEFONEBUSINESSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbTitulo;
        private Label lbCod;
        private TextBox txtCod;
        private TextBox txtNome;
        private Label lbNome;
        private Button btnPesquisar;
        private TextBox txtRG;
        private Label lbRG;
        private TextBox txtCPF;
        private Label lbCPF;
        private Label lbSexo;
        private ComboBox cbSexo;
        private ComboBox cbStatus;
        private Label lbStatus;
        private DateTimePicker dtpDataNascimento;
        private Label lbDtNascimento;
        private TextBox txtEmail;
        private Label lbEmail;
        private Label lbCEP;
        private MaskedTextBox mkCEP;
        private TextBox txtCidade;
        private Label lbCidade;
        private TextBox txtUF;
        private Label lbUF;
        private TextBox txtLogradouro;
        private Label lbLogradouro;
        private TextBox txtNumero;
        private Label lbNumero;
        private TextBox txtBairro;
        private Label lbBairro;
        private TextBox txtComplemento;
        private Label lbComplemento;
        private Label lbTelefone;
        private ComboBox cbRedesSociais;
        private Label lbRedesSociais;
        private ListView lvRedesSociais;
        private Button btnFechar;
        private Button btnLimpar;
        private Button btnGravar;
        private Button btnExcluir;
        private Button btnAddRede;
        private Button btnExcluirRede;
        private TextBox txtUsuario;
        private Label lbUsuario;
        private ComboBox cbTipoTelefone;
        private Label label1;
        private Button btnExcluiTelefone;
        private Button btnAddTelefone;
        private ListView lvTelefone;
        private BindingSource tIPOTELEFONEBUSINESSBindingSource;
        private MaskedTextBox txtTelefone;
    }
}