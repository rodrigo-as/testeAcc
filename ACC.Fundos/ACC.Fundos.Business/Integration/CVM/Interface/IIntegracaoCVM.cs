using ACC.Fundos.Business.Integration.CVM.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ACC.Fundos.Business.Integration.CVM.Interface
{
    public interface IIntegracaoCVM
    {
        void ObterArquivoFundos(DateTime dataSolicitada);

        IList<CadastroFundo> ListarFundos();
        CadastroFundo ObterFundo(string CnpjFundo);
        IList<InformacaoDiariaFundo> ObterInformacoesFundo(string CnpjFundo);
    }
}
