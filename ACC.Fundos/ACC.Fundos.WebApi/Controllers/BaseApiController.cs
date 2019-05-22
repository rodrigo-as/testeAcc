using System;
using System.Web.Http;

namespace ACC.Fundos.WebApi.Controllers
{
    public class BaseApiController : ApiController, IDisposable
    {
        protected BaseApiController()
        {
        }
    }
}
