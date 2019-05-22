using ACC.Fundos.Business.Integration.CVM.Entities;
using CsvHelper.Configuration;

namespace ACC.Fundos.Business.Integration.CVM.Mapping
{
    public sealed class CadastroFundoMap : ClassMap<CadastroFundo>
    {
        public CadastroFundoMap()
        {
            AutoMap();

            //Map(m => m.CNPJ_FUNDO).Name("xxxxxx");
            //Map(m => m.DENOM_SOCIAL);
            //Map(m => m.DT_REG);
            //Map(m => m.DT_CONST);
            //Map(m => m.DT_CANCEL);
            //Map(m => m.SIT);
            //Map(m => m.DT_INI_SIT);
            //Map(m => m.DT_INI_ATIV);
            //Map(m => m.DT_INI_EXERC);
            //Map(m => m.DT_FIM_EXERC);
            //Map(m => m.CLASSE);
            //Map(m => m.DT_INI_CLASSE);
            //Map(m => m.RENTAB_FUNDO);
            //Map(m => m.CONDOM);
            //Map(m => m.FUNDO_COTAS);
            //Map(m => m.FUNDO_EXCLUSIVO);
            //Map(m => m.TRIB_LPRAZO);
            //Map(m => m.INVEST_QUALIF);
            //Map(m => m.TAXA_PERFM);
            //Map(m => m.VL_PATRIM_LIQ);
            //Map(m => m.DT_PATRIM_LIQ);
            //Map(m => m.DIRETOR);
            //Map(m => m.CNPJ_ADMIN);
            //Map(m => m.ADMIN);
            //Map(m => m.PF_PJ_GESTOR);
            //Map(m => m.CPF_CNPJ_GESTOR);
            //Map(m => m.GESTOR);
            //Map(m => m.CNPJ_AUDITOR);
            //Map(m => m.AUDITOR);
        }
    }
}
