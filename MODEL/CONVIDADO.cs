using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MODEL
{
    public class CONVIDADO
    {
        public int Con_id { get; set; }
        public int Lis_cod { get; set; }
        public string Con_nome { get; set; }
        public string Con_ddd { get; set; }
        public string Con_telefone { get; set; }
        public char Con_sexo { get; set; }
        public string Con_email { get; set; }
        public char Con_confirmado { get; set; }
        public int Con_anexo { get; set; }
        public char Con_principal { get; set; }
        public int Catcon_id { get; set; }

    }
}
