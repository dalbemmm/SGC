using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Npgsql;

namespace DATA
{
    class EVENTO_FORNECEDOR_REPOSITORIO
    {
        // ===================== CAMPOS =====================
        // INT EVEFOR_ID | INT EVE_ID | INT FOR_ID
        // DECIMAL EVEFOR_VALOR
        // ===================== CAMPOS =====================

        // ============== CONSTRUTOR ============== 
        public EVENTO_FORNECEDOR_REPOSITORIO()
        {

        }

        // ================= MÉTODOS =================
        #region "ADICIONAR"
        public int Add(int eveId, int forId, double eveforVal)
        {
            try
            {
                CONEXAO con = new CONEXAO();
                NpgsqlCommand cmd = new NpgsqlCommand(
                  "INSERT INTO evento_fornecedor(eve_id, for_id, evefor_valor) " +
                   "VALUES (@eveId, @forId, @eveforVal)");

                cmd.Parameters.AddWithValue("@eveId", eveId);
                cmd.Parameters.AddWithValue("@forId", forId);
                cmd.Parameters.AddWithValue("@eveforVal", eveforVal);
               
                return con.ExecutacmdAI(cmd, "evento_fornecedor");
            }

            catch (Exception)
            {
                throw new Exception("Erro ao inserir. \n\r");
            }
        }
        #endregion

        #region "ALTERAR"
        public bool Update(int eveforId, int eveId, int forId, double eveforVal)
        {
            int ok = 0;
            try
            {
                CONEXAO con = new CONEXAO();
                NpgsqlCommand cmd = new NpgsqlCommand(
                  "UPDATE evento_fornecedor " +
                  "SET eve_id=@eveId, for_id=@forId, evefor_valor=@eveforVal " +
                  "WHERE evefor_id=@id");

                cmd.Parameters.AddWithValue("@eveId", eveId);
                cmd.Parameters.AddWithValue("@forId", forId);
                cmd.Parameters.AddWithValue("@eveforVal", eveforVal);
                cmd.Parameters.AddWithValue("@id", eveforId);
                
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
        public bool Delete(int eveforId)
        {
            int ok = 0;
            try
            {
                CONEXAO con = new CONEXAO();
                NpgsqlCommand cmd = new NpgsqlCommand(
                  "DELETE FROM evento_fornecedor " +
                  "WHERE evefor_id=@id");


                cmd.Parameters.AddWithValue("@id", eveforId);

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
                  "FROM evento_fornecedor " +
                  "WHERE eve_id=@eve");

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
        public DataTable BuscaId(int eveForId)
        {
            try
            {
                CONEXAO con = new CONEXAO();
                NpgsqlCommand cmd = new NpgsqlCommand(
                  "SELECT * " +
                  "FROM evento_fornecedor " +
                  "WHERE evefor_id=@id");

                cmd.Parameters.AddWithValue("@id", eveForId);

                return con.ExecutaConsulta(cmd);

            }
            catch (Exception)
            {
                throw new Exception("Erro ao consultar por coódigo. \n\r");
            }
        }
        #endregion

        #region "BUSCAR POR FORNECEDOR"
        public DataTable BuscaPorFornecedor(int forId)
        {
            try
            {
                CONEXAO con = new CONEXAO();
                NpgsqlCommand cmd = new NpgsqlCommand(
                  "SELECT * " +
                  "FROM evento_fornecedor " +
                  "WHERE for_id=@for");
                cmd.Parameters.AddWithValue("for", forId);

                return con.ExecutaConsulta(cmd);
            }
            catch (Exception)
            {
                throw new Exception("Erro ao consultar todos por fornecedor. \n\r");
            }
        }
        #endregion
    }
}
