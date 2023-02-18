using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Npgsql;

namespace DATA
{
    class EVENTO_FOTO_REPOSITORIO
    {
        // ===================== CAMPOS =====================
        // INT EVEFOT_ID | INT EVE_ID | INT TIPFOT_ID
        // STRING EVEFOT_URL
        // ===================== CAMPOS =====================


        // ============== CONSTRUTOR ============== 
        public EVENTO_FOTO_REPOSITORIO()
        {

        }

        // ================= MÉTODOS =================
        #region "ADICIONAR"
        public int Add(int eveId, int tipFotId, string evefotURL)
        {
            try
            {
                CONEXAO con = new CONEXAO();
                NpgsqlCommand cmd = new NpgsqlCommand(
                  "INSERT INTO evento_foto(eve_id, tipfot_id, evefot_url) " +
                   "VALUES (@eveId, @tipfotId, '@evefoturl')");

                cmd.Parameters.AddWithValue("@eveId", eveId);
                cmd.Parameters.AddWithValue("@tipfotId", tipFotId);
                cmd.Parameters.AddWithValue("@evefoturl", evefotURL);

                return con.ExecutacmdAI(cmd, "evento_foto");
            }

            catch (Exception)
            {
                throw new Exception("Erro ao inserir. \n\r");
            }
        }
        #endregion

        #region "ALTERAR"
        public bool Update(int evefotId, int eveId, int tipfotId, string evefotURL)
        {
            int ok = 0;
            try
            {
                CONEXAO con = new CONEXAO();
                NpgsqlCommand cmd = new NpgsqlCommand(
                  "UPDATE evento_foto " +
                  "SET eve_id=@eveId, tipfot_id=@tipfotId, evefot_url='@url' " +
                  "WHERE evefot_id=@id");

                cmd.Parameters.AddWithValue("@eveId", eveId);
                cmd.Parameters.AddWithValue("@tipfotId", tipfotId);
                cmd.Parameters.AddWithValue("@url", evefotURL);
                cmd.Parameters.AddWithValue("@id", evefotId);

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
        public bool Delete(int evefotId)
        {
            int ok = 0;
            try
            {
                CONEXAO con = new CONEXAO();
                NpgsqlCommand cmd = new NpgsqlCommand(
                  "DELETE FROM evento_foto " +
                  "WHERE evefot_id=@id");


                cmd.Parameters.AddWithValue("@id", evefotId);

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

        #region "BUSCAR POR EVENTO"
        public DataTable BuscaPorTipo(int eveId)
        {
            try
            {
                CONEXAO con = new CONEXAO();
                NpgsqlCommand cmd = new NpgsqlCommand(
                  "SELECT * " +
                  "FROM evento_foto " +
                  "WHERE eve_id=@eve " + 
                  "ORDER BY tipfot_id ASC");

                cmd.Parameters.AddWithValue("@eve", eveId);

                return con.ExecutaConsulta(cmd);
            }
            catch (Exception)
            {
                throw new Exception("Erro na busca por evento. \n\r");
            }
        }
        #endregion

        #region "BUSCAR POR ID"
        public DataTable BuscaId(int evefotId)
        {
            try
            {
                CONEXAO con = new CONEXAO();
                NpgsqlCommand cmd = new NpgsqlCommand(
                  "SELECT * " +
                  "FROM evento_foto " +
                  "WHERE evefot_id=@id");

                cmd.Parameters.AddWithValue("@id", evefotId);

                return con.ExecutaConsulta(cmd);

            }
            catch (Exception)
            {
                throw new Exception("Erro ao consultar por coódigo. \n\r");
            }
        }
        #endregion

        #region "BUSCAR POR TIPO DE FOTO"
        public DataTable BuscaPorTipoFoto(int tipfotId)
        {
            try
            {
                CONEXAO con = new CONEXAO();
                NpgsqlCommand cmd = new NpgsqlCommand(
                  "SELECT * " +
                  "FROM evento_foto " +
                  "WHERE tipfot_id=@tipfotid");
                cmd.Parameters.AddWithValue("tipfotid", tipfotId);

                return con.ExecutaConsulta(cmd);
            }
            catch (Exception)
            {
                throw new Exception("Erro ao consultar todos por tipo de foto. \n\r");
            }
        }
        #endregion
    }
}
