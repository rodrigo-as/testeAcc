using log4net;

namespace ACC.Fundos.WebApi.Controllers
{
    public class JobsController : BaseApiController
    {
        private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public JobsController()
                  : base()
        {
        }

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <remarks>
        ///// 
        ///// </remarks>
        //[HttpGet]
        //[ResponseType(typeof(FundoDTO))]
        //public IHttpActionResult Teste()
        //{
           
        //}
    }
}
