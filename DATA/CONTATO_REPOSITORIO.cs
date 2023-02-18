using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Npgsql;

namespace DATA
{
    class CONTATO_REPOSITORIO
    {
        // ===================== CAMPOS =====================
        // INT FOR_ID | INT CON_ID | INT STA_ID
        // INT LOC_ID 
        // ===================== CAMPOS =====================


        // ============== CONSTRUTOR ============== 
        public CONTATO_REPOSITORIO()
        {

        }

        // ================= MÉTODOS =================
        #region "ADICIONAR"
        public int Add(int forn, int cont, int sta, int loc)
        {
            try
            {
                CONEXAO con = new CONEXAO();
                NpgsqlCommand cmd = new NpgsqlCommand(
                  "INSERT INTO contato(for_id, con_id, sta_id, loc_id) " +
                   "VALUES (@forn, @con, @sta, @loc)");

                cmd.Parameters.AddWithValue("@forn", forn);
                cmd.Parameters.AddWithValue("@con", cont);
                cmd.Parameters.AddWithValue("@sta", sta);
                cmd.Parameters.AddWithValue("@loc", loc);

               return con.ExecutacmdAI(cmd, "contato");
            }
            catch (Exception)
            {
                throw new Exception("Erro ao inserir. \n\r");
            }
        }
        #endregion

        #region "ALTERAR"
        public bool Update(int forid, int conid, int staid, int locid)
        {
            int ok = 0;
            try
            {
                CONEXAO con = new CONEXAO();
                NpgsqlCommand cmd = new NpgsqlCommand(
                  "UPDATE contato " +
                  "SET con_id=@conid, sta_id=@staid, loc_id=@locid " +
                  "WHERE for_id=@forid");

                cmd.Parameters.AddWithValue("@conid", conid);
                cmd.Parameters.AddWithValue("@staid", staid);
                cmd.Parameters.AddWithValue("@locid", locid);
                cmd.Parameters.AddWithValue("@forid", forid);           

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
                //CONEXAO con = new CONEXAO();
                //MySqlCommand cmd = new MySqlCommand(
                //  "DELETE FROM categoria_convidado " +
                //  "WHERE catcon_id=@id");


                //cmd.Parameters.AddWithValue("@id", catconid);

                //ok = con.ExecutaCmd(cmd);

                if (ok == 0) { return false; }
                else return true;
            }
            catch (Exception)
            {
                throw new Exception("Erro ao excluir. \n\r");
            }
        }
        #endregion

        #region "BUSCAR POR FORNECEDOR"
        public DataTable BuscaFornecedor(string forid)
        {
            try
            {
                CONEXAO con = new CONEXAO();
                NpgsqlCommand cmd = new NpgsqlCommand(
                  "SELECT * " +
                  "FROM contato " +
                  "WHERE for_id = @forid " +
                  "ORDER BY for_id ASC");

                cmd.Parameters.AddWithValue("@forid", forid);

                return con.ExecutaConsulta(cmd);

            }
            catch (Exception)
            {
                throw new Exception("Erro na busca. \n\r");
            }
        }
        #endregion

        #region "BUSCAR POR CONTATOS"
        public DataTable BuscaContato(int conid)
        {
            try
            {
                CONEXAO con = new CONEXAO();
                NpgsqlCommand cmd = new NpgsqlCommand(
                  "SELECT * " +
                  "FROM contato " +
                  "WHERE con_id=@id");

                cmd.Parameters.AddWithValue("@id", conid);

                return con.ExecutaConsulta(cmd);

            }
            catch (Exception)
            {
                throw new Exception("Erro ao consultar. \n\r");
            }
        }
        #endregion

        #region "BUSCAR POR LOCAL"
        public DataTable BuscaLocal(int locid)
        {
            try
            {
                CONEXAO con = new CONEXAO();
                NpgsqlCommand cmd = new NpgsqlCommand(
                  "SELECT * " +
                  "FROM contato " +
                  "WHERE loc_id=@locid ");

                cmd.Parameters.AddWithValue("@locid", locid);
                return con.ExecutaConsulta(cmd);
            }
            catch (Exception)
            {
                throw new Exception("Erro ao consultar por Local. \n\r");
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
                  "FROM contato " +
                  "WHERE sta_id=@id");

                cmd.Parameters.AddWithValue("@id", staId);

                return con.ExecutaConsulta(cmd);
            }
            catch (Exception)
            {
                throw new Exception("Erro ao consultar por Status. \n\r");
            }
        }
        #endregion


    }
}
