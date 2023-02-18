using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Npgsql;

namespace DATA
{
    class ENDERECO_REPOSITORIO
    {
        // ===================== CAMPOS =====================
        // INT END_ID | STRING END_LOGRADOURO | STRING END_ENDERECO
        // STRING END_NUMERO | STRING END_BAIRRO | STRING END_CEP
        // STRING END_COMPLEMENTO | INT TIPEND_ID | STRING END_CIDADE
        // STRING END_UF
        // ===================== CAMPOS =====================

        // ============== CONSTRUTOR ============== 
        public ENDERECO_REPOSITORIO()
        {

        }

        // ================= MÉTODOS =================
        #region "ADICIONAR"
            public int Add(string log, string end, string num, string bairro, string cep, string compl, string cidade, string uf, int tipendId)
            {
                try
                {
                    CONEXAO con = new CONEXAO();
                    NpgsqlCommand cmd = new NpgsqlCommand(
                      "INSERT INTO endereco(end_logradouro, end_endereco, end_numero, end_bairro, end_cep, end_complemento, tipend_id, end_cidade, end_uf) " +
                       "VALUES ('@log', '@end', '@num', '@bairro', '@cep', '@compl', @tipend, '@cidade', '@uf')");

                    cmd.Parameters.AddWithValue("@log", log);
                    cmd.Parameters.AddWithValue("@end", end);
                    cmd.Parameters.AddWithValue("@num", num);
                    cmd.Parameters.AddWithValue("@bairro", bairro);
                    cmd.Parameters.AddWithValue("@cep", cep);
                    cmd.Parameters.AddWithValue("@compl", compl);
                    cmd.Parameters.AddWithValue("@tipend", tipendId);
                    cmd.Parameters.AddWithValue("@cidade", cidade);
                    cmd.Parameters.AddWithValue("@uf", uf);

                return con.ExecutacmdAI(cmd, "endereco");
                }

                catch (Exception)
                {
                    throw new Exception("Erro ao inserir. \n\r");
                }
            }
            #endregion

        #region "ALTERAR"
            public bool Update(int endId, string log, string end, string num, string bairro, string cep, string compl, string cidade, string uf, int tipendId)
            {
                int ok = 0;
                try
                {
                    CONEXAO con = new CONEXAO();
                    NpgsqlCommand cmd = new NpgsqlCommand(
                      "UPDATE endereco " +
                      "SET end_logradouro='@log', end_endereco='@end', end_numero='@num', end_bairro='@bairro', end_cep='@cep', end_complemento='@compl', tipend_id='@tipend', end_cidade='@cidade', end_uf='@uf' " +
                      "WHERE end_id=@id");

                    cmd.Parameters.AddWithValue("@log", log);
                    cmd.Parameters.AddWithValue("@end", end);
                    cmd.Parameters.AddWithValue("@num", num);
                    cmd.Parameters.AddWithValue("@bairro", bairro);
                    cmd.Parameters.AddWithValue("@cep", cep);
                    cmd.Parameters.AddWithValue("@compl", compl);
                    cmd.Parameters.AddWithValue("@tipend", tipendId);
                    cmd.Parameters.AddWithValue("@cidade", cidade);
                    cmd.Parameters.AddWithValue("@uf", uf);
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
            public bool Delete(int endId)
            {
                int ok = 0;
                try
                {
                    CONEXAO con = new CONEXAO();
                NpgsqlCommand cmd = new NpgsqlCommand(
                      "DELETE FROM endereco " +
                      "WHERE end_id=@id");


                    cmd.Parameters.AddWithValue("@id", endId);

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

        #region "BUSCAR POR TIPO ENDEREÇO"
            public DataTable BuscaPorTipo(int tipEndId)
            {
                try
                {
                    CONEXAO con = new CONEXAO();
                NpgsqlCommand cmd = new NpgsqlCommand(
                      "SELECT * " +
                      "FROM endereco " +
                      "WHERE tipend_id=@end " +
                      "ORDER BY end_uf ASC, end_cidade ASC, end_logradouro ASC");

                    cmd.Parameters.AddWithValue("@end", tipEndId);

                    return con.ExecutaConsulta(cmd);
                }
                catch (Exception)
                {
                    throw new Exception("Erro na busca por tipo de endereço. \n\r");
                }
            }
            #endregion

        #region "BUSCAR POR ID"
            public DataTable BuscaId(int endId)
            {
                try
                {
                    CONEXAO con = new CONEXAO();
                NpgsqlCommand cmd = new NpgsqlCommand(
                      "SELECT * " +
                      "FROM endereco " +
                      "WHERE end_id=@id");

                    cmd.Parameters.AddWithValue("@id", endId);

                    return con.ExecutaConsulta(cmd);

                }
                catch (Exception)
                {
                    throw new Exception("Erro ao consultar por coódigo. \n\r");
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
                      "FROM endereco " +
                      "ORDER BY end_uf ASC, end_cidade ASC, end_logradouro ASC");

                    return con.ExecutaConsulta(cmd);
                }
                catch (Exception)
                {
                    throw new Exception("Erro ao consultar todos os endereços. \n\r");
                }
            }
            #endregion

    }
}
