using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA
{
    public class PESSOA_REDES_SOCIAIS_REPOSITORIO
    {

        // ===================== CAMPOS =====================
        // INT PES_COD | INT RED_COD | STRING PESRED_USUARIO
        // ===================== CAMPOS =====================

        // ============== CONSTRUTOR ============== 
        public PESSOA_REDES_SOCIAIS_REPOSITORIO()
        {

        }

        // ================= MÉTODOS =================
        #region "ADICIONAR"
        public bool Add(int pes_cod, int red_cod, string pesred_usuario)
        {
            int ok = 0;
            try
            {
                ok = -1;
                CONEXAO con = new CONEXAO();
                NpgsqlCommand cmd = new NpgsqlCommand(
                  "INSERT INTO pessoa_redes_sociais(pes_cod, red_cod, pesred_usuario) " +
                   "VALUES (@pes, @red, @pesredusu)");

                cmd.Parameters.AddWithValue("@pes", pes_cod);
                cmd.Parameters.AddWithValue("@red", red_cod);
                cmd.Parameters.AddWithValue("@pesredusu", pesred_usuario);


                ok = con.ExecutaCmd(cmd);

                if (ok < 0) { return false; }
                else return true;
            }
            catch (Exception)
            {
                throw new Exception("Erro ao inserir. \n\r");
            }
        }
        #endregion

        #region "DELETAR"
        public bool Delete(int pes_cod)
        {
            int ok = 0;
            try
            {
                CONEXAO con = new CONEXAO();
                NpgsqlCommand cmd = new NpgsqlCommand(
                  "DELETE FROM pessoa_redes_sociais " +
                  "WHERE pes_cod=@id");


                cmd.Parameters.AddWithValue("@id", pes_cod);

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

        #region "BUSCAR POR PESSOA"
        public DataTable BuscaPessoa(int pes_cod)
        {
            try
            {
                CONEXAO con = new CONEXAO();
                NpgsqlCommand cmd = new NpgsqlCommand(
                  "SELECT * " +
                  "FROM pessoa_redes_sociais " +
                  "WHERE pes_cod = @pes");

                cmd.Parameters.AddWithValue("@pes", pes_cod);

                return con.ExecutaConsulta(cmd);

            }
            catch (Exception)
            {
                throw new Exception("Erro na busca. \n\r");
            }
        }
        #endregion
    }
}
