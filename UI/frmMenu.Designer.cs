namespace UI
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.gbInformacoes = new System.Windows.Forms.GroupBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbLogin = new System.Windows.Forms.Label();
            this.lbHora = new System.Windows.Forms.Label();
            this.lbData = new System.Windows.Forms.Label();
            this.TmTimer = new System.Windows.Forms.Timer(this.components);
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pessoasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposDeFornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposDeEventosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbInformacoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.msMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbInformacoes
            // 
            this.gbInformacoes.Controls.Add(this.lbNome);
            this.gbInformacoes.Controls.Add(this.lbLogin);
            this.gbInformacoes.Controls.Add(this.lbHora);
            this.gbInformacoes.Controls.Add(this.lbData);
            this.gbInformacoes.Location = new System.Drawing.Point(12, 607);
            this.gbInformacoes.Name = "gbInformacoes";
            this.gbInformacoes.Size = new System.Drawing.Size(1009, 83);
            this.gbInformacoes.TabIndex = 0;
            this.gbInformacoes.TabStop = false;
            this.gbInformacoes.Text = "Informações do Sistema";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(3, 64);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(51, 15);
            this.lbNome.TabIndex = 3;
            this.lbNome.Text = "Nome - ";
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Location = new System.Drawing.Point(3, 49);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(45, 15);
            this.lbLogin.TabIndex = 2;
            this.lbLogin.Text = "Login -";
            // 
            // lbHora
            // 
            this.lbHora.AutoSize = true;
            this.lbHora.Location = new System.Drawing.Point(3, 34);
            this.lbHora.Name = "lbHora";
            this.lbHora.Size = new System.Drawing.Size(41, 15);
            this.lbHora.TabIndex = 1;
            this.lbHora.Text = "Hora -";
            // 
            // lbData
            // 
            this.lbData.AutoSize = true;
            this.lbData.Location = new System.Drawing.Point(3, 19);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(39, 15);
            this.lbData.TabIndex = 0;
            this.lbData.Text = "Data -";
            // 
            // TmTimer
            // 
            this.TmTimer.Enabled = true;
            this.TmTimer.Tick += new System.EventHandler(this.tmTimer_Tick);
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::UI.Properties.Resources.LOGO_SD_;
            this.pbLogo.Location = new System.Drawing.Point(451, 164);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(261, 262);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 1;
            this.pbLogo.TabStop = false;
            // 
            // msMenu
            // 
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.pesquisasToolStripMenuItem,
            this.logOutToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(1033, 24);
            this.msMenu.TabIndex = 2;
            this.msMenu.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioToolStripMenuItem,
            this.pessoasToolStripMenuItem,
            this.fornecedoresToolStripMenuItem,
            this.tiposDeFornecedoresToolStripMenuItem,
            this.eventosToolStripMenuItem,
            this.tiposDeEventosToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cadastrosToolStripMenuItem.Image")));
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            // 
            // pessoasToolStripMenuItem
            // 
            this.pessoasToolStripMenuItem.Name = "pessoasToolStripMenuItem";
            this.pessoasToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.pessoasToolStripMenuItem.Text = "Pessoas";
            // 
            // fornecedoresToolStripMenuItem
            // 
            this.fornecedoresToolStripMenuItem.Name = "fornecedoresToolStripMenuItem";
            this.fornecedoresToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.fornecedoresToolStripMenuItem.Text = "Fornecedores";
            // 
            // tiposDeFornecedoresToolStripMenuItem
            // 
            this.tiposDeFornecedoresToolStripMenuItem.Name = "tiposDeFornecedoresToolStripMenuItem";
            this.tiposDeFornecedoresToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.tiposDeFornecedoresToolStripMenuItem.Text = "Tipos de Fornecedores";
            // 
            // eventosToolStripMenuItem
            // 
            this.eventosToolStripMenuItem.Name = "eventosToolStripMenuItem";
            this.eventosToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.eventosToolStripMenuItem.Text = "Eventos";
            // 
            // tiposDeEventosToolStripMenuItem
            // 
            this.tiposDeEventosToolStripMenuItem.Name = "tiposDeEventosToolStripMenuItem";
            this.tiposDeEventosToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.tiposDeEventosToolStripMenuItem.Text = "Tipos de Eventos";
            // 
            // pesquisasToolStripMenuItem
            // 
            this.pesquisasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pesquisasToolStripMenuItem.Image")));
            this.pesquisasToolStripMenuItem.Name = "pesquisasToolStripMenuItem";
            this.pesquisasToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.pesquisasToolStripMenuItem.Text = "Pesquisas";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("logOutToolStripMenuItem.Image")));
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.logOutToolStripMenuItem.Text = "LogOut";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sairToolStripMenuItem.Image")));
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1033, 710);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.gbInformacoes);
            this.Controls.Add(this.msMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.msMenu;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.Leave += new System.EventHandler(this.Menu_Leave);
            this.gbInformacoes.ResumeLayout(false);
            this.gbInformacoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox gbInformacoes;
        private Label lbNome;
        private Label lbLogin;
        private Label lbHora;
        private Label lbData;
        private System.Windows.Forms.Timer TmTimer;
        private PictureBox pbLogo;
        private MenuStrip msMenu;
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private ToolStripMenuItem pesquisasToolStripMenuItem;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem usuarioToolStripMenuItem;
        private ToolStripMenuItem pessoasToolStripMenuItem;
        private ToolStripMenuItem fornecedoresToolStripMenuItem;
        private ToolStripMenuItem tiposDeFornecedoresToolStripMenuItem;
        private ToolStripMenuItem eventosToolStripMenuItem;
        private ToolStripMenuItem tiposDeEventosToolStripMenuItem;
    }
}