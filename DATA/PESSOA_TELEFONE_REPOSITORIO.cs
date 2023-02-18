using MODEL;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DATA
{
    public class PESSOA_TELEFONE_REPOSITORIO
    {
        // ===================== CAMPOS =====================
        // INT TEL_ID | STRING TEL_DDD | STRING TEL_TELEFONE
        // INT TIPTEL_ID | INT PES_ID | INT LOC_ID
        // INT FOR_ID
        // ===================== CAMPOS =====================

        public PESSOA_TELEFONE_REPOSITORIO()
        {
 
        }

        // ================= MÉTODOS =================
        #region "ADICIONAR"
        public Boolean Add(PESSOA_TELEFONE obj)
        {
            try
            {
                CONEXAO con = new CONEXAO();
                NpgsqlCommand cmd = new NpgsqlCommand(
                  "INSERT INTO pessoa_telefone(pes_cod, tel_ddd, tel_numero, tiptel_cod) " +
                   "VALUES (@pes,@ddd, @numero, @tiptel)");

                cmd.Parameters.AddWithValue("@pes", obj.Pes_cod);
                cmd.Parameters.AddWithValue("@ddd", obj.Tel_ddd);
                cmd.Parameters.AddWithValue("@numero", obj.Tel_numero);
                cmd.Parameters.AddWithValue("@tiptel", obj.Tiptel_cod);


                int ok = con.ExecutaCmd(cmd);

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
        public Boolean Delete(int pes_cod)
        {
            int ok = 0;
            try
            {
                CONEXAO con = new CONEXAO();
                NpgsqlCommand cmd = new NpgsqlCommand(
                  "DELETE FROM pessoa_telefone " +
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
        public DataTable BuscaTelefonesPessoa(int pes_cod)
        {
            try
            {
                CONEXAO con = new CONEXAO();
                NpgsqlCommand cmd = new NpgsqlCommand(
                  "SELECT * " +
                  "FROM pessoa_telefone " +
                  "WHERE pes_cod=@id");

                cmd.Parameters.AddWithValue("@id", pes_cod);

                return con.ExecutaConsulta(cmd);

            }
            catch (Exception)
            {
                throw new Exception("Erro ao Buscar todos. \n\r");
            }
        }
        #endregion
    }
}
