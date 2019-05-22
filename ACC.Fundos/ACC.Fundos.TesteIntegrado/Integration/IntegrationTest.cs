using ACC.Fundos.Business.Integration.CVM;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACC.Fundos.TesteIntegrado.Integration
{
    [TestClass]
    public class IntegrationTest
    {
        [TestMethod]
        public void ListarFundosTest()
        {
            IntegracaoCVM integracaoCVM = new IntegracaoCVM();

            var res = integracaoCVM.ListarFundos();

            Assert.IsNotNull(res);
        }

        [TestMethod]
        public void ObterFundoTest()
        {
            IntegracaoCVM integracaoCVM = new IntegracaoCVM();

            var res = integracaoCVM.ObterFundo("00.017.024/0001-53");

            Assert.IsNotNull(res);
        }

        [TestMethod]
        public void ObterInformacoesFundoTest()
        {
            IntegracaoCVM integracaoCVM = new IntegracaoCVM();

            var res = integracaoCVM.ObterInformacoesFundo("00.017.024/0001-53");

            Assert.IsNotNull(res);
        }
    }
}
