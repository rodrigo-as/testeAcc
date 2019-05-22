using CsvHelper.Configuration.Attributes;
using System;

namespace ACC.Fundos.Business.Integration.CVM.Entities
{
    public class CadastroFundo
    {
        [Name("CNPJ_FUNDO")]
        public string CNPJ_FUNDO { get; set; }

        [Name("DENOM_SOCIAL")]
        public string DENOM_SOCIAL { get; set; }

        [Name("DT_REG")]
        public string DT_REG { get; set; }

        [Name("DT_CONST")]
        public string DT_CONST { get; set; }

        [Name("DT_CANCEL")]
        public string DT_CANCEL { get; set; }

        [Name("SIT")]
        public string SIT { get; set; }

        [Name("DT_INI_SIT")]
        public string DT_INI_SIT { get; set; }

        [Name("DT_INI_ATIV")]
        public string DT_INI_ATIV { get; set; }

        [Name("DT_INI_EXERC")]
        public string DT_INI_EXERC { get; set; }

        [Name("DT_FIM_EXERC")]
        public string DT_FIM_EXERC { get; set; }

        [Name("CLASSE")]
        public string CLASSE { get; set; }

        [Name("DT_INI_CLASSE")]
        public string DT_INI_CLASSE { get; set; }

        [Name("RENTAB_FUNDO")]
        public string RENTAB_FUNDO { get; set; }

        [Name("CONDOM")]
        public string CONDOM { get; set; }

        [Name("FUNDO_COTAS")]
        public string FUNDO_COTAS { get; set; }

        [Name("FUNDO_EXCLUSIVO")]
        public string FUNDO_EXCLUSIVO { get; set; }

        [Name("TRIB_LPRAZO")]
        public string TRIB_LPRAZO { get; set; }

        [Name("INVEST_QUALIF")]
        public string INVEST_QUALIF { get; set; }

        [Name("TAXA_PERFM")]
        public string TAXA_PERFM { get; set; }

        [Name("VL_PATRIM_LIQ")]
        public string VL_PATRIM_LIQ { get; set; }

        [Name("DT_PATRIM_LIQ")]
        public string DT_PATRIM_LIQ { get; set; }

        [Name("DIRETOR")]
        public string DIRETOR { get; set; }

        [Name("CNPJ_ADMIN")]
        public string CNPJ_ADMIN { get; set; }

        [Name("ADMIN")]
        public string ADMIN { get; set; }

        [Name("PF_PJ_GESTOR")]
        public string PF_PJ_GESTOR { get; set; }

        [Name("CPF_CNPJ_GESTOR")]
        public string CPF_CNPJ_GESTOR { get; set; }

        [Name("GESTOR")]
        public string GESTOR { get; set; }

        [Name("CNPJ_AUDITOR")]
        public string CNPJ_AUDITOR { get; set; }

        [Name("AUDITOR")]
        public string AUDITOR { get; set; }
    }
}
