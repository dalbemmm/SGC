using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA
{
    public class REDES_SOCIAIS_REPOSITORIO
    {

        // ===================== CAMPOS =====================
        // INT RED_COD | STRING RED_DESCRICAO
        // ===================== CAMPOS =====================

        // ============== CONSTRUTOR ============== 
        public REDES_SOCIAIS_REPOSITORIO()
        {

        }

        // ================= MÉTODOS =================
        #region "ADICIONAR"
        public Boolean Add(string reddesc)
        {
            int ok = 0;
            try
            {
                CONEXAO con = new CONEXAO();
                NpgsqlCommand cmd = new NpgsqlCommand(
                  "INSERT INTO redes_sociais(red_descricao) " +
                   "VALUES (@desc)");

                cmd.Parameters.AddWithValue("@desc", reddesc);

                ok = con.ExecutacmdAI(cmd, "redes_sociais");

                if (ok == 0) { return false; }
                else return true;
            }
            catch (Exception)
            {
                throw new Exception("Erro ao inserir. \n\r");
            }
        }
        #endregion

        #region "ALTERAR"
        public Boolean Update(int redcod, string reddesc)
        {
            int ok = 0;
            try
            {
                CONEXAO con = new CONEXAO();
                NpgsqlCommand cmd = new NpgsqlCommand(
                  "UPDATE redes_sociais " +
                  "SET red_descricao='@desc' " +
                  "WHERE red_cod=@id");

                cmd.Parameters.AddWithValue("@desc", reddesc);
                cmd.Parameters.AddWithValue("@id", redcod);

                ok = con.ExecutaCmd(cmd);

                if (ok == 0) { return false; }
                else return true;
            }
            catch (Exception)
            {
                throw new Exception("Erro ao atualizar. \n\r");
            }
        }
        #endregion

        #region "DELETAR"
        public Boolean Delete(int redcod)
        {
            int ok = 0;
            try
            {
                CONEXAO con = new CONEXAO();
                NpgsqlCommand cmd = new NpgsqlCommand(
                  "DELETE FROM redes_sociais " +
                  "WHERE red_cod=@id");

                cmd.Parameters.AddWithValue("@id", redcod);

                ok = con.ExecutaCmd(cmd);

                if (ok == 0) { return false; }
                else return true;
            }
            catch (Exception)
            {
                throw new Exception("Erro ao excluir. \n\r");
            }
        }
        #endregion

        #region "BUSCAR POR DESCRIÇÃO"
        public DataTable BuscaDes(string redDesc)
        {
            try
            {
                CONEXAO con = new CONEXAO();
                NpgsqlCommand cmd = new NpgsqlCommand(
                  "SELECT * " +
                  "FROM redes_sociais " +
                  "WHERE red_descricao like @desc");

                cmd.Parameters.AddWithValue("@desc", redDesc);

                return con.ExecutaConsulta(cmd);

            }
            catch (Exception)
            {
                throw new Exception("Erro ao excluir. \n\r");
            }
        }
        #endregion

        #region "BUSCAR POR ID"
        public DataTable BuscarCod(int redCod)
        {
            try
            {
                CONEXAO con = new CONEXAO();
                NpgsqlCommand cmd = new NpgsqlCommand(
                  "SELECT * " +
                  "FROM redes_sociais " +
                  "WHERE red_cod=@id");

                cmd.Parameters.AddWithValue("@id", redCod);

                return con.ExecutaConsulta(cmd);

            }
            catch (Exception)
            {
                throw new Exception("Erro ao Buscar pelo Código. \n\r");
            }
        }
        #endregion

        #region "BUSCAR TODOS"
        public DataTable BuscaTodos()
        {
            try
            {
                CONEXAO con = new CONEXAO();
                NpgsqlCommand cmd = new NpgsqlCommand(
                  "SELECT * " +
                  "FROM redes_sociais");

                return con.ExecutaConsulta(cmd);
            }
            catch (Exception)
            {
                throw new Exception("Erro ao Buscar todos. \n\r");
            }
        }
        #endregion

        #region "BUSCAR TODOS POR DESCRICAO"
        public DataTable BuscarTodosDesc(string redDesc)
        {
            try
            {
                CONEXAO con = new CONEXAO();
                NpgsqlCommand cmd = new NpgsqlCommand(
                  "SELECT * " +
                  "FROM redes_sociais " +
                  "WHERE red_descricao like '%@desc%'");

                cmd.Parameters.AddWithValue("@desc", redDesc);

                return con.ExecutaConsulta(cmd);
            }
            catch (Exception)
            {
                throw new Exception("Erro ao Buscar Todos pela descrição. \n\r");
            }
        }
        #endregion
    }
}
