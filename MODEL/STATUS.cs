using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MODEL
{
    public class STATUS
    {
        // PROPRIEDADES
        public int Sta_cod { get; set; }
        public string Sta_descricao { get; set; }
         
        // ============= CONSTRUTOR =============
        public STATUS(int cod, string desc)
        {
            this.Sta_cod = cod;
            this.Sta_descricao = desc;
        }

        public STATUS()
        {
         
        }

        public STATUS(int cod)
        {
            this.Sta_cod = cod;
        }

        public STATUS (string desc)
        {
            this.Sta_descricao = desc;
        }
    }
}