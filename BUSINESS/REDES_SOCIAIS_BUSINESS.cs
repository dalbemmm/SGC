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
    public class REDES_SOCIAIS_BUSINESS
    {
        // ===================== CAMPOS =====================
        // INT RED_COD | STRING RED_DESCRICAO
        // ===================== CAMPOS =====================

        // ============== CONSTRUTOR ============== 
        public REDES_SOCIAIS_BUSINESS()
        {

        }

        // ================= MÉTODOS =================
        #region "ADICIONAR"
        public Boolean Add(REDES_SOCIAIS Obj)
        {
            try
            {
                string desc = Obj.red_descricao;

                REDES_SOCIAIS_REPOSITORIO ObjRep = new REDES_SOCIAIS_REPOSITORIO();

                return ObjRep.Add(desc);
            }
            catch (Exception e)
            {

                throw e;
            }
        }
        #endregion

        #region "ALTERAR"
        public Boolean Update(REDES_SOCIAIS Obj)
        {
            int cod = int.Parse(Obj.red_cod.ToString());
            string desc = Obj.red_descricao;

            REDES_SOCIAIS_REPOSITORIO ObjRep = new REDES_SOCIAIS_REPOSITORIO();
            try
            {
                return ObjRep.Update(cod, desc);
            }
            catch (Exception e)
            {

                throw e;
            }
        }
        #endregion

        #region "DELETAR"
        public Boolean Delete(REDES_SOCIAIS Obj)
        {
            int cod = int.Parse(Obj.red_cod.ToString());
            string desc = Obj.red_descricao;

            REDES_SOCIAIS_REPOSITORIO ObjRep = new REDES_SOCIAIS_REPOSITORIO();
            try
            {
                return ObjRep.Delete(cod);
            }
            catch (Exception e)
            {

                throw e;
            }
        }
        #endregion

        #region "BUSCAR POR DESCRIÇÃO"
        public DataTable BuscarPorDescricao(REDES_SOCIAIS Obj)
        {
            string redDesc = Obj.red_descricao;

            REDES_SOCIAIS_REPOSITORIO ObjRep = new REDES_SOCIAIS_REPOSITORIO();
            try
            {
                return ObjRep.BuscaDes(redDesc);
            }
            catch (Exception)
            {

                throw;
            }
        }

        #endregion

        #region "BUSCAR POR ID"
        public DataTable BuscarPorCod(REDES_SOCIAIS Obj)
        {
            int redCod = int.Parse(Obj.red_cod.ToString());

             REDES_SOCIAIS_REPOSITORIO ObjRep = new REDES_SOCIAIS_REPOSITORIO();
            try
            {
                return ObjRep.BuscarCod(redCod);
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

            REDES_SOCIAIS_REPOSITORIO ObjRep = new REDES_SOCIAIS_REPOSITORIO();
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
