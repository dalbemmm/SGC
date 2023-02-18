using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MODEL
{
    public class EVENTO
    {
        public int Eve_id { get; set; }
        public string Eve_descricao { get; set; }
        public DateTime Eve_data { get; set; }
        public decimal Eve_duracao { get; set; }
        public int Eve_quantidadepessoas { get; set; }
        public int Tipeve_id { get; set; }
        public int Sta_id { get; set; }
        public char Eve_postar { get; set; }
        public string Eve_url { get; set; }
        public char Eve_adesao { get; set; }
        public decimal Eve_valor { get; set; }


    }
}