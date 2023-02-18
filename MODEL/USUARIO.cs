namespace MODEL
{
    public class USUARIO
    {
        public int usu_cod;
        public int usu_status;
        public string usu_login;
        public string usu_senha;
        public PESSOA usu_pessoa = new PESSOA();

        public USUARIO() { }

        public USUARIO(int usu_cod)
        {
            this.usu_cod = usu_cod;
        }

        public USUARIO(int usu_cod, int usu_status, string usu_login, string usu_senha, PESSOA usu_pessoa) 
        {
            this.usu_cod = usu_cod;
            this.usu_status = usu_status;
            this.usu_login = usu_login;
            this.usu_senha = usu_senha;
            this.usu_pessoa = usu_pessoa;
        }
    }
}