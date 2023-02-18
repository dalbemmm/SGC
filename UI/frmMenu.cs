using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            gbInformacoes.Enabled = false;
            lbData.Text = "Data - " + (DateTime.Now.ToShortDateString());
            lbHora.Text = "Hora - " + (DateTime.Now.ToShortTimeString());
            lbLogin.Text = "Login - " + GLOBAIS.Global_Usu.usu_login.ToString();
            lbNome.Text = "Nome - " + GLOBAIS.Global_Usu.usu_pessoa.Pes_nome.ToString();

            pbLogo.Location = new System.Drawing.Point(550,100);
        }

        private void Menu_Leave(object sender, EventArgs e)
        {


        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void tmTimer_Tick(object sender, EventArgs e)
        {
            lbHora.Text = "Hora - " + DateTime.Now.ToShortTimeString();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GLOBAIS objGlobal = new GLOBAIS();
            objGlobal.LogOut();

            this.Close();

         
        }
    }
}
