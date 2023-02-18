using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class REDES_SOCIAIS
    {
        public int red_cod { get; set; }
        public string red_descricao { get; set;}

        // =========== CONTRUTORES =============

        public REDES_SOCIAIS()
        {

        }

        public REDES_SOCIAIS(int red_cod, string red_descricao)
        {
            this.red_cod= red_cod;
            this.red_descricao = red_descricao;
        }

        public REDES_SOCIAIS(int red_cod)
        {
            this.red_cod = red_cod;
        }

        public REDES_SOCIAIS(string red_descricao)
        {
            this.red_descricao= red_descricao;
        }

    }
}
