using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;


namespace DATA
{
    class CONVIDADO_REPOSITORIO
    {
        // ===================== CAMPOS =====================
        // INT CON_ID | STRING CON_NOME | INT LIS_COD
        // STRING CON_DDD | STRING CON_TELEFONE | STRING CON_SEXO
        // STRING CON_EMAIL | CHAR CON_CONFIRMADO | CHAR CON_PRINCIPAL
        // INT CON_ANEXO | INT CATCON_ID
        // ===================== CAMPOS =====================

        // ============== CONSTRUTOR ============== 
        public CONVIDADO_REPOSITORIO()
        {

        }

        // ================= MÉTODOS =================
        #region "ADICIONAR"
        public int Add(string connome, int lisid, string conddd, string contelefone, string consexo, string conemail, char conconfirmado, char conprincipal, int conanexo, int catconid)
        {
            try
            {
                CONEXAO con = new CONEXAO();
                NpgsqlCommand cmd = new NpgsqlCommand(
                  "INSERT INTO convidado(con_nome, lis_id, con_ddd, con_telefone, con_sexo, con_email, con_confirmado, con_principal, con_anexo, catcon_id) " +
                   "VALUES ('@nome', @lis, '@ddd', '@tel', '@sexo', '@email', '@conf', '@principal', '@anexo', @catconid)");

                cmd.Parameters.AddWithValue("@nome", connome);
                cmd.Parameters.AddWithValue("@lis", lisid);
                cmd.Parameters.AddWithValue("@ddd", conddd);
                cmd.Parameters.AddWithValue("@tel", contelefone);
                cmd.Parameters.AddWithValue("@sexo", consexo);
                cmd.Parameters.AddWithValue("@email", conemail);
                cmd.Parameters.AddWithValue("@conf", conconfirmado);
                cmd.Parameters.AddWithValue("@principal", conprincipal);
                cmd.Parameters.AddWithValue("@anexo", conanexo);
                cmd.Parameters.AddWithValue("@catconid", catconid);
                
                return con.ExecutacmdAI(cmd, "convidado");
            }
            catch (Exception)
            {
                throw new Exception("Erro ao inserir. \n\r");
            }
        }
        #endregion

        #region "ALTERAR"
        public bool Update(int conid, string connome, int lisid, string conddd, string contelefone, string consexo, string conemail, char conconfirmado, char conprincipal, int conanexo, int catconid)
        {
            int ok = 0;
            try
            {
                CONEXAO con = new CONEXAO();
                NpgsqlCommand cmd = new NpgsqlCommand(
                  "UPDATE convidado " +
                  "SET con_nome='@nome', lis_id=@lis, con_ddd='@ddd', con_telefone='@tel', con_sexo='@sexo', con_email='@email', con_confirmado='@conf', con_principal='@principal', con_anexo=@anexo, catcon_id=@catconid " +
                  "WHERE con_id=@id");

                cmd.Parameters.AddWithValue("@id", conid);
                cmd.Parameters.AddWithValue("@nome", connome);
                cmd.Parameters.AddWithValue("@lis", lisid);
                cmd.Parameters.AddWithValue("@ddd", conddd);
                cmd.Parameters.AddWithValue("@tel", contelefone);
                cmd.Parameters.AddWithValue("@sexo", consexo);
                cmd.Parameters.AddWithValue("@email", conemail);
                cmd.Parameters.AddWithValue("@conf", conconfirmado);
                cmd.Parameters.AddWithValue("@principal", conprincipal);
                cmd.Parameters.AddWithValue("@anexo", conanexo);
                cmd.Parameters.AddWithValue("@catconid", catconid);

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
                  "DELETE FROM convidado " +
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
                  "FROM convidado " +
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
                  "FROM convidado " +
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

        #region "BUSCAR TODOS DA LISTA"
        public DataTable BuscaTodosLista(int lisid)
        {
            try
            {
                CONEXAO con = new CONEXAO();
                NpgsqlCommand cmd = new NpgsqlCommand(
                  "SELECT * " +
                  "FROM contatos " +
                  "WHERE lis_cod=@lis " +
                  "ORDER BY con_nome ASC");

                cmd.Parameters.AddWithValue("@lis", lisid);

                return con.ExecutaConsulta(cmd);
            }
            catch (Exception)
            {
                throw new Exception("Erro ao consultar os convidados da lista. \n\r");
            }
        }
        #endregion

        #region "BUSCAR TODOS DA LISTA CONFIRMADOS"
        public DataTable BuscarConfirmadosLista(int lisid, char confir)
        {
            try
            {
                CONEXAO con = new CONEXAO();
                NpgsqlCommand cmd = new NpgsqlCommand(
                  "SELECT * " +
                  "FROM convidado " +
                  "WHERE lis_id=@lis AND con_confirmado like '@conf' " +
                  "ORDER BY con_nome ASC");

                cmd.Parameters.AddWithValue("@lis", lisid);
                cmd.Parameters.AddWithValue("@conf", confir);

                return con.ExecutaConsulta(cmd);
            }
            catch (Exception)
            {
                throw new Exception("Erro ao consultar os convidados da Lista com Confirmação. \n\r");
            }
        }
        #endregion

        #region "BUSCAR TODOS DA LISTA PRINCIPAIS"
        public DataTable BuscaListaPrincipais(int lisId, char principal)
        {
            try
            {
                CONEXAO con = new CONEXAO();
                NpgsqlCommand cmd = new NpgsqlCommand(
                  "SELECT * " +
                  "FROM convidado " +
                  "WHERE lis_id=@lis AND con_principal=@prin " +
                  "ORDER BY con_nome ASC");

                cmd.Parameters.AddWithValue("@lis", lisId);
                cmd.Parameters.AddWithValue("@prin", principal);

                return con.ExecutaConsulta(cmd);
            }
            catch (Exception)
            {
                throw new Exception("Erro ao consultar Lista com os principais. \n\r");
            }
        }
        #endregion

        #region "BUSCAR TODOS DA LISTA PRINCIPAIS E CONFIRMADOS"
        public DataTable BuscaListaPrincipaisConfirmados(int lisId, char principal, char conf)
        {
            try
            {
                CONEXAO con = new CONEXAO();
                NpgsqlCommand cmd = new NpgsqlCommand(
                  "SELECT * " +
                  "FROM convidado " +
                  "WHERE lis_id=@lis AND con_principal like '@prin' AND con_confirmado like '@conf' "+
                  "ORDER BY con_nome ASC");

                cmd.Parameters.AddWithValue("@lis", lisId);
                cmd.Parameters.AddWithValue("@prin", principal);
                cmd.Parameters.AddWithValue("@conf", conf);

                return con.ExecutaConsulta(cmd);
            }
            catch (Exception)
            {
                throw new Exception("Erro ao consultar lista com principais e confirmado. \n\r");
            }
        }
        #endregion

        #region "BUSCAR TODOS DA LISTA POR CATEGORIA"
        public DataTable BuscaListaCategoriaConvidado(int lisId, int catcon)
        {
            try
            {
                CONEXAO con = new CONEXAO();
                NpgsqlCommand cmd = new NpgsqlCommand(
                  "SELECT * " +
                  "FROM convidado " +
                  "WHERE lis_id=@lis AND catcon_id=@catcon "+
                  "ORDER BY con_nome ASC");

                cmd.Parameters.AddWithValue("@lis", lisId);
                cmd.Parameters.AddWithValue("@catcon", catcon);

                return con.ExecutaConsulta(cmd);
            }
            catch (Exception)
            {
                throw new Exception("Erro ao consultar lista por categoria de convidado. \n\r");
            }
        }
        #endregion

        #region "BUSCAR TODOS DA LISTA POR CATEGORIA E PRINCIPAIS"
        public DataTable BuscaListaCategoriaPrincipal(int lisId, int catcon, char prin)
        {
            try
            {
                CONEXAO con = new CONEXAO();
                NpgsqlCommand cmd = new NpgsqlCommand(
                  "SELECT * " +
                  "FROM convidado " +
                  "WHERE lis_id=@lis AND catcon_id=@catcon AND con_principal like '@prin' " +
                  "ORDER BY con_nome ASC");

                cmd.Parameters.AddWithValue("@lis", lisId);
                cmd.Parameters.AddWithValue("@catcon", catcon);
                cmd.Parameters.AddWithValue("@prin", prin);

                return con.ExecutaConsulta(cmd);
            }
            catch (Exception)
            {
                throw new Exception("Erro ao consultar. \n\r");
            }
        }
        #endregion

        #region "BUSCAR TODOS DA LISTA POR CATEGORIA E PRINCIPAIS E CONFIRMADOS"
        public DataTable BuscaListaCategoriaConfirmados(int lisId, int catconId, char prin, char conf)
        {
            try
            {
                CONEXAO con = new CONEXAO();
                NpgsqlCommand cmd = new NpgsqlCommand(
                  "SELECT * " +
                  "FROM convidado " +
                  "WHERE lis_id=@lis AND catcon_id=@catcon AND con_principal like '@prin' AND con_confirmado like '@conf' "+
                  "ORDER BY con_nome ASC");

                cmd.Parameters.AddWithValue("@lis", lisId);
                cmd.Parameters.AddWithValue("@catcon", catconId);
                cmd.Parameters.AddWithValue("@prin", prin);
                cmd.Parameters.AddWithValue("@conf", conf);

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
