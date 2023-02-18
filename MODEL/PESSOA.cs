using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class PESSOA
    {
        public int Pes_cod { get; set; }
        public string Pes_nome { get; set; }
        public string Pes_RG { get; set; }
        public string Pes_CPFCNPJ { get; set; }
        public char Pes_sexo { get; set; }
        public int Sta_cod { get; set; }
        public DateTime Pes_datanascimento { get; set; }
        public string Pes_email { get; set; }
        public string Pes_cep { get; set; }
        public string Pes_logradouro { get; set; }
        public string Pes_numero { get; set; }
        public string Pes_bairro { get; set; }
        public string Pes_cidade { get; set; }
        public string Pes_uf { get; set; }
        public string Pes_complemento { get; set; }
        public List<PESSOA_REDES_SOCIAIS> ListaRedesSociais { get; set; }
        public List<PESSOA_TELEFONE> ListaTelefones { get; set; }

        public PESSOA() { }

        public PESSOA(int pes_cod, string pes_nome, int pes_status)
        {
            this.Pes_cod = pes_cod;
            this.Pes_nome = pes_nome;
            this.Sta_cod = pes_status;
        }

        public PESSOA(int pes_cod)
        {
            this.Pes_cod=pes_cod;
        }
    }
}
