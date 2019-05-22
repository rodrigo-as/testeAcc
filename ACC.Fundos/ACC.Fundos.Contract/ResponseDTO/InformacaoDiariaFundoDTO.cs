using System;

namespace ACC.Fundos.Contract.ResponseDTO
{
    public class InformacaoDiariaFundoDTO
    {
        public string CnpjFundo { get; set; }
        
        public string DataComptc { get; set; }
        
        public string ValorTotal { get; set; }
        
        public string ValorQuota { get; set; }

        public string ValorPatrimLiq { get; set; }
        
        public string CaptcDia { get; set; }
        
        public string ResgDia { get; set; }

        public string NumeroCotst { get; set; }
    }
}