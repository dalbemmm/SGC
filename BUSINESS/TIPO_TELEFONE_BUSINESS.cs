using DATA;
using MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BUSINESS
{
    public class TIPO_TELEFONE_BUSINESS
    {
        // ===================== CAMPOS =====================
        // INT TIPTEL_ID | STRING TIPTEL_DESCRICAO | INT STA_ID
        // ===================== CAMPOS =====================

        public TIPO_TELEFONE_BUSINESS() { }

        public List<TIPO_TELEFONE> BuscarTodosTiposDeTelefoneLIST()
        {
            TIPO_TELEFONE_DATA objData = new TIPO_TELEFONE_DATA();
            return objData.BuscarTodosTiposDeTelefonesLIST();
        }

        public DataTable BuscarTodosTiposDeTelefoneDT()
        {
            TIPO_TELEFONE_DATA objData = new TIPO_TELEFONE_DATA();
            return objData.BuscarTodosTiposDeTelefonesDT();
        }


        public string BuscarTipoTelefonePorCod(int tiptel_cod)
        {
            TIPO_TELEFONE_DATA objData = new TIPO_TELEFONE_DATA();
            return objData.BuscarTipoTelefonePorCod(tiptel_cod);
        }
    }
}
