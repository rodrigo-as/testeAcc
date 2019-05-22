using System.Collections.Generic;
using ACC.Fundos.Business.Entities;
using ACC.Fundos.Business.Repository;
using ACC.Fundos.Contract.RequestDTO;

namespace ACC.Fundos.Data.Repository
{
    public class FundosRepository : IFundosRepository
    {
        public IList<Fundo> ListarFundos(FiltroObterFundoDTO filtro)
        {
            throw new System.NotImplementedException();
        }

        public IList<InformacaoFundo> ListarInformacoesFundo(FiltroInformacaoFundoDTO filtro)
        {
            throw new System.NotImplementedException();
        }

        public Fundo ObterFundo()
        {
            throw new System.NotImplementedException();
        }

        public void SalvaFundo(Fundo fundo)
        {
            throw new System.NotImplementedException();
        }
    }
}
