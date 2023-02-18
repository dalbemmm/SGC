using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Npgsql;

namespace DATA
{
    class CONTATOS_REPOSITORIO
    {
        // ===================== CAMPOS =====================
        // INT CON_ID | STRING CON_NOME | INT STA_ID
        // INT TEL_ID
        // ===================== CAMPOS =====================


        // ============== CONSTRUTOR ============== 
        public CONTATOS_REPOSITORIO()
        {

        }

        // ================= MÉTODOS =================
        #region "ADICIONAR"
        public int Add(string connome, int staid, int telid)
        {
            try
            {
                CONEXAO con = new CONEXAO();
                NpgsqlCommand cmd = new NpgsqlCommand(
                  "INSERT INTO contatos(con_nome, sta_id, tel_id) " +
                   "VALUES ('@nome', @sta, @tel)");

                cmd.Parameters.AddWithValue("@nome", connome);
                cmd.Parameters.AddWithValue("@sta", staid);
                cmd.Parameters.AddWithValue("@tel", telid);

                return con.ExecutacmdAI(cmd, "contatos");
            }

            catch (Exception)
            {
                throw new Exception("Erro ao inserir. \n\r");
            }
        }
        #endregion

        #region "ALTERAR"
        public bool Update(int conid, string connome, int staid, int telid)
        {
            int ok = 0;
            try
            {
                CONEXAO con = new CONEXAO();
                NpgsqlCommand cmd = new NpgsqlCommand(
                  "UPDATE contatos " +
                  "SET con_nome='@nome', sta_id=@staid, tel_id=@tel " +
                  "WHERE con_id=@id");

                cmd.Parameters.AddWithValue("@nome", connome);
                cmd.Parameters.AddWithValue("@staid", staid);
                cmd.Parameters.AddWithValue("@tel", telid);
                cmd.Parameters.AddWithValue("@id", conid);

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
        public bool Delete(int conid)
        {
            int ok = 0;
            try
            {
                CONEXAO con = new CONEXAO();
                NpgsqlCommand cmd = new NpgsqlCommand(
                  "DELETE FROM contatos " +
                  "WHERE con_id=@id");


                cmd.Parameters.AddWithValue("@id", conid);

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

        #region "BUSCAR POR NOME"
        public DataTable BuscaNome(string nom)
        {  
            try
            {
                CONEXAO con = new CONEXAO();
                NpgsqlCommand cmd = new NpgsqlCommand(
                  "SELECT * " +
                  "FROM contatos " +
                  "WHERE con_nome like %@non% " +
                  "ORDER BY con_nome ASC");

                cmd.Parameters.AddWithValue("@non", nom);

                return con.ExecutaConsulta(cmd);

            }
            catch (Exception)
            {
                throw new Exception("Erro na busca. \n\r");
            }
        }
        #endregion

        #region "BUSCAR POR ID"
        public DataTable BuscaId(int conid)
        {
            try
            {
                CONEXAO con = new CONEXAO();
                NpgsqlCommand cmd = new NpgsqlCommand(
                  "SELECT * " +
                  "FROM contatos " +
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

        #region "BUSCAR TODOS"
        public DataTable BuscaTodos()
        {
            try
            {
                CONEXAO con = new CONEXAO();
                NpgsqlCommand cmd = new NpgsqlCommand(
                  "SELECT * " +
                  "FROM contatos " +
                  "ORDER BY con_nome ASC");

                return con.ExecutaConsulta(cmd);
            }
            catch (Exception)
            {
                throw new Exception("Erro ao consultar todos. \n\r");
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
                  "FROM contatos " +
                  "WHERE sta_id=@id " +
                  "ORDER BY con_nome ASC");

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
