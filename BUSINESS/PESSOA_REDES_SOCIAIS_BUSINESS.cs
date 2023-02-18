using DATA;
using MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUSINESS
{
    public class PESSOA_REDES_SOCIAIS_BUSINESS
    {

        // ===================== CAMPOS =====================
        // INT PES_COD | INT RED_COD | STRING PESRED_USUARIO
        // ===================== CAMPOS =====================

        // ============== CONSTRUTOR ============== 
        public PESSOA_REDES_SOCIAIS_BUSINESS()
        {

        }

        // ================= MÉTODOS =================
        #region "ADICIONAR"
        public Boolean Add(PESSOA_REDES_SOCIAIS Obj)
        {
            try
            {
                int pes_cod = Obj.pes_cod;
                int red_cod = Obj.red_cod;
                string pesred_usuario = Obj.pesred_usuario;


                PESSOA_REDES_SOCIAIS_REPOSITORIO ObjRep = new PESSOA_REDES_SOCIAIS_REPOSITORIO();

                return ObjRep.Add(pes_cod,red_cod,pesred_usuario);
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
                
            PESSOA_REDES_SOCIAIS_REPOSITORIO ObjRep = new PESSOA_REDES_SOCIAIS_REPOSITORIO();
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

     

        #region "BUSCAR POR PESSOA COD"
        public DataTable BuscarPorPessoaCod(PESSOA Obj)
        {
            int pes_cod = Obj.Sta_cod;

            PESSOA_REDES_SOCIAIS_REPOSITORIO ObjRep = new PESSOA_REDES_SOCIAIS_REPOSITORIO();
            try
            {
                return ObjRep.BuscaPessoa(pes_cod);
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion
    }
}
