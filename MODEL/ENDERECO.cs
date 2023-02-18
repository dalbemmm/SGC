using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MODEL
{
    public class ENDERECO
    {
        public int End_id { get; set; }
        public string End_logradouro { get; set; }
        public string End_endereco { get; set; }
        public string End_numero { get; set; }
        public string End_uf { get; set; }
        public string End_cidade { get; set; }
        public string End_CEP { get; set; }
        public string End_bairro { get; set; }
        public string End_complemento { get; set; }
        public int Cid_id { get; set; }
        public int Tipend_id { get; set; }
               
    }
}