using DATA;
using MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.InteropServices;
using System.Text;

namespace BUSINESS
{
    public class PESSOA_BUSINESS
    {
        // ===================== CAMPOS =====================
        // INT PES_COD | STRING PES_NOME | STRING PES_RG
        // STRING PES_CPFCNPJ | CHAR PES_SEXO | INT STA_ID
        // DATETIME PES_DATANASCIMENTO | STRING PES_EMAIL
        // STRING PES_CEP | STRING PES_CIDADE | STRING PES_UF
        // STRING PES_CIDADE | STRING PES_LOGRADOURO 
        // STRING PES_NUMERO | STRING PES_BAIRRO | STRING PES_COMPLEMENTO
        // LIST<TELEFONE> LISTATEL | LIST<PESSOA_REDES_SOCIAIS> LISTAREDE
        // ===================== CAMPOS =====================

        // ==================== MÉTODOS ========================

        #region "ADICIONAR"
        public Boolean Add(PESSOA Obj)
        {
            try
            {
                List<PESSOA_TELEFONE> LISTATEL = new List<PESSOA_TELEFONE>();
                LISTATEL = Obj.ListaTelefones;

                List<PESSOA_REDES_SOCIAIS> LISTAREDE = new List<PESSOA_REDES_SOCIAIS>();
                LISTAREDE = Obj.ListaRedesSociais;

                PESSOA_RESPOSITORIO ObjRep = new PESSOA_RESPOSITORIO();

                int pes_cod = ObjRep.Add(Obj);

                for(int i=0;i<LISTATEL.Count;i++)
                {
                    PESSOA_TELEFONE_BUSINESS ObjPesTelBusiness = new PESSOA_TELEFONE_BUSINESS();
                    LISTATEL[i].Pes_cod = pes_cod;
                    if (!ObjPesTelBusiness.Add(LISTATEL[i]))
                        return false;
                    ObjPesTelBusiness = null;
                }

                for(int x=0; x<LISTAREDE.Count;x++) 
                {
                    PESSOA_REDES_SOCIAIS_BUSINESS ObjPesRedBusiness = new PESSOA_REDES_SOCIAIS_BUSINESS();
                    LISTAREDE[x].pes_cod = pes_cod;
                    if (!ObjPesRedBusiness.Add(LISTAREDE[x]))
                        return false;
                    ObjPesRedBusiness=null;
                }

                return true;
            }
            catch (Exception e)
            {

                throw e;
            }
        }
        #endregion

        #region "ALTERAR"
        public Boolean Update(PESSOA Obj)
        {
            PESSOA_RESPOSITORIO ObjRep = new PESSOA_RESPOSITORIO();
            try
            {
                List<PESSOA_TELEFONE> LISTATEL = new List<PESSOA_TELEFONE>();
                LISTATEL = Obj.ListaTelefones;

                List<PESSOA_REDES_SOCIAIS> LISTAREDE = new List<PESSOA_REDES_SOCIAIS>();
                LISTAREDE = Obj.ListaRedesSociais;


                if (ObjRep.Update(Obj))
                {
                    PESSOA_TELEFONE_BUSINESS ObjPesTelBusiness = new PESSOA_TELEFONE_BUSINESS();

                    if (ObjPesTelBusiness.Delete(Obj.Pes_cod))
                    {
                        for (int i = 0; i < LISTATEL.Count; i++)
                        {

                            if (!ObjPesTelBusiness.Add(LISTATEL[i]))
                                return false;
                        }
                    }

                    PESSOA_REDES_SOCIAIS_BUSINESS ObjPesRedBusiness = new PESSOA_REDES_SOCIAIS_BUSINESS();
                    if (ObjPesRedBusiness.Delete(Obj.Pes_cod))
                    {
                        for (int x = 0; x < LISTAREDE.Count; x++)
                        {
                            if (!ObjPesRedBusiness.Add(LISTAREDE[x]))
                                return false;
                            ObjPesRedBusiness = null;
                        }
                    }

                }
                return true;
            }
            catch (Exception e)
            {

                throw e;
            }
        }
        #endregion

        #region "DELETAR"
        public Boolean Delete(PESSOA Obj)
        {
            PESSOA_TELEFONE_BUSINESS ObjBusPesTel = new PESSOA_TELEFONE_BUSINESS();

            PESSOA_REDES_SOCIAIS_BUSINESS ObjBusPesRed = new PESSOA_REDES_SOCIAIS_BUSINESS();
           

            PESSOA_RESPOSITORIO ObjRep = new PESSOA_RESPOSITORIO();
            try
            {
                if(ObjBusPesTel.Delete(Obj.Pes_cod))
                {
                    if(ObjBusPesRed.Delete(Obj.Pes_cod))
                    {
                        if (ObjRep.Delete(Obj.Pes_cod))
                        {
                            return true;
                        }else return false;
                    }
                    else return false;
                }
                else return false;
            }
            catch (Exception e)
            {

                throw e;
            }
        }
        #endregion

        #region "BUSCAR POR DESCRIÇÃO"
        public DataTable BuscarPorNome(PESSOA Obj)
        {
            PESSOA_RESPOSITORIO ObjRep = new PESSOA_RESPOSITORIO();
            try
            {
                return ObjRep.BuscaNome(Obj.Pes_nome);
            }
            catch (Exception)
            {

                throw;
            }
        }

        #endregion

        #region "BUSCAR POR ID"
        public DataTable BuscarPorCod(PESSOA Obj)
        {
            PESSOA_RESPOSITORIO ObjRep = new PESSOA_RESPOSITORIO();
            try
            {
                return ObjRep.BuscaCod(Obj.Pes_cod);
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion

        #region "BUSCAR POR STATUS"
        public DataTable BuscarPorStatus(int sta_cod)
        {

            PESSOA_RESPOSITORIO ObjRep = new PESSOA_RESPOSITORIO();
            try
            {
                return ObjRep.BuscarTodosPorStatus(sta_cod);
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region "BUSCAR TODOS"
        public DataTable BuscarTodos()
        {

            PESSOA_RESPOSITORIO ObjRep = new PESSOA_RESPOSITORIO();
            try
            {
                return ObjRep.BuscaTodos();
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
    }
}
