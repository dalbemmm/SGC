using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace MODEL
{
    public class CATEGORIA_CONVIDADO
    {

        public int Catcon_id { get; set; }
        public string Catcon_descricao { get; set; }
        public STATUS Sta_cod { get; set; }


        // ==================== CONSTRUTORES ====================//

        public CATEGORIA_CONVIDADO(int catconid, string catcondesc, int staid )
        {
            this.Catcon_id = catconid;
            this.Catcon_descricao = catcondesc;
            this.Sta_cod = new STATUS(staid);

            // MONTAR O OBJ STATUS
            //this.Sta_id = new STATUS()

        }

    }
}
