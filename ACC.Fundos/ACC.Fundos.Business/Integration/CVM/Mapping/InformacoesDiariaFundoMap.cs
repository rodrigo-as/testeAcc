using ACC.Fundos.Business.Integration.CVM.Entities;
using CsvHelper.Configuration;

namespace ACC.Fundos.Business.Integration.CVM.Mapping
{
    public sealed class InformacaoDiariaFundoMap : ClassMap<InformacaoDiariaFundo>
    {
        public InformacaoDiariaFundoMap()
        {
            AutoMap();

            //Map(m => m.CNPJ_FUNDO).Name("xxxxxx");
            //Map(m => m.DT_COMPTC).Name("xxxxxx");
            //Map(m => m.VL_TOTAL).Name("xxxxxx");
            //Map(m => m.VL_QUOTA).Name("xxxxxx");
            //Map(m => m.VL_PATRIM_LIQ).Name("xxxxxx");
            //Map(m => m.CAPTC_DIA).Name("xxxxxx");
            //Map(m => m.RESG_DIA).Name("xxxxxx");;
            //Map(m => m.NR_COTST).Name("xxxxxx");
        }
    }
}
