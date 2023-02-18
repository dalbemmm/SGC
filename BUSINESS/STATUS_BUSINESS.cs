using DATA;
using MODEL;
using System.Data;
using System.Diagnostics.Metrics;

namespace BUSINESS
{
    public class STATUS_BUSINESS
    {
        // ===================== CAMPOS =====================
        // INT STA_COD | STRING STA_DESCRICAO
        // ===================== CAMPOS =====================

        // ============== CONSTRUTOR ============== 
        public STATUS_BUSINESS()
        {
            
        }

        // ================= MÉTODOS =================
        #region "ADICIONAR"
        public Boolean Add (STATUS Obj)
        {
            try
            {
                string desc = Obj.Sta_descricao;

                STATUS_REPOSITORIO ObjRep= new STATUS_REPOSITORIO();
             
                return ObjRep.Add(desc);
            }
            catch (Exception e)
            {

                throw e;
            }
        }
        #endregion

        #region "ALTERAR"
        public Boolean Update (STATUS Obj)
        {
            int cod = int.Parse(Obj.Sta_cod.ToString());
            string desc = Obj.Sta_descricao;

            STATUS_REPOSITORIO ObjRep = new STATUS_REPOSITORIO();
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
        public Boolean Delete(STATUS Obj)
        {
            int cod = int.Parse(Obj.Sta_cod.ToString());
            string desc = Obj.Sta_descricao;

            STATUS_REPOSITORIO ObjRep = new STATUS_REPOSITORIO();
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
        public DataTable BuscarPorDescricao(STATUS Obj)
        {
            string StaDesc = Obj.Sta_descricao;

            STATUS_REPOSITORIO ObjRep = new STATUS_REPOSITORIO();
            try
            {
                return ObjRep.BuscaDes(StaDesc);
            }
            catch (Exception)
            {

                throw;
            }
        }

        #endregion

        #region "BUSCAR POR ID"
        public DataTable BuscarPorCod(STATUS Obj)
        {
            int StaCod= int.Parse(Obj.Sta_cod.ToString());

            STATUS_REPOSITORIO ObjRep = new STATUS_REPOSITORIO();
            try
            {
                return ObjRep.BuscarCod(StaCod);
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

            STATUS_REPOSITORIO ObjRep = new STATUS_REPOSITORIO();
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
