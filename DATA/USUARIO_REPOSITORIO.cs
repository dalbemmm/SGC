using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Npgsql;

namespace DATA
{
    class USUARIO_REPOSITORIO
    {
        // ===================== CAMPOS =====================
        // INT USU_ID | STRING USU_LOGIN | STRING USU_SENHA
        // INT TIPUSU_ID | INT STA_ID | INT PES_ID
        // ===================== CAMPOS =====================

        // ============== CONSTRUTOR ============== 
        public USUARIO_REPOSITORIO()
        {

        }

        // ================= MÉTODOS =================
        #region "ADICIONAR"
        public bool Add(string usulogin, string ususenha, int tipusuid, int staid, int pesid)
        {
            int ok = 0;
            try
            {
                CONEXAO con = new CONEXAO();
                NpgsqlCommand cmd = new NpgsqlCommand(
                  "INSERT INTO usuario(usu_login, usu_senha, tipusu_id, sta_id, pes_id) " +
                   "VALUES (@login, @senha, @tipusu, @sta, @pes)");

                cmd.Parameters.AddWithValue("@login", usulogin);
                cmd.Parameters.AddWithValue("@senha", ususenha);
                cmd.Parameters.AddWithValue("@tipusu", tipusuid);
                cmd.Parameters.AddWithValue("@sta", staid);
                cmd.Parameters.AddWithValue("@lpes", pesid);

                ok = con.ExecutacmdAI(cmd, "usuario");

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
        public bool Update(int usuid, string usulogin, string ususenha, int tipusuid, int staid, int pesid)
        {
            int ok = 0;
            try
            {
                CONEXAO con = new CONEXAO();
                NpgsqlCommand cmd = new NpgsqlCommand(
                  "UPDATE usuario " +
                  "SET usu_login='@login', usu_senha='@senha', tipusu_id=@tipusu, sta_id=@staid, pes_id=@pes " +
                  "WHERE usu_id=@id");

                cmd.Parameters.AddWithValue("@login", usulogin);
                cmd.Parameters.AddWithValue("@senha", ususenha);
                cmd.Parameters.AddWithValue("@tipusu", tipusuid);
                cmd.Parameters.AddWithValue("@sta", staid);
                cmd.Parameters.AddWithValue("@lpes", pesid);
                cmd.Parameters.AddWithValue("@id", usuid);

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
        public bool Delete(int usuid)
        {
            int ok = 0;
            try
            {
                CONEXAO con = new CONEXAO();
                NpgsqlCommand cmd = new NpgsqlCommand(
                  "DELETE FROM usuario " +
                  "WHERE usu_id=@id");

                
                cmd.Parameters.AddWithValue("@id", usuid);

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

        #region "BUSCAR POR USUÁRIO"
        public DataTable BuscaUsu(string usuario)
        {
            try
            {
                CONEXAO con = new CONEXAO();
                NpgsqlCommand cmd = new NpgsqlCommand(
                  "SELECT * " +
                  "FROM usuario " +
                  "WHERE usu_login like %@usu%");

                cmd.Parameters.AddWithValue("@usu", usuario);

                return con.ExecutaConsulta(cmd);

            }
            catch (Exception)
            {
                throw new Exception("Erro na busca. \n\r");
            }
        }
        #endregion

        #region "BUSCAR POR ID"
        public DataTable BuscaId(int usuId)
        {
            try
            {
                CONEXAO con = new CONEXAO();
                NpgsqlCommand cmd = new NpgsqlCommand(
                  "SELECT * " +
                  "FROM usuario " +
                  "WHERE usu_id=@id");

                cmd.Parameters.AddWithValue("@id", usuId);

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
                  "FROM usuario");

                return con.ExecutaConsulta(cmd);
            }
            catch (Exception)
            {
                throw new Exception("Erro ao consultar todos. \n\r");
            }
        }
        #endregion

        #region "BUSCAR POR LOGIN"
        public DataTable BuscaTodosLogin(string usuLogin)
        {
            try
            {
                CONEXAO con = new CONEXAO();
                NpgsqlCommand cmd = new NpgsqlCommand(
                  "SELECT * " +
                  "FROM usuario " +
                  "WHERE usu_login like '%@usu%'");

                cmd.Parameters.AddWithValue("@usu", usuLogin);

                return con.ExecutaConsulta(cmd);
            }
            catch (Exception)
            {
                throw new Exception("Erro ao consultar. \n\r");
            }
        }
        #endregion

        #region "BUSCAR POR PESSOA"
        public DataTable BuscaPorPessoa(int pesid)
        {
            try
            {
                CONEXAO con = new CONEXAO();
                NpgsqlCommand cmd = new NpgsqlCommand(
                  "SELECT * " +
                  "FROM usuario " +
                  "WHERE pes_id=@id");

                cmd.Parameters.AddWithValue("@id", pesid);

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
                  "FROM usuario " +
                  "WHERE sta_id=@id");

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
