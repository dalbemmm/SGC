using Npgsql;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DATA
{
    public class CONEXAO
    {
        NpgsqlConnection con = new NpgsqlConnection();

        // CONTRUTOR
        public CONEXAO() 
        {
            con.ConnectionString = "User ID=postgres;Password=2204;Host=localhost;Port=5432;Database=SGC;";
        }

        #region "ABRIR CONEXÃO"
        public void AbrirConexao()
        {
            try
            {
                if ((con.State == ConnectionState.Closed))
                {
                    con.Open();
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao abrir conexão.\n\r" + ex.Message);
            }
        }
        #endregion

        #region "FECHAR CONEXÃO"
        public void FecharConexao()
        {
            try
            {
                if ((con.State == ConnectionState.Open))
                {
                    con.Close();
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao fechar conexão. \n\r" + ex.Message);
            }
        }
        #endregion

        #region "EXECUTAR UM COMANDO NA BASE DE DADOS"
        /// <summary>
        /// Executa um comando na base de dados
        /// </summary>
        /// <param name="cmd">Comando (Insert, Update, Delete) </param>
        /// <returns>-1: erro ou num_linhas </returns>
        /// <remarks></remarks>
        public int ExecutaCmd(NpgsqlCommand cmd)
        {
            int ret = 0;
            try
            {
                ret = -1;
                cmd.Connection = con;
                AbrirConexao();
                ret = Convert.ToInt32(cmd.ExecuteScalar());
                FecharConexao();
            }
            catch (NpgsqlException ex)
            {
                throw new Exception("Erro ao executar comando na base de dados.\n\r", ex);
            }

            return ret;
        }
        #endregion

        #region "EXECUTA COM AUTOINCREMENT"
        /// <summary>
        /// Executa insert e retorna a sequencia (codigo AI inserido)
        /// </summary>
        /// <param name="cmd"></param>
        /// <param name="tabela"></param>
        /// <returns></returns>
        /// <remarks></remarks>
        public int ExecutacmdAI(NpgsqlCommand cmd, string tabela)
        {
            int codigo = 0;
            try
            {
                codigo = -1;
                cmd.Connection = con;
                cmd.CommandText = cmd.CommandText + " RETURNING " + tabela + ";";
                AbrirConexao();
                codigo = Convert.ToInt32(cmd.ExecuteScalar());
                FecharConexao();

            }
            catch (NpgsqlException ex)
            {
                throw new Exception("Erro ao executar comando na base de dados", ex);

            }
            return codigo;
        }
        #endregion

        #region "REALIZAR CONSULTA NA BASE DE DADOS"
        /// <summary>
        /// Realiza consulta na base de dados e retorna em database
        /// </summary>
        /// <param name="cmd"></param>
        /// <returns></returns>
        /// <remarks></remarks>
        public DataTable ExecutaConsulta(NpgsqlCommand cmd)
        {
            DataTable tab = default;
            DataSet ds = default;
            NpgsqlDataAdapter da = default;
            try
            {
                ds = new DataSet();
                da = new NpgsqlDataAdapter();
                cmd.Connection = con;
                da.SelectCommand = cmd;
                da.Fill(ds, "tab");
                tab = ds.Tables["tab"];
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao realizar consulta na base de dados.\n\r", ex);
            }
            finally
            {
                da = null;
            }
            return tab;
        }
        #endregion

        #region "EXECUTA CONSULTA NO DATASET"
        public DataSet ExecutaconsultaDS(NpgsqlCommand cmd)
        {
            DataSet ds = default;
            NpgsqlDataAdapter da = default;
            try
            {
                ds = new DataSet();
                da = new NpgsqlDataAdapter();
                cmd.Connection = con;
                da.SelectCommand = cmd;
                da.Fill(ds, "tab");
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao executar consulta na base de dados.\n\r", ex);
            }
            finally
            {
                da = null;
            }
            return ds;
        }
        #endregion

        #region "RETORNAR DADOS DATATABLE"
        public DataTable RetdadosTab(NpgsqlCommand cmd)
        {
            DataTable tab = default;
            DataSet ds = default;
            NpgsqlDataAdapter da = default;
            try
            {
                cmd.Connection = con;
                da = new NpgsqlDataAdapter();
                da.SelectCommand = cmd;
                ds = new DataSet();
                da.Fill(ds, "tab");
                tab = ds.Tables["tab"];
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao selecionar dados.\n\r", ex);
            }
            finally
            {
                da = null;
                ds = null;
            }
            return tab;
        }
        #endregion

        #region "RETORNAR DADOS DATASET"
        public DataSet RetDados(NpgsqlCommand cmd)
        {
            DataSet ds = default;
            NpgsqlDataAdapter da = default;
            try
            {
                cmd.Connection = con;
                da = new NpgsqlDataAdapter();
                da.SelectCommand = cmd;
                ds = new DataSet();
                da.Fill(ds, "tab");
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao selecionar dados./n/r", ex);
            }
            finally
            {
                da = null;
            }
            return ds;
        }

        #endregion
    }
}