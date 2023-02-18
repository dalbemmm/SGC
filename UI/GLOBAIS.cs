using MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    public class GLOBAIS
    {

        public static USUARIO Global_Usu = new USUARIO();

        public GLOBAIS() { }

        public GLOBAIS(USUARIO usu)
        {
            Global_Usu = usu;  
        }

        public GLOBAIS(int usu_cod)
        {
            Global_Usu.usu_cod = usu_cod;
        }

        public GLOBAIS(string usu_login)
        {
            Global_Usu.usu_login = usu_login;
        }

        public GLOBAIS(string pes_nome, int pes_cod)
        {
            Global_Usu.usu_pessoa.Pes_cod = pes_cod;
            Global_Usu.usu_pessoa.Pes_nome = pes_nome;
        }

        public GLOBAIS(string pes_nome, String usu_login, int pes_cod)
        {
            Global_Usu.usu_pessoa.Pes_nome = pes_nome;
            Global_Usu.usu_login = usu_login;
            Global_Usu.usu_pessoa.Pes_cod = pes_cod;
        }

        public void LogOut()
        {
            Global_Usu.usu_pessoa.Pes_cod = 0;
            Global_Usu.usu_pessoa.Sta_cod = 0;
            Global_Usu.usu_login = "";
            Global_Usu.usu_pessoa.Pes_nome = "";
        }
    }
}
