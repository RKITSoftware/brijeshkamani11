
using System.Web.Http;

namespace CORSDemo.Controllers
{
    public class DefaultController : ApiController
    {
        [HttpGet]
        public IHttpActionResult GetHttp()
        {
            return Ok("Get: Request Accepted");
        }
    }
}
