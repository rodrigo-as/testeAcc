using ACC.Fundos.Business.Integration.CVM.Entities;
using ACC.Fundos.Business.Integration.CVM.Interface;
using ACC.Fundos.Business.Mapping.Interface;
using ACC.Fundos.Business.Service.Interface;
using ACC.Fundos.Contract.RequestDTO;
using ACC.Fundos.Contract.ResponseDTO;
using log4net;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ACC.Fundos.Business.Service
{
    public class FundosService : IFundosService
    {
        private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private readonly IIntegracaoCVM _integracaoCVM;
        private readonly IFundosMapper _fundosMapper;

        public FundosService(IIntegracaoCVM integracaoCVM, IFundosMapper fundosMapper)
        {
            _integracaoCVM = integracaoCVM;
            _fundosMapper = fundosMapper;
        }

        public RetornoDTO<IList<FundoDTO>> ListarFundos()
        {
            IList<FundoDTO> listaFundoDTO = new List<FundoDTO>();
            var retornoDTO = new RetornoDTO<IList<FundoDTO>>();

            listaFundoDTO = _fundosMapper.ListaCadastroFundo_TO_ListaFundoDTO(
                _integracaoCVM.ListarFundos().ToList<CadastroFundo>()
                );

            retornoDTO.Sucesso = true;
            retornoDTO.Retorno = listaFundoDTO;

            return retornoDTO;
        }

        public RetornoDTO<FundoDTO> ObterFundoInvestimento(FiltroObterFundoDTO filtro)
        {
            FundoDTO fundoDTO = new FundoDTO();
            var retornoDTO = new RetornoDTO<FundoDTO>();

            fundoDTO = _fundosMapper.CadastroFundo_TO_FundoDTO(
                 _integracaoCVM.ObterFundo(filtro.CnpjFundo)
                );

            retornoDTO.Sucesso = true;
            retornoDTO.Retorno = fundoDTO;

            return retornoDTO;
        }

        public RetornoDTO<IList<InformacaoDiariaFundoDTO>> ObterInformacoesDiariaFundo(FiltroInformacaoFundoDTO filtro)
        {
            IList<InformacaoDiariaFundoDTO> informacoesDiariaFundoDTO = new List<InformacaoDiariaFundoDTO>();
            var retornoDTO = new RetornoDTO<IList<InformacaoDiariaFundoDTO>>();

            informacoesDiariaFundoDTO = _fundosMapper.ListaInformacaoDiariaFundo_TO_ListaInformacaoDiariaFundoDTO(
                    _integracaoCVM.ObterInformacoesFundo(filtro.CnpjFundo).ToList<InformacaoDiariaFundo>()
                );

            retornoDTO.Sucesso = true;
            retornoDTO.Retorno = informacoesDiariaFundoDTO;

            return retornoDTO;
        }

    }
}
