namespace ACC.Fundos.Business.Entities
{
    public class Fundo
    {
        public virtual string CnpjFundo { get; set; }
        public virtual string DenomSocial { get; set; }
        public virtual string DataReg { get; set; }
        public virtual string DataConst { get; set; }
        public virtual string DataCancel { get; set; }
        public virtual string Sit { get; set; }
        public virtual string DataIniSit { get; set; }
        public virtual string DataIniAtiv { get; set; }
        public virtual string DataIniExerc { get; set; }
        public virtual string DataFimExerc { get; set; }
        public virtual string Classe { get; set; }
        public virtual string DataIniClasse { get; set; }
        public virtual string RentabFundo { get; set; }
        public virtual string Condom { get; set; }
        public virtual string FundoCotas { get; set; }
        public virtual string FundoExclusivo { get; set; }
        public virtual string TribLPrazo { get; set; }
        public virtual string InvestQualif { get; set; }
        public virtual string TaxaPerfm { get; set; }
        public virtual string ValorPatrimLiq { get; set; }
        public virtual string DataPatrimLiq { get; set; }
        public virtual string Diretor { get; set; }
        public virtual string CnpjAdmin { get; set; }
        public virtual string Admin { get; set; }
        public virtual string PfPjGestor { get; set; }
        public virtual string CpfCnpjGestor { get; set; }
        public virtual string Gestor { get; set; }
        public virtual string CnpjAuditor { get; set; }
        public virtual string Auditor { get; set; }
    }
}
