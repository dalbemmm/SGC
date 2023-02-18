using BUSINESS;
using MODEL;
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
    public partial class frmBuscar_Pessoa : Form
    {
        public int Cod = -1;

        public frmBuscar_Pessoa()
        {
            InitializeComponent();
        }

        private void frmBuscar_Pessoa_Load(object sender, EventArgs e)
        {
            lvDados.Columns.Add("Código", 60).TextAlign = HorizontalAlignment.Right;
            lvDados.Columns.Add("Nome", 370).TextAlign = HorizontalAlignment.Left;


            // PARA APRESENTAR O CABEÇALHO
            lvDados.View = View.Details;

            // PARA SELECIONAR A LINHA INTEIRA
            lvDados.FullRowSelect = true;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void Buscar()
        {
            lvDados.Items.Clear();
            validarBusca();
            string nome;
            DataTable dat = new DataTable();
            if (txtNome.Text == "")
            {
                nome = "%";
            }
            else nome = txtNome.Text;

            PESSOA_BUSINESS ObjBus = new PESSOA_BUSINESS();
            PESSOA Obj = new PESSOA();
            
            Obj.Pes_nome = nome.ToLower();

            if (txtNome.Text == "")
            {
                dat = ObjBus.BuscarTodos();
            }
            else dat = ObjBus.BuscarPorNome(Obj);



            if (dat.Rows.Count > 0)
            {
                

                for (int i = 0; i < dat.Rows.Count; i++)
                {
                    string[] lista = { dat.Rows[i]["pes_cod"].ToString(), dat.Rows[i]["pes_nome"].ToString()};
                    lvDados.Items.Add(new ListViewItem(lista));
                }

            
            }


        }

        private void txtNome_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Buscar();
            }
        }

        private void validarBusca()
        {
            txtNome.Text = txtNome.Text.Trim();
            txtNome.Text = txtNome.Text.Replace("*", "");
            txtNome.Text = txtNome.Text.Replace("&", "");
            txtNome.Text = txtNome.Text.Replace("%", "");
        }

        private void lvDados_DoubleClick(object sender, EventArgs e)
        {
            foreach(ListViewItem item in lvDados.Items)
            {
                if (item.Selected)
                {
                    Cod = int.Parse(item.SubItems[0].Text);
                }
                
            }
            if(Cod != -1)
            {
                this.Close();
            }
        }
    }
}
