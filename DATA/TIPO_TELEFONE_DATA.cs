using MODEL;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA
{
    public class TIPO_TELEFONE_DATA
    {

       public TIPO_TELEFONE_DATA()
        {

        }

        public List<TIPO_TELEFONE> BuscarTodosTiposDeTelefonesLIST()
        {
            List<TIPO_TELEFONE> lista = new List<TIPO_TELEFONE>();

            try
            {
                NpgsqlDataAdapter da = default(NpgsqlDataAdapter);
                DataTable dt = new DataTable();

                CONEXAO con = new CONEXAO();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT * " +
                "FROM Tipo_Telefone");

                dt = con.ExecutaConsulta(cmd);

                da = new NpgsqlDataAdapter();

                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        TIPO_TELEFONE ObjTip = new TIPO_TELEFONE();
                        ObjTip.Tiptel_id = int.Parse(dt.Rows[i]["tiptel_cod"].ToString());
                        ObjTip.Tiptel_descricao = dt.Rows[i]["tiptel_desc"].ToString();

                        lista.Add(ObjTip);
                    }

                }

                return lista;
            }
            catch (NpgsqlException e)
            {
                throw new Exception( "Erro ao tentar se conectar ao banco de dados.\nErro:" + e.Message.ToString());
            }
            return lista;
        }


        public DataTable BuscarTodosTiposDeTelefonesDT()
        {           
            try
            {
                CONEXAO con = new CONEXAO();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT * " +
                "FROM Tipo_Telefone");

                return con.ExecutaConsulta(cmd);
            }
            catch (NpgsqlException e)
            {
                throw new Exception( "Erro ao tentar se conectar ao banco de dados.\nErro:" + e.Message.ToString());

            }
        }



        public string BuscarTipoTelefonePorCod(int tiptel_cod)
        {
            try
            {
                string ret = "";
                CONEXAO con = new CONEXAO();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT * " +
                "FROM Tipo_Telefone "+ 
                "WHERE tiptel_cod=@cod;");
                cmd.Parameters.AddWithValue("@cod", tiptel_cod);

                DataTable dt = con.ExecutaConsulta(cmd);

                if(dt.Rows.Count > 0) 
                {
                    ret = dt.Rows[0]["tiptel_desc"].ToString();
                    return ret;

                }else return ret;   

            }
            catch (NpgsqlException e)
            {
                throw new Exception("Erro ao tentar se conectar ao banco de dados.\nErro:" + e.Message.ToString());

            }
        }
    }
}
