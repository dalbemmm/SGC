using MODEL;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DATA
{
    public class PESSOA_RESPOSITORIO
    {
        // ===================== CAMPOS =====================
        // INT PES_COD | STRING PES_NOME | STRING PES_RG
        // STRING PES_CPFCNPJ | CHAR PES_SEXO | INT STA_ID
        // DATETIME PES_DATANASCIMENTO | STRING PES_EMAIL
        // STRING PES_CEP | STRING PES_CIDADE | STRING PES_UF
        // STRING PES_LOGRADOURO | STRING PES_NUMERO 
        // STRING PES_BAIRRO | STRING PES_COMPLEMENTO
        // LIST<TELEFONE> LISTATEL | LIST<PESSOA_REDES_SOCIAIS> LISTAREDE
        // ===================== CAMPOS =====================


        // ================= CONSTRUTOR =================


        // ================= MÉTODOS =================
        #region "ADICIONAR"
        public int Add(PESSOA Obj)
        {

            string PES_NOME = Obj.Pes_nome;
            string PES_RG = Obj.Pes_RG;
            string PES_CPFCNPJ = Obj.Pes_CPFCNPJ;
            char PES_SEXO = char.Parse(Obj.Pes_sexo.ToString());
            int STA_COD = Obj.Sta_cod;
            DateTime PES_DATANASCIMENTO = Obj.Pes_datanascimento;
            string PES_EMAIL = Obj.Pes_email;
            string PES_CEP = Obj.Pes_cep;
            string PES_CIDADE = Obj.Pes_cidade;
            string PES_UF = Obj.Pes_uf;
            string PES_LOGRADOURO = Obj.Pes_logradouro;
            string PES_NUMERO = Obj.Pes_numero;
            string PES_BAIRRO = Obj.Pes_bairro;
            string PES_COMPLEMENTO = Obj.Pes_complemento;

        
            try
            {
                CONEXAO con = new CONEXAO();
                NpgsqlCommand cmd = new NpgsqlCommand(
                  "INSERT INTO pessoas(sta_cod, pes_nome, pes_rg, pes_cpf," +
                  "pes_sexo, pes_datanascimento, pes_email, pes_cep, pes_cidade," +
                  "pes_uf, pes_logradouro, pes_numero, pes_bairro, pes_complemento) " +
                   "VALUES (@status, @nome, @rg, @cpf, @sexo," +
                   "@datanasc, @email, @cep, @cidade, @uf, @logra, @numero, @bairro, @compl)");

                cmd.Parameters.AddWithValue("@status", STA_COD );
                cmd.Parameters.AddWithValue("@nome", PES_NOME);
                cmd.Parameters.AddWithValue("@rg", PES_RG);
                cmd.Parameters.AddWithValue("@cpf", PES_CPFCNPJ);
                cmd.Parameters.AddWithValue("@sexo", PES_SEXO);
                cmd.Parameters.AddWithValue("@datanasc", PES_DATANASCIMENTO); 
                cmd.Parameters.AddWithValue("@email", PES_EMAIL); 
                cmd.Parameters.AddWithValue("@cep", PES_CEP);
                cmd.Parameters.AddWithValue("@cidade", PES_CIDADE);
                cmd.Parameters.AddWithValue("@uf", PES_UF);
                cmd.Parameters.AddWithValue("@logra", PES_LOGRADOURO);
                cmd.Parameters.AddWithValue("@numero", PES_NUMERO);
                cmd.Parameters.AddWithValue("@bairro", PES_BAIRRO);
                cmd.Parameters.AddWithValue("@compl", PES_COMPLEMENTO);


                return con.ExecutacmdAI(cmd, "pes_cod");            
            }
            catch (Exception)
            {
                throw new Exception("Erro ao inserir. \n\r");
            }
        }
        #endregion

        #region "ALTERAR"
        public bool Update(PESSOA Obj)
        {
            int ok;

            int PES_COD = Obj.Pes_cod;
            string PES_NOME = Obj.Pes_nome;
            string PES_RG = Obj.Pes_RG;
            string PES_CPFCNPJ = Obj.Pes_CPFCNPJ;
            char PES_SEXO = char.Parse(Obj.Pes_sexo.ToString());
            int STA_COD = Obj.Sta_cod;
            DateTime PES_DATANASCIMENTO = Obj.Pes_datanascimento;
            string PES_EMAIL = Obj.Pes_email;
            string PES_CEP = Obj.Pes_cep;
            string PES_CIDADE = Obj.Pes_cidade;
            string PES_UF = Obj.Pes_uf;
            string PES_LOGRADOURO = Obj.Pes_logradouro;
            string PES_NUMERO = Obj.Pes_numero;
            string PES_BAIRRO = Obj.Pes_bairro;
            string PES_COMPLEMENTO = Obj.Pes_complemento;

            try
            {
                CONEXAO con = new CONEXAO();
                NpgsqlCommand cmd = new NpgsqlCommand(
                  "UPDATE pessoas " +
                  "SET sta_cod=@status, pes_nome=@nome, pes_rg=@rg, " +
                  "pes_cpf=@cpf, pes_sexo=@sexo, pes_datanascimento=@datanasc, " +
                  "pes_email=@email, pes_cep=@cep, pes_cidade=@cidade," +
                  "pes_uf=@uf, pes_logradouro=@logra, pes_numero=@numero, pes_bairro=@bairro, pes_complemento=@ompl" +
                  "WHERE pes_cod=@cod");

                cmd.Parameters.AddWithValue("@status", STA_COD);
                cmd.Parameters.AddWithValue("@nome", PES_NOME);
                cmd.Parameters.AddWithValue("@rg", PES_RG);
                cmd.Parameters.AddWithValue("@cpf", PES_CPFCNPJ);
                cmd.Parameters.AddWithValue("@sexo", PES_SEXO);
                cmd.Parameters.AddWithValue("@datanasc", PES_DATANASCIMENTO);
                cmd.Parameters.AddWithValue("@email", PES_EMAIL);
                cmd.Parameters.AddWithValue("@cep", PES_CEP);
                cmd.Parameters.AddWithValue("@cidade", PES_CIDADE);
                cmd.Parameters.AddWithValue("@uf", PES_UF);
                cmd.Parameters.AddWithValue("@logra", PES_LOGRADOURO);
                cmd.Parameters.AddWithValue("@numero", PES_NUMERO);
                cmd.Parameters.AddWithValue("@bairro", PES_BAIRRO);
                cmd.Parameters.AddWithValue("@compl", PES_COMPLEMENTO);
                cmd.Parameters.AddWithValue("@cod", PES_COD);

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
        public bool Delete(int pes_cod)
        {
            int ok;
            try
            {
                CONEXAO con = new CONEXAO();
                NpgsqlCommand cmd = new NpgsqlCommand(
                  "DELETE FROM pessoas " +
                  "WHERE pes_cod=@cod");


                cmd.Parameters.AddWithValue("@cod", pes_cod);

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
        public DataTable BuscaNome(string pes_nome)
        {
            try
            {
                CONEXAO con = new CONEXAO();
                NpgsqlCommand cmd = new NpgsqlCommand(
                  "SELECT * " +
                  "FROM pessoas " +
                  "WHERE pes_nome ilike '%" + pes_nome +"%';") ;

                //cmd.Parameters.AddWithValue("@nome", pes_nome);

                return con.ExecutaConsulta(cmd);

            }
            catch (Exception)
            {
                throw new Exception("Erro na busca. \n\r");
            }
        }
        #endregion

        #region "BUSCAR POR CODIGO"
        public DataTable BuscaCod(int pes_cod)
        {
            try
            {
                CONEXAO con = new CONEXAO();
                NpgsqlCommand cmd = new NpgsqlCommand(
                  "SELECT * " +
                  "FROM pessoas " +
                  "WHERE pes_cod=@cod");

                cmd.Parameters.AddWithValue("@cod", pes_cod);

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
                  "FROM pessoas");

                return con.ExecutaConsulta(cmd);
            }
            catch (Exception)
            {
                throw new Exception("Erro ao consultar todos. \n\r");
            }
        }
        #endregion


        #region "BUSCAR POR STATUS"
        public DataTable BuscarTodosPorStatus(int staId)
        {
            try
            {
                CONEXAO con = new CONEXAO();
                NpgsqlCommand cmd = new NpgsqlCommand(
                  "SELECT * " +
                  "FROM pessoas " +
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
