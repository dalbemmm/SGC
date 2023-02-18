using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Npgsql;


namespace DATA
{
    class CATEGORIA_CONVIDADO_REPOSITORIO
    {
        // ===================== CAMPOS =====================
        // INT CATCON_ID | STRING CATCON_DESCRICAO | INT STA_ID
        // ===================== CAMPOS =====================

        // ============== CONSTRUTOR ============== 
        public CATEGORIA_CONVIDADO_REPOSITORIO()
        {

        }

        // ================= MÉTODOS =================
        #region "ADICIONAR"
        public int Add(string catcondesc, int staid)
        {
            try
            {
                CONEXAO con = new CONEXAO();
                NpgsqlCommand cmd = new NpgsqlCommand(
                  "INSERT INTO categoria_convidado(catcon_descricao, sta_id) " +
                   "VALUES ('@desc', @sta)");

                cmd.Parameters.AddWithValue("@desc", catcondesc);
                cmd.Parameters.AddWithValue("@sta", staid);
                
                return con.ExecutacmdAI(cmd, "categoria_convidado");
            }
            catch (Exception)
            {
                throw new Exception("Erro ao inserir. \n\r");
            }
        }
        #endregion

        #region "ALTERAR"
        public bool Update(int catconid, string catcondesc, int staid)
        {
            int ok = 0;
            try
            {
                CONEXAO con = new CONEXAO();
                NpgsqlCommand cmd = new NpgsqlCommand(
                  "UPDATE categoria_convidado " +
                  "SET catcon_descricao='@desc', sta_id=@staid " +
                  "WHERE catcon_id=@id");

                cmd.Parameters.AddWithValue("@desc", catcondesc);
                cmd.Parameters.AddWithValue("@staid", staid);
                cmd.Parameters.AddWithValue("@id", catconid);

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
        public bool Delete(int catconid)
        {
            int ok = 0;
            try
            {
                CONEXAO con = new CONEXAO();
                NpgsqlCommand cmd = new NpgsqlCommand(
                  "DELETE FROM categoria_convidado " +
                  "WHERE catcon_id=@id");


                cmd.Parameters.AddWithValue("@id", catconid);

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

        #region "BUSCAR POR CATEGORIA"
        public DataTable BuscaCat(string cat)
        {
            try
            {
                CONEXAO con = new CONEXAO();
                NpgsqlCommand cmd = new NpgsqlCommand(
                  "SELECT * " +
                  "FROM categoria_convidado " +
                  "WHERE catcon_descricao like %@cat% " +
                  "ORDER BY catcon_descricao ASC");

                cmd.Parameters.AddWithValue("@cat", cat);

                return con.ExecutaConsulta(cmd);

            }
            catch (Exception)
            {
                throw new Exception("Erro na busca. \n\r");
            }
        }
        #endregion

        #region "BUSCAR POR ID"
        public DataTable BuscaId(int catconid)
        {
            try
            {
                CONEXAO con = new CONEXAO();
                NpgsqlCommand cmd = new NpgsqlCommand(
                  "SELECT * " +
                  "FROM categoria_convidado " +
                  "WHERE catcon_id=@id");

                cmd.Parameters.AddWithValue("@id", catconid);

                return con.ExecutaConsulta(cmd);

            }
            catch (Exception)
            {
                throw new Exception("Erro ao consultar. \n\r");
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
                  "FROM categoria_convidado " +
                  "ORDER BY catcon_descricao ASC");

                return con.ExecutaConsulta(cmd);
            }
            catch (Exception)
            {
                throw new Exception("Erro ao consultar todos. \n\r");
            }
        }
        #endregion

        #region "BUSCAR POR CATEGORIA"
        public DataTable BuscaTodosCategoria(string catcondesc)
        {
            try
            {
                CONEXAO con = new CONEXAO();
                NpgsqlCommand cmd = new NpgsqlCommand(
                  "SELECT * " +
                  "FROM categoria_convidado " +
                  "WHERE catcon_descricao like '%@desc%' " +
                  "ORDER BY catcon_descricao ASC");

                cmd.Parameters.AddWithValue("@desc", catcondesc);

                return con.ExecutaConsulta(cmd);
            }
            catch (Exception)
            {
                throw new Exception("Erro ao consultar. \n\r");
            }
        }
        #endregion

        #region "BUSCAR POR STATUS"
        public DataTable BuscaPorStatus(string staId)
        {
            try
            {
                CONEXAO con = new CONEXAO();
                NpgsqlCommand cmd = new NpgsqlCommand(
                  "SELECT * " +
                  "FROM categoria_convidado " +
                  "WHERE sta_id=@id " +
                  "ORDER BY catcon_descricao ASC");

                cmd.Parameters.AddWithValue("@id", staId);

                return con.ExecutaConsulta(cmd);
            }
            catch (Exception)
            {
                throw new Exception("Erro ao consultar. \n\r");
            }
        }
        #endregion
    }
}
