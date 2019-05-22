using ACC.Fundos.Business.Integration.CVM.Entities;
using ACC.Fundos.Business.Integration.CVM.Interface;
using ACC.Fundos.Business.Mapping.Interface;
using ACC.Fundos.Business.Service;
using ACC.Fundos.Business.Service.Interface;
using ACC.Fundos.Contract.RequestDTO;
using ACC.Fundos.Contract.ResponseDTO;
using log4net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;

namespace ACC.Fundos.TesteUnitario.Business.Service
{
    [TestClass]
    public class FundosServiceTest
    {
        private Mock<ILog> _log;
        private Mock<IFundosService> _fundosService;
        private Mock<IIntegracaoCVM> _integracaoCVM;
        private Mock<IFundosMapper> _fundosMapper;

        [TestInitialize]
        public void Init()
        {
            _log = new Mock<ILog>(MockBehavior.Strict);
            _fundosService = new Mock<IFundosService>(MockBehavior.Strict);
            _integracaoCVM = new Mock<IIntegracaoCVM>(MockBehavior.Strict);
            _fundosMapper = new Mock<IFundosMapper>(MockBehavior.Strict);
        }

        [TestMethod]
        public void ListarFundosTest()
        {
            var listaFundoDTO = new RetornoDTO<IList<FundoDTO>>();
            var listaCadastroFundo = new List<CadastroFundo>();

            _fundosService.Setup(x => x.ListarFundos()).Returns(listaFundoDTO);
            _integracaoCVM.Setup(x => x.ListarFundos()).Returns(listaCadastroFundo);
            _fundosMapper.Setup(x => x.ListaCadastroFundo_TO_ListaFundoDTO(It.IsAny<List<CadastroFundo>>())).Returns(new List<FundoDTO>()
            {
                new FundoDTO() { CnpjFundo = "00.017.024/0001-53" }
            });

            FundosService fundosService = new FundosService(_integracaoCVM.Object,
                                                            _fundosMapper.Object);

            var res = fundosService.ListarFundos();

            Assert.IsNotNull(res.Retorno);
            Assert.IsTrue(res.Sucesso);
        }

        [TestMethod]
        public void ObterFundoInvestimentoTest()
        {
            var cadastroFundo = new CadastroFundo();
            var filtro = new FiltroObterFundoDTO { CnpjFundo = "00.017.024/0001-53" };

            _integracaoCVM.Setup(x => x.ObterFundo(filtro.CnpjFundo)).Returns(cadastroFundo);

            _fundosMapper.Setup(x => x.CadastroFundo_TO_FundoDTO(It.IsAny<CadastroFundo>())).Returns(new FundoDTO());


            FundosService fundosService = new FundosService(_integracaoCVM.Object,
                                                            _fundosMapper.Object);

            var res = fundosService.ObterFundoInvestimento(filtro);

            Assert.IsNotNull(res.Retorno);
            Assert.IsTrue(res.Sucesso);
        }

        [TestMethod]
        public void InformacoesDiariaFundoTest()
        {
            IList<InformacaoDiariaFundo> informacoesFundo = new List<InformacaoDiariaFundo>();
            var retornoDTO = new RetornoDTO<FundoDTO>();
            var fundoDTO = new FundoDTO();
            var cadastroFundo = new CadastroFundo();
            var filtro = new FiltroInformacaoFundoDTO { CnpjFundo = "00.017.024/0001-53" };

            _integracaoCVM.Setup(x => x.ObterInformacoesFundo(filtro.CnpjFundo)).Returns(informacoesFundo);

            _fundosMapper.Setup(x => x.ListaInformacaoDiariaFundo_TO_ListaInformacaoDiariaFundoDTO(It.IsAny<List<InformacaoDiariaFundo>>())).Returns(new List<InformacaoDiariaFundoDTO>() {
                new InformacaoDiariaFundoDTO() { CnpjFundo = "" }
            });


            FundosService fundosService = new FundosService(_integracaoCVM.Object,
                                                            _fundosMapper.Object);

            var res = fundosService.ObterInformacoesDiariaFundo(filtro);

            Assert.IsNotNull(res.Retorno);
            Assert.IsTrue(res.Sucesso);
        }
    }
}
