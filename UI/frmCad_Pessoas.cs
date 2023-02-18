using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUSINESS;
using MODEL;
using Refit;
using static System.Net.Mime.MediaTypeNames;

namespace UI
{
    public partial class frmCad_Pessoas : Form
    {
        public frmCad_Pessoas()
        {
            InitializeComponent();
        }

        private void frmCad_Pessoas_Load(object sender, EventArgs e)
        {
            IniciarForm();
        }

        #region "LOAD"
        
        private void IniciarForm()
        {
            lbTitulo.Location = new Point(200, 10);
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            this.BackColor= Color.White;

            CarregaComboSexo();
            CarregarComboStatus();
            CarregarComboRedeSocial();
            CarregarComboTipoTelefone();
            CriarListViewTelefone();
            CriarListViewRedesSociais();
            txtCod.Enabled = false;
            txtNome.Focus();
        }

        private void CarregaComboSexo()
        {
            cbSexo.Items.Clear();
            cbSexo.Items.Add("Masculino");
            cbSexo.Items.Add("Feminino");
            cbSexo.Text = "Masculino";
        }

        private void CarregarComboStatus()
        {
            DataTable dt = new DataTable();

            STATUS_BUSINESS ObjBus = new STATUS_BUSINESS();

            dt = ObjBus.BuscarTodos();

            if (dt.Rows.Count > 0)
            {
                cbStatus.Items.Clear();
                cbStatus.DataSource = dt;
                cbStatus.DisplayMember = "sta_descricao";
                cbStatus.ValueMember = "sta_cod";
            }
        }

        private void CarregarComboTipoTelefone()
        {
            cbTipoTelefone.Items.Clear();

            DataTable dt = new DataTable();

            TIPO_TELEFONE_BUSINESS ObjBus = new TIPO_TELEFONE_BUSINESS();

            dt = ObjBus.BuscarTodosTiposDeTelefoneDT();

            if(dt.Rows.Count > 0 )
            {
                cbTipoTelefone.Items.Clear();
                cbTipoTelefone.DataSource = dt; 
                cbTipoTelefone.DisplayMember = "tiptel_desc";
                cbTipoTelefone.ValueMember= "tiptel_cod";
                   
            }
        }

        private void CarregarComboRedeSocial()
        {
           DataTable dt = new DataTable();

           REDES_SOCIAIS_BUSINESS ObjBus = new REDES_SOCIAIS_BUSINESS();

            dt = ObjBus.BuscarTodos();

            if (dt.Rows.Count > 0)
            {
                cbRedesSociais.Items.Clear();
                cbRedesSociais.DataSource = dt;
                cbRedesSociais.DisplayMember = "red_descricao";
                cbRedesSociais.ValueMember = "red_cod";

            }
        }

        private void CriarListViewRedesSociais()
        {
            lvRedesSociais.Columns.Add("Rede Social",130).TextAlign = HorizontalAlignment.Center;
            lvRedesSociais.Columns.Add("red_cod",0).TextAlign = HorizontalAlignment.Center;
            lvRedesSociais.Columns.Add("Usuário",160).TextAlign= HorizontalAlignment.Center;

            // PARA APRESENTAR O CABEÇALHO
            lvRedesSociais.View = View.Details;

            // PARA SELECIONAR A LINHA INTEIRA
            lvRedesSociais.FullRowSelect = true;

        }

        private void CriarListViewTelefone()
        {
            lvTelefone.Columns.Add("Tipo",130).TextAlign = HorizontalAlignment.Center;
            lvTelefone.Columns.Add("TipCod", 0).TextAlign=HorizontalAlignment.Center;
            lvTelefone.Columns.Add("Telefone", 160).TextAlign = HorizontalAlignment.Center;
            
            // PARA APRESENTAR O CABEÇALHO 
            lvTelefone.View = View.Details;

            // PARA SELECIONAR A LINHA INTEIRA
            lvTelefone.FullRowSelect = true;
        }
        #endregion

        private void mkCEP_Leave(object sender, EventArgs e)
        {
            if(mkCEP.Text.Length < 9)
            {
                if (mkCEP.Text.Trim() != "-")
                {
                    MessageBox.Show("CEP incorreto!\nFavor verificar a quantidade de caracteres.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mkCEP.Focus();
                }
            }else 
            {
                BuscarCep(mkCEP.Text);
                txtNumero.Focus();
            }
            
        }

        async Task BuscarCep(string cep)
        {
            try
            {
                var CepBuscar = RestService.For<ICepApiService>("https://viacep.com.br/");
                var endereco = await CepBuscar.GetAdressAsync(cep);

                txtLogradouro.Text = endereco.Logradouro;
                txtBairro.Text = endereco.Bairro;
                txtCidade.Text = endereco.Localidade;
                txtUF.Text = endereco.Uf;
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro!\n" + e.Message.ToString());
                throw;
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (cbTipoTelefone.SelectedItem == null)
            {
                MessageBox.Show("Favor selecionar um tipo de telefone!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cbTipoTelefone.Focus();
            }
            else
            {
                txtTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                if (txtTelefone.Text == "")
                {
                    txtTelefone.TextMaskFormat = MaskFormat.IncludeLiterals;
                    MessageBox.Show("Favor digitar um telefone válido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtTelefone.Focus();
                }
                else
                {
                    txtTelefone.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
                    if (VerificaTelefone(txtTelefone.Text))
                    {
                        MessageBox.Show("Telefone já inserido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtTelefone.Focus();
                        txtTelefone.SelectAll();
                    }
                    else
                    {
                        string[] col = { cbTipoTelefone.Text, cbTipoTelefone.SelectedValue.ToString(), txtTelefone.Text };
                        lvTelefone.Items.Add(new ListViewItem(col));
                        txtTelefone.Clear();
                        txtTelefone.Focus();
                    }
                }
            }
        }

        private Boolean VerificaTelefone(string fone)
        {
            if (lvTelefone.Items.Count > 0)
            {
                for (int i=0; i<=lvTelefone.Items.Count -1; i++)
                {
                    if (lvTelefone.Items[i].SubItems[2].Text == fone)
                    {
                        return true;
                    }
                }
            }
            
            return false;
        }

        private Boolean VerificaRedesSociais(string red, string usu)
        {
            if (lvRedesSociais.Items.Count > 0)
            {
                for (int i = 0; i <= lvRedesSociais.Items.Count - 1; i++)
                {
                    if (lvRedesSociais.Items[i].SubItems[0].Text.ToUpper() == red.ToUpper())
                    {
                        if (lvRedesSociais.Items[i].SubItems[2].Text.ToUpper() == usu.ToUpper())
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }


        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExcluiTelefone_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvTelefone.Items)
            {
                if (item.Selected)
                {
                    lvTelefone.Items.RemoveAt(item.Index);
                }
            }
        }

        private void cbTipoTelefone_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnAddRede_Click(object sender, EventArgs e)
        {
            if (cbRedesSociais.SelectedItem == null)
            {
                MessageBox.Show("Favor selecionar uma Rede Social!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cbRedesSociais.Focus();
            }
            else if (txtUsuario.Text == "")
            {
                MessageBox.Show("Favor digitar um Usuário válido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtUsuario.Focus();
            }
            else
            {
                if (VerificaRedesSociais(cbRedesSociais.Text, txtUsuario.Text))
                {
                    MessageBox.Show("Rede Social já inserida", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtUsuario.Focus();
                    txtUsuario.SelectAll();
                }
                else
                {
                    string[] col = { cbRedesSociais.Text, cbRedesSociais.SelectedValue.ToString(), txtUsuario.Text };
                    lvRedesSociais.Items.Add(new ListViewItem(col));
                    txtUsuario.Clear();
                    txtUsuario.Focus();
                }
            }
        }

        private void btnExcluirRede_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvRedesSociais.Items)
            {
                if (item.Selected)
                {
                    lvRedesSociais.Items.RemoveAt(item.Index);
                }
            }
        }

        private Boolean ValidaForm()
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("Favor inserir um valor válido no campo 'NOME'. ", "Atenção",MessageBoxButtons.OK, MessageBoxIcon.Hand);

                txtNome.Focus();
                txtNome.SelectAll();
                return false;
            }

            if (txtRG.Text == "")
            {
                MessageBox.Show("Favor inserir um valor válido no campo 'RG'. ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Hand);

                txtRG.Focus();
                txtRG.SelectAll();
                return false;
            }

            if (txtCPF.Text == "")
            {
                MessageBox.Show("Favor inserir um valor válido no campo 'CPF'. ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Hand);

                txtCPF.Focus();
                txtCPF.SelectAll();
                return false;
            }

            if (dtpDataNascimento.Text == DateTime.Now.ToShortDateString().ToString())
            {
               
                MessageBox.Show("Favor inserir uma 'DATA DE NASCIMENTO' válida. ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Hand);

                dtpDataNascimento.Focus();
                return false;
            }

            if (txtEmail.Text == "")
            {
                MessageBox.Show("Favor inserir um valor válido no campo 'E-MAIL'. ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Hand);

                txtEmail.Focus();
                txtEmail.SelectAll();
                return false;
            }

            if (mkCEP.Text.Trim() == "-")
            {
                MessageBox.Show("Favor inserir um valor válido no campo 'CEP'. ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Hand);

                mkCEP.Focus();
                mkCEP.SelectAll();
                return false;
            }

            if (txtCidade.Text == "")
            {
                MessageBox.Show("Favor inserir um valor válido no campo 'CIDADE'. ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Hand);

                txtCidade.Focus();
                txtCidade.SelectAll();
                return false;
            }

            if (txtUF.Text == "")
            {
                MessageBox.Show("Favor inserir um valor válido no campo 'UF'. ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Hand);

                txtUF.Focus();
                txtUF.SelectAll();
                return false;
            }

            if (txtLogradouro.Text == "")
            {
                MessageBox.Show("Favor inserir um valor válido no campo 'LOGRADOURO'. ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Hand);

                txtLogradouro.Focus();
                txtLogradouro.SelectAll();
                return false;
            }

            if (txtNumero.Text == "")
            {
                MessageBox.Show("Favor inserir um valor válido no campo 'NÚMERO'. ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Hand);

                txtNumero.Focus();
                txtNumero.SelectAll();
                return false;
            }

            if (txtBairro.Text == "")
            {
                MessageBox.Show("Favor inserir um valor válido no campo 'BAIRRO'. ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Hand);

                txtBairro.Focus();
                txtBairro.SelectAll();
                return false;
            }
            return true;
        }

        #region "MÉTODOS DE VALIDAÇÃO"
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

        private List<PESSOA_TELEFONE> CarregarListaTelefone()
        {
            List<PESSOA_TELEFONE> lista = new List<PESSOA_TELEFONE>();

            for (int i = 0; i < lvTelefone.Items.Count; i++)
            {
                PESSOA_TELEFONE tel = new PESSOA_TELEFONE();
                string[] telefones;

                telefones = lvTelefone.Items[i].SubItems[2].Text.Split(' ');
                tel.Tel_ddd = telefones[0];
                tel.Tel_numero = telefones[1];
                tel.Tiptel_cod = int.Parse(lvTelefone.Items[i].SubItems[1].Text);
                if(txtCod.Text == "")
                {
                    tel.Pes_cod = 0;
                } else tel.Pes_cod   = int.Parse(txtCod.Text);
                lista.Add(tel);
                //MessageBox.Show("TEL_DDD: " + tel.Tel_ddd +
                //    "\nTEL_NUMERO: " + tel.Tel_numero +
                //    "\nTIPTEL_ID: " + tel.Tiptel_id);
            }

            return lista;
        }

        private List<PESSOA_REDES_SOCIAIS> CarregarListaRedesSociais()
        {
            List<PESSOA_REDES_SOCIAIS> lista = new List<PESSOA_REDES_SOCIAIS>();

            for (int i = 0; i < lvRedesSociais.Items.Count; i++)
            {
                PESSOA_REDES_SOCIAIS red = new PESSOA_REDES_SOCIAIS();  
               
                red.red_cod = int.Parse(lvRedesSociais.Items[i].SubItems[1].Text);
                red.pesred_usuario = lvRedesSociais.Items[i].SubItems[2].Text;
                if (txtCod.Text == "")
                {
                    red.pes_cod = 0;
                } else red.pes_cod = int.Parse(txtCod.Text);

                lista.Add(red);
                //MessageBox.Show("RED_COD: " + red.red_cod +
                //    "\npesred_usuario: " + red.pesred_usuario +
                //    "\nPES_COD: " + red.pes_cod);

            }

            return lista;
        }



        private PESSOA CarregaFormulario()
        {
            PESSOA objPessoa = new PESSOA();

            if(txtCod.Text != "")
            {
                objPessoa.Pes_cod = int.Parse(txtCod.Text);
            }

            objPessoa.Pes_nome = txtNome.Text;
            objPessoa.Sta_cod = int.Parse(cbStatus.SelectedValue.ToString());
            objPessoa.Pes_RG = txtRG.Text;
            objPessoa.Pes_CPFCNPJ = txtCPF.Text;

            if (cbSexo.Text == "Masculino")
            {
                objPessoa.Pes_sexo = 'M';
            }
            else objPessoa.Pes_sexo = 'F';

            objPessoa.Pes_datanascimento = DateTime.Parse(dtpDataNascimento.Text);
            objPessoa.Pes_email = txtEmail.Text;
            objPessoa.Pes_cep = mkCEP.Text;
            objPessoa.Pes_logradouro = txtLogradouro.Text;  
            objPessoa.Pes_numero = txtNumero.Text;
            objPessoa.Pes_uf = txtUF.Text;
            objPessoa.Pes_cidade = txtCidade.Text;
            objPessoa.Pes_bairro = txtBairro.Text;
            objPessoa.Pes_complemento = txtComplemento.Text;

            objPessoa.ListaRedesSociais = CarregarListaRedesSociais();
            objPessoa.ListaTelefones = CarregarListaTelefone();
            return objPessoa;
        }

        private void DescarregarFormulario(PESSOA objPessoa)
        {
            LimparForm();

            txtCod.Text = objPessoa.Pes_cod.ToString();
            txtNome.Text = objPessoa.Pes_nome;
            cbStatus.SelectedValue = objPessoa.Sta_cod;
            txtRG.Text = objPessoa.Pes_RG;
            txtCPF.Text = objPessoa.Pes_CPFCNPJ;


            if (objPessoa.Pes_sexo == 'M')
            {
                cbSexo.Text = "Masculino";
            } else cbSexo.Text = "Feminino";
            
            dtpDataNascimento.Value = objPessoa.Pes_datanascimento;
            txtEmail.Text = objPessoa.Pes_email;
            mkCEP.Text = objPessoa.Pes_cep;
            txtLogradouro.Text = objPessoa.Pes_logradouro;
            txtNumero.Text = objPessoa.Pes_numero;
            txtUF.Text = objPessoa.Pes_uf;
            txtCidade.Text = objPessoa.Pes_cidade;
            txtBairro.Text = objPessoa.Pes_bairro;
            txtComplemento.Text = objPessoa.Pes_complemento;


            lvRedesSociais.Items.Clear();
            lvTelefone.Items.Clear();

            for (int i = 0; i < objPessoa.ListaTelefones.Count; i++)
            {
                TIPO_TELEFONE_BUSINESS objtiptel = new TIPO_TELEFONE_BUSINESS();
                string ret = objtiptel.BuscarTipoTelefonePorCod(objPessoa.ListaTelefones[i].Tiptel_cod);
                string[] col = { ret, objPessoa.ListaTelefones[i].Tiptel_cod.ToString(), objPessoa.ListaTelefones[i].Tel_ddd.ToString() + objPessoa.ListaTelefones[i].Tel_numero.ToString() };

                lvTelefone.Items.Add(new ListViewItem(col));
            }

            //for (int x = 0; x < objPessoa.ListaRedesSociais.Count; x++)
            //{
            //    PESSOA_REDES_SOCIAIS_BUSINESS objpesredbus = new PESSOA_REDES_SOCIAIS_BUSINESS();
            //    string ret = objpesredbus.BuscarTipoTelefonePorCod(objPessoa.ListaTelefones[i].Tiptel_cod);
            //    string[] col = { ret, objPessoa.ListaTelefones[i].Tiptel_cod.ToString(), objPessoa.ListaTelefones[i].Tel_ddd.ToString() + objPessoa.ListaTelefones[i].Tel_numero.ToString() };

            //    lvTelefone.Items.Add(new ListViewItem(col));
            //}
        }

        private void LimparForm()
        {
            txtCod.Text = "";
            txtNome.Text = "";
            cbStatus.Text = "Ativo";
            txtRG.Text = "";
            txtCPF.Text = "";
            cbSexo.Text = "Masculino";
            dtpDataNascimento.Value = DateTime.Today;
            txtEmail.Text = "";
            mkCEP.Text = "";
            txtCidade.Text = "";
            txtUF.Text = "";
            txtLogradouro.Text = "";
            txtNumero.Text = "";
            txtBairro.Text = "";
            txtComplemento.Text = "";
            txtTelefone.Text = "";
            txtUsuario.Text = "";
            lvRedesSociais.Items.Clear();
            lvTelefone.Items.Clear();
            txtNome.Focus();
        }
        #endregion

        #region "VALIDAÇÃO"
        private void txtNome_Leave(object sender, EventArgs e)
        {
            if(!validaCampo(txtNome.Text))
            {
                txtNome.Focus();
                txtNome.SelectAll();
            }
        }

        private void txtRG_Leave(object sender, EventArgs e)
        {
            if (!validaCampo(txtRG.Text))
            {
                txtRG.Focus();
                txtRG.SelectAll();
            }
        }

        private void txtCPF_Leave(object sender, EventArgs e)
        {
            if (!validaCampo(txtCPF.Text))
            {
                txtCPF.Focus();
                txtCPF.SelectAll();
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (!validaCampo(txtEmail.Text))
            {
                txtEmail.Focus();
                txtEmail.SelectAll();
            }
        }

        private void txtCidade_Leave(object sender, EventArgs e)
        {
            if (!validaCampo(txtCidade.Text))
            {
                txtCidade.Focus();
                txtCidade.SelectAll();
            }
        }

        private void txtUF_Leave(object sender, EventArgs e)
        {
            if (!validaCampo(txtUF.Text))
            {
                txtUF.Focus();
                txtUF.SelectAll();
            }
        }

        private void txtLogradouro_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLogradouro_Leave(object sender, EventArgs e)
        {
            if (!validaCampo(txtLogradouro.Text))
            {
                txtLogradouro.Focus();
                txtLogradouro.SelectAll();
            }
        }

        private void txtNumero_Leave(object sender, EventArgs e)
        {
            if (!validaCampo(txtNumero.Text))
            {
                txtNumero.Focus();
                txtNumero.SelectAll();
            }
        }

        private void txtBairro_Leave(object sender, EventArgs e)
        {
            if (!validaCampo(txtBairro.Text))
            {
                txtBairro.Focus();
                txtBairro.SelectAll();
            }
        }

        private void txtComplemento_Leave(object sender, EventArgs e)
        {
            if (!validaCampo(txtComplemento.Text))
            {
                txtComplemento.Focus();
                txtComplemento.SelectAll();
            }
        }

        private void txtTelefone_Leave(object sender, EventArgs e)
        {
            if (!validaCampo(txtTelefone.Text))
            {
                txtTelefone.Focus();
                txtTelefone.SelectAll();
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (!validaCampo(txtUsuario.Text))
            {
                txtUsuario.Focus();
                txtUsuario.SelectAll();
            }
        }

        #endregion

        private void btnGravar_Click(object sender, EventArgs e)
        {
            ValidaForm();
            PESSOA objPessoa = new PESSOA();
            objPessoa = CarregaFormulario();

            PESSOA_BUSINESS ObjBus = new PESSOA_BUSINESS();
            try
            {
                if (ObjBus.Add(objPessoa))
                {
                    MessageBox.Show("Pessoa inserida com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparForm();
                }
                else MessageBox.Show("Erro ao inserir a pessoa!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:\n" + ex.Message.ToString());
                throw;
            }
           

           


        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparForm();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if(txtCod.Text == "")
            {
                MessageBox.Show("Favor selecionar uma pessoa para exclusão.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Hand);  ;
            }
            else
            {
                PESSOA obj = new PESSOA(int.Parse(txtCod.Text));
                PESSOA_BUSINESS ObjBusiness = new PESSOA_BUSINESS();

                if (ObjBusiness.Delete(obj))
                {
                    MessageBox.Show("Pessoa deletada com sucesso!", "Deletado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void tIPOTELEFONEBUSINESSBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmBuscar_Pessoa frmBPes = new frmBuscar_Pessoa();
            frmBPes.ShowDialog();
            int ret = frmBPes.Cod;

            if(ret != -1)
            {
                txtCod.Text = ret.ToString();
                PESSOA objPes = new PESSOA(ret);

                objPes = BuscarPorCod(ret);
            }

            
        }

        private PESSOA BuscarPorNome(string nome)
        {
            PESSOA Obj = new PESSOA();
            return Obj;
        }

        private PESSOA BuscarPorCod(int cod)
        {
            PESSOA objPessoa = new PESSOA(cod);

            PESSOA_BUSINESS objBus = new PESSOA_BUSINESS();

            try
            {
                LimparForm();
                
                objPessoa = CarregarObjDT(objBus.BuscarPorCod(objPessoa));
                DescarregarFormulario(objPessoa);
               

                return objPessoa;
            }
            catch (Exception)
            {

                throw;
            }


        }

        private PESSOA CarregarObjDT(DataTable dt) 
        {
            PESSOA objPessoa = new PESSOA();
            if (dt.Rows.Count > 0)
            {
                objPessoa.Pes_cod = int.Parse(dt.Rows[0]["pes_cod"].ToString());
                objPessoa.Pes_nome = dt.Rows[0]["pes_nome"].ToString();
                objPessoa.Sta_cod = int.Parse(dt.Rows[0]["sta_cod"].ToString());
                objPessoa.Pes_RG = dt.Rows[0]["pes_rg"].ToString();
                objPessoa.Pes_CPFCNPJ = dt.Rows[0]["pes_cpf"].ToString();
                if (dt.Rows[0]["pes_sexo"].ToString() == "M")
                {
                    objPessoa.Pes_sexo = 'M';
                }
                else objPessoa.Pes_sexo = 'F';

                objPessoa.Pes_datanascimento = DateTime.Parse(dt.Rows[0]["pes_datanascimento"].ToString());
                objPessoa.Pes_email = dt.Rows[0]["pes_email"].ToString();
                objPessoa.Pes_cep = dt.Rows[0]["pes_cep"].ToString();
                objPessoa.Pes_logradouro = dt.Rows[0]["pes_logradouro"].ToString();
                objPessoa.Pes_numero = dt.Rows[0]["pes_numero"].ToString();
                objPessoa.Pes_uf = dt.Rows[0]["pes_uf"].ToString();
                objPessoa.Pes_cidade = dt.Rows[0]["pes_cidade"].ToString();
                objPessoa.Pes_bairro = dt.Rows[0]["pes_bairro"].ToString();
                objPessoa.Pes_complemento = dt.Rows[0]["pes_complemento"].ToString();

                //CARREGAR LISTA DE TELEFONE
                PESSOA_TELEFONE_BUSINESS ObjPesTelBus = new PESSOA_TELEFONE_BUSINESS();
                DataTable dtTel = ObjPesTelBus.BuscarTelefonesPessoa(objPessoa.Pes_cod);
                if (dtTel.Rows.Count > 0)
                {
                    List<PESSOA_TELEFONE> listTel = new List<PESSOA_TELEFONE>();
                    PESSOA_TELEFONE objpestel = new PESSOA_TELEFONE();

                    for (int i = 0; i < dtTel.Rows.Count; i++)
                    {
                        objpestel.Pes_cod = int.Parse(dtTel.Rows[i]["pes_cod"].ToString());
                        objpestel.Tiptel_cod = int.Parse(dtTel.Rows[i]["tiptel_cod"].ToString());
                        objpestel.Tel_ddd = dtTel.Rows[i]["tel_ddd"].ToString();
                        objpestel.Tel_numero = dtTel.Rows[i]["tel_numero"].ToString();
                        listTel.Add(objpestel);
                    }
                }


                //CARREGAR LISTA DE REDES SOCIAIS
                PESSOA_REDES_SOCIAIS_BUSINESS ObjPesRedBus = new PESSOA_REDES_SOCIAIS_BUSINESS();
                DataTable dtRed = ObjPesRedBus.BuscarPorPessoaCod(objPessoa);

                if (dtRed.Rows.Count > 0)
                {
                    List<PESSOA_REDES_SOCIAIS> listRed = new List<PESSOA_REDES_SOCIAIS>();
                    PESSOA_REDES_SOCIAIS objred = new PESSOA_REDES_SOCIAIS();

                    for (int x = 0; x < dtRed.Rows.Count; x++)
                    {
                        objred.pes_cod = int.Parse(dtRed.Rows[x]["pes_cod"].ToString());
                        objred.red_cod = int.Parse(dtRed.Rows[x]["red_cod"].ToString());
                        objred.pesred_usuario = dtRed.Rows[x]["pesred_usuario"].ToString();

                        listRed.Add(objred);
                    }
                }



            }
            return objPessoa;
        }
    }
}
