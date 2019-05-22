using CsvHelper.Configuration.Attributes;
using System;

namespace ACC.Fundos.Business.Integration.CVM.Entities
{
    public class InformacaoDiariaFundo
    {
        [Name("CNPJ_FUNDO")]
        public string CNPJ_FUNDO { get; set; }

        [Name("DT_COMPTC")]
        public string DT_COMPTC { get; set; }

        [Name("VL_TOTAL")]
        public string VL_TOTAL { get; set; }

        [Name("VL_QUOTA")]
        public string VL_QUOTA { get; set; }

        [Name("VL_PATRIM_LIQ")]
        public string VL_PATRIM_LIQ { get; set; }

        [Name("CAPTC_DIA")]
        public string CAPTC_DIA { get; set; }

        [Name("RESG_DIA")]
        public string RESG_DIA { get; set; }

        [Name("NR_COTST")]
        public string NR_COTST { get; set; }
    }
}
