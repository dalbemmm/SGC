using MODEL;

namespace UI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            frmCad_Pessoas formu = new frmCad_Pessoas();
            formu.ShowDialog();
        }

        public void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (ValidaCampos())
            {
                MessageBox.Show("Deu certo");
                USUARIO usu = new USUARIO();
                usu.usu_login = txtLogin.Text;  
                usu.usu_senha = txtSenha.Text;

                // Procurar 
                // Validar
                GLOBAIS global = new GLOBAIS("Saymon Dalbem", "dalbemmm",001);
                // Abrir Menu
                this.Hide();
                frmMenu frmMenu = new frmMenu();
                frmMenu.ShowDialog();
            }
        }

        private void Limpar()
        {
            txtLogin.Text = "";
            txtSenha.Text = "";
            txtLogin.Focus();
        }

        #region "VALIDAÇÕES"
        private Boolean ValidaCampos()
        {
            ValidaCaracter();
            if (txtLogin.Text == "")
            {
                MessageBox.Show("Favor preencher o campo 'LOGIN'", "Erro", MessageBoxButtons.OK,MessageBoxIcon.Information);
                txtLogin.Focus();
                return false;
            }
            else
            {
                if (txtSenha.Text == "")
                {
                    MessageBox.Show("Favor preencher o campo 'SENHA'", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSenha.Focus();
                    return false;
                }
                else { return true; }
            }
        }

        private Boolean validaCampo(string campo)
        {
            if (campo.Contains('%'))
            {
                MessageBox.Show("Caracter '%' inválido.\nFavor verificar o que foi digitado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;

            }
            else if (campo.Contains('*'))
            {
                MessageBox.Show("Caracter '*' inválido.\nFavor verificar o que foi digitado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;

            }
            else if (campo.Contains('&'))
            {
                MessageBox.Show("Caracter '&' inválido.\nFavor verificar o que foi digitado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else return true;

        }

        private void ValidaCaracter()
        {
           
            txtLogin.Text = txtLogin.Text.Replace("%", "");
            txtLogin.Text = txtLogin.Text.Replace("*", "");
            txtLogin.Text = txtLogin.Text.Replace("&", "");
        }
        #endregion

        private void txtLogin_Leave(object sender, EventArgs e)
        {
            if (!validaCampo(txtLogin.Text)){
                txtLogin.Focus();
            }
        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            if (!validaCampo(txtSenha.Text))
            {
                txtSenha.Focus();
            }
        }
    }
}