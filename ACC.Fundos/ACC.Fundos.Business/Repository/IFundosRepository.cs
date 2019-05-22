using ACC.Fundos.Business.Entities;
using ACC.Fundos.Contract.RequestDTO;
using System.Collections.Generic;

namespace ACC.Fundos.Business.Repository
{
    public interface IFundosRepository
    {
        void SalvaFundo(Fundo fundo);

        IList<Fundo> ListarFundos(FiltroObterFundoDTO filtro);

        Fundo ObterFundo();

        IList<InformacaoFundo> ListarInformacoesFundo(FiltroInformacaoFundoDTO filtro);
    }
}
