using ACC.Fundos.Contract.RequestDTO;
using ACC.Fundos.Contract.ResponseDTO;
using System.Collections.Generic;

namespace ACC.Fundos.Business.Service.Interface
{
    public interface IFundosService
    {
        RetornoDTO<IList<FundoDTO>> ListarFundos();
        RetornoDTO<FundoDTO >ObterFundoInvestimento(FiltroObterFundoDTO filtro);
        RetornoDTO<IList<InformacaoDiariaFundoDTO>> ObterInformacoesDiariaFundo(FiltroInformacaoFundoDTO filtro);
    }
}
