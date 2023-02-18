using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MODEL
{
    public class PAGAMENTO
    {
        public int Pag_id { get; set; }
        public int Tippag_id { get; set; }
        public int Evefor_id { get; set; }
        public DateTime Pag_datavencimento { get; set; }
        public DateTime Pag_datapagamento { get; set; }
        public int Pag_parcelas { get; set; }
        public string Pag_comprovante { get; set; }

    }
}
