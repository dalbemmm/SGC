using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Npgsql;

namespace  DATA
{
    public class STATUS_REPOSITORIO
    {
        // ===================== CAMPOS =====================
        // INT STA_COD | STRING STA_DESCRICAO
        // ===================== CAMPOS =====================

        // ============== CONSTRUTOR ============== 
        public STATUS_REPOSITORIO()
        {
            
        }

        // ================= MÉTODOS =================
        #region "ADICIONAR"
        public Boolean Add(string stadesc)
        {
            int ok = 0;
            try
            {
                CONEXAO con = new CONEXAO();
                NpgsqlCommand cmd = new NpgsqlCommand(         
                  "INSERT INTO status(sta_descricao) " +
                   "VALUES (@desc)");

                cmd.Parameters.AddWithValue("@desc", stadesc);
                
                ok = con.ExecutacmdAI(cmd, "status");

                if (ok == 0){ return false; }
                else return true;
            }   
            catch (Exception)
            {
                throw new Exception("Erro ao inserir. \n\r");
            }
        }
        #endregion

        #region "ALTERAR"
        public Boolean Update(int staid, string stadesc)
        {
            int ok = 0;
            try
            {
                CONEXAO con = new CONEXAO();
                NpgsqlCommand cmd = new NpgsqlCommand(
                  "UPDATE status "+
                  "SET sta_descricao='@desc' " +
                  "WHERE sta_cod=@id");

                cmd.Parameters.AddWithValue("@desc", stadesc);
                cmd.Parameters.AddWithValue("@id", staid);

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
        public Boolean Delete(int stacod)
        {
            int ok = 0;
            try
            {
                CONEXAO con = new CONEXAO();
                NpgsqlCommand cmd = new NpgsqlCommand(
                  "DELETE FROM status " +
                  "WHERE sta_cod=@id");

                cmd.Parameters.AddWithValue("@id", stacod);

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
        public DataTable BuscaDes(string staDesc)
        {
            try
            {
                CONEXAO con = new CONEXAO();
                NpgsqlCommand cmd = new NpgsqlCommand(
                  "SELECT * " +
                  "FROM status " +
                  "WHERE sta_descricao like @desc");

                cmd.Parameters.AddWithValue("@desc", staDesc);

                return con.ExecutaConsulta(cmd);

            }
            catch (Exception)
            {
                throw new Exception("Erro ao excluir. \n\r");
            }
        }
        #endregion

        #region "BUSCAR POR ID"
        public DataTable BuscarCod(int staCod)
        {
            try
            {
                CONEXAO con = new CONEXAO();
                NpgsqlCommand cmd = new NpgsqlCommand(
                  "SELECT * " +
                  "FROM status " +
                  "WHERE sta_cod=@id");

                cmd.Parameters.AddWithValue("@id",  staCod);

                return con.ExecutaConsulta(cmd);

            }
            catch (Exception)
            {
                throw new Exception("Erro ao excluir. \n\r");
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
                  "FROM status");

                return con.ExecutaConsulta(cmd);
            }
            catch (Exception)
            {
                throw new Exception("Erro ao excluir. \n\r");
            }
        }
        #endregion

        #region "BUSCAR TODOS POR DESCRICAO"
        public DataTable BuscaTodosDesc(string stadesc)
        {
            try
            {
                CONEXAO con = new CONEXAO();
                NpgsqlCommand cmd = new NpgsqlCommand(
                  "SELECT * " +
                  "FROM status " +
                  "WHERE sta_descricao like '%@desc%'");

                cmd.Parameters.AddWithValue("@desc", stadesc);

                return con.ExecutaConsulta(cmd);
            }
            catch (Exception)
            {
                throw new Exception("Erro ao Buscar Todos. \n\r");
            }
        }
        #endregion



    }
}
