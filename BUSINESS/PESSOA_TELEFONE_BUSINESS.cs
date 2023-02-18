using DATA;
using MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BUSINESS
{
    public class PESSOA_TELEFONE_BUSINESS
    {
        // ===================== CAMPOS =====================
        // INT TEL_ID | STRING TEL_DDD | STRING TEL_TELEFONE
        // INT TIPTEL_ID | INT PES_ID | INT LOC_ID
        // INT FOR_ID
        // ===================== CAMPOS =====================

        public PESSOA_TELEFONE_BUSINESS()
        {

        }

        // ================= MÉTODOS =================
        #region "ADICIONAR"
        public Boolean Add(PESSOA_TELEFONE Obj)
        {
            try
            {
                PESSOA_TELEFONE_REPOSITORIO ObjRep = new PESSOA_TELEFONE_REPOSITORIO();

                return ObjRep.Add(Obj);
            }
            catch (Exception e)
            {

                throw e;
            }
        }
        #endregion

        #region "ALTERAR"
        public Boolean Update(List<PESSOA_TELEFONE> lista, int pes_cod)
        {

            PESSOA_TELEFONE_REPOSITORIO ObjRep = new PESSOA_TELEFONE_REPOSITORIO();
            try
            {
                if (ObjRep.Delete(pes_cod))
                {
                    for(int i=0; i<lista.Count; i++)
                    {
                        if (!ObjRep.Add(lista[i]))
                            return false;
                    }
                    return true;
                }
                else return false;
            }
            catch (Exception e)
            {

                throw e;
            }
        }
        #endregion

        #region "DELETAR"
        public Boolean Delete(int pes_cod)
        {
            PESSOA_TELEFONE_REPOSITORIO ObjRep = new PESSOA_TELEFONE_REPOSITORIO();
            try
            {
                return ObjRep.Delete(pes_cod);
            }
            catch (Exception e)
            {

                throw e;
            }
        }
        #endregion

        #region "BUSCAR POR PESSOA"
        public DataTable BuscarTelefonesPessoa(int pes_cod)
        {
          
            PESSOA_TELEFONE_REPOSITORIO ObjRep = new PESSOA_TELEFONE_REPOSITORIO();
            try
            {
                return ObjRep.BuscaTelefonesPessoa(pes_cod);
            }
            catch (Exception)
            {

                throw;
            }
        }

        #endregion

    }
}
