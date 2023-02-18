using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class PESSOA_REDES_SOCIAIS
    {
        // PROPRIEDADES
        public int pes_cod { get; set; }
        public int red_cod { get; set; }
        public string pesred_usuario { get; set; }

        // ============= CONSTRUTOR =============
        public PESSOA_REDES_SOCIAIS(int pes_cod, int red_cod, string pesred_usuario)
        {
            this.pes_cod = pes_cod;
            this.red_cod = red_cod;
            this.pesred_usuario = pesred_usuario;
        }

        public PESSOA_REDES_SOCIAIS()
        {

        }
    }
}
