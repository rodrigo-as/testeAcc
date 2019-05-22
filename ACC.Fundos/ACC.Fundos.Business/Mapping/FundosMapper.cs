using ACC.Fundos.Business.Integration.CVM.Entities;
using ACC.Fundos.Business.Mapping.Interface;
using ACC.Fundos.Contract.ResponseDTO;
using log4net;
using System;
using System.Collections.Generic;

namespace ACC.Fundos.Business.Mapping
{
    public class FundosMapper : IFundosMapper
    {
        private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public FundoDTO CadastroFundo_TO_FundoDTO(CadastroFundo cadastroFundo)
        {
            var fundoDTO = new FundoDTO();

            try
            {
                fundoDTO.Admin = cadastroFundo.ADMIN;
                fundoDTO.Auditor = cadastroFundo.AUDITOR;
                fundoDTO.Classe = cadastroFundo.CLASSE;
                fundoDTO.CnpjAdmin = cadastroFundo.CNPJ_ADMIN;
                fundoDTO.CnpjAuditor = cadastroFundo.CNPJ_AUDITOR;
                fundoDTO.CnpjFundo = cadastroFundo.CNPJ_FUNDO;
                fundoDTO.Condom = cadastroFundo.CONDOM;
                fundoDTO.CpfCnpjGestor = cadastroFundo.CPF_CNPJ_GESTOR;
                fundoDTO.DataCancel = cadastroFundo.DT_CANCEL;
                fundoDTO.DataConst = cadastroFundo.DT_CONST;
                fundoDTO.DataFimExerc = cadastroFundo.DT_FIM_EXERC;
                fundoDTO.DataIniAtiv = cadastroFundo.DT_INI_ATIV;
                fundoDTO.DataIniClasse = cadastroFundo.DT_INI_CLASSE;
                fundoDTO.DataIniExerc = cadastroFundo.DT_INI_EXERC;
                fundoDTO.DataIniSit = cadastroFundo.DT_INI_SIT;
                fundoDTO.DataPatrimLiq = cadastroFundo.DT_PATRIM_LIQ;
                fundoDTO.DataReg = cadastroFundo.DT_REG;
                fundoDTO.DenomSocial = cadastroFundo.DENOM_SOCIAL;
                fundoDTO.Diretor = cadastroFundo.DIRETOR;
                fundoDTO.FundoCotas = cadastroFundo.FUNDO_COTAS;
                fundoDTO.FundoExclusivo = cadastroFundo.FUNDO_EXCLUSIVO;
                fundoDTO.Gestor = cadastroFundo.GESTOR;
                fundoDTO.InvestQualif = cadastroFundo.INVEST_QUALIF;
                fundoDTO.PfPjGestor = cadastroFundo.PF_PJ_GESTOR;
                fundoDTO.RentabFundo = cadastroFundo.RENTAB_FUNDO;
                fundoDTO.Sit = cadastroFundo.SIT;
                fundoDTO.TaxaPerfm = cadastroFundo.TAXA_PERFM;
                fundoDTO.TribLPrazo = cadastroFundo.TRIB_LPRAZO;
                fundoDTO.ValorPatrimLiq = cadastroFundo.VL_PATRIM_LIQ;
            }
            catch (Exception ex)
            {
                log.Error("Erro no mapper CadastroFundo_TO_FundoDTO: " + ex);
            }

            return fundoDTO;
        }

        public IList<FundoDTO> ListaCadastroFundo_TO_ListaFundoDTO(List<CadastroFundo> lista)
        {
            IList<FundoDTO> listaFundoDTO = new List<FundoDTO>();

            try
            {
                foreach (var fundoDTO in lista)
                {
                    listaFundoDTO.Add(CadastroFundo_TO_FundoDTO(fundoDTO));
                }
            }
            catch (Exception ex)
            {
                log.Error("Erro no mapper ListaCadastroFundo_TO_ListaFundoDTO: " + ex);
            }

            return listaFundoDTO;
        }

        public InformacaoDiariaFundoDTO InformacaoDiariaFundo_TO_InformacaoDiariaFundoDTO(InformacaoDiariaFundo informacaoDiariaFundo)
        {
            var informacaoDiariaFundoDTO = new InformacaoDiariaFundoDTO();

            try
            {
                informacaoDiariaFundoDTO.CaptcDia = informacaoDiariaFundo.CAPTC_DIA;
                informacaoDiariaFundoDTO.CnpjFundo = informacaoDiariaFundo.CNPJ_FUNDO;
                informacaoDiariaFundoDTO.DataComptc = informacaoDiariaFundo.DT_COMPTC;
                informacaoDiariaFundoDTO.NumeroCotst = informacaoDiariaFundo.NR_COTST;
                informacaoDiariaFundoDTO.ResgDia = informacaoDiariaFundo.RESG_DIA;
                informacaoDiariaFundoDTO.ValorPatrimLiq = informacaoDiariaFundo.VL_PATRIM_LIQ;
                informacaoDiariaFundoDTO.ValorQuota = informacaoDiariaFundo.VL_QUOTA;
                informacaoDiariaFundoDTO.ValorTotal = informacaoDiariaFundo.VL_TOTAL;
            }
            catch (Exception ex)
            {
                log.Error("Erro no mapper InformacaoDiariaFundo_TO_InformacaoDiariaFundoDTO: " + ex);
            }

            return informacaoDiariaFundoDTO;
        }

        public IList<InformacaoDiariaFundoDTO> ListaInformacaoDiariaFundo_TO_ListaInformacaoDiariaFundoDTO(List<InformacaoDiariaFundo> lista)
        {
            IList<InformacaoDiariaFundoDTO> listaInformacaoDiariaFundoDTO = new List<InformacaoDiariaFundoDTO>();

            try
            {
                foreach (var informacaoDiariaFundoDTO in lista)
                {
                    listaInformacaoDiariaFundoDTO.Add(InformacaoDiariaFundo_TO_InformacaoDiariaFundoDTO(informacaoDiariaFundoDTO));
                }
            }
            catch (Exception ex)
            {
                log.Error("Erro no mapper ListaInformacaoDiariaFundo_TO_ListaInformacaoDiariaFundoDTO: " + ex);
            }

            return listaInformacaoDiariaFundoDTO;
        }
    }
}
