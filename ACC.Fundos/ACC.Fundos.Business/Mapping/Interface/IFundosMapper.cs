using ACC.Fundos.Business.Integration.CVM.Entities;
using ACC.Fundos.Contract.ResponseDTO;
using System.Collections.Generic;

namespace ACC.Fundos.Business.Mapping.Interface
{
    public interface IFundosMapper
    {
        FundoDTO CadastroFundo_TO_FundoDTO(CadastroFundo cadastroFundo);
        IList<FundoDTO> ListaCadastroFundo_TO_ListaFundoDTO(List<CadastroFundo> lista);
        InformacaoDiariaFundoDTO InformacaoDiariaFundo_TO_InformacaoDiariaFundoDTO(InformacaoDiariaFundo informacaoDiariaFundo);
        IList<InformacaoDiariaFundoDTO> ListaInformacaoDiariaFundo_TO_ListaInformacaoDiariaFundoDTO(List<InformacaoDiariaFundo> lista);
    }
}
