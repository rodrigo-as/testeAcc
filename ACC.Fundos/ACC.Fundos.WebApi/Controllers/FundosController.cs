using ACC.Fundos.Business.Service.Interface;
using ACC.Fundos.Contract.ResponseDTO;
using System;
using System.Web.Http;
using System.Web.Http.Description;
using log4net;
using System.Collections.Generic;
using ACC.Fundos.Contract.RequestDTO;

namespace ACC.Fundos.WebApi.Controllers
{
    [RoutePrefix("api")]
    public class FundosController : BaseApiController
    {
        private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private readonly IFundosService _fundosService;

        public FundosController(IFundosService fundosService)
                  : base()
        {
            this._fundosService = fundosService;
        }

        /// <summary>
        /// Listar fundos de investimentos
        /// </summary>
        /// <remarks>
        /// Listar fundos de investimentos
        /// </remarks>
        [HttpGet]
        [Route("ListarFundosInvestimentos")]
        [ResponseType(typeof(RetornoDTO<IList<FundoDTO>>))]
        public IHttpActionResult ListarFundosInvestimentos()
        {
            try
            {
                return Ok(_fundosService.ListarFundos());
            }
            catch (Exception ex)
            {
                log.Error("Erro ListarFundosInvestimentos: " + ex);
                throw ex;
            }
        }

        /// <summary>
        /// Obter fundo de investimento
        /// </summary>
        /// <remarks>
        /// Obter fundo de investimento
        /// </remarks>
        [HttpPost]
        [Route("ObterFundoInvestimento")]
        [ResponseType(typeof(RetornoDTO<FundoDTO>))]
        public IHttpActionResult ObterFundoInvestimento(FiltroObterFundoDTO filtro)
        {
            try
            {
                return Ok(_fundosService.ObterFundoInvestimento(filtro));
            }
            catch (Exception ex)
            {
                log.Error("Erro ObterFundoInvestimento: " + ex);
                throw ex;
            }
        }

        /// <summary>
        /// Obter informações diaria do fundo
        /// </summary>
        /// <remarks>
        /// Obter informações diaria do fundo
        /// </remarks>
        [HttpPost]
        [Route("ObterInformacoesDiariaFundo")]
        [ResponseType(typeof(RetornoDTO<IList<InformacaoDiariaFundoDTO>>))]
        public IHttpActionResult ObterInformacoesDiariaFundo(FiltroInformacaoFundoDTO filtro)
        {
            try
            {
                return Ok(_fundosService.ObterInformacoesDiariaFundo(filtro));
            }
            catch (Exception ex)
            {
                log.Error("Erro ObterInformacoesDiariaFundo: " + ex);
                throw ex;
            }
        }
    }
}
