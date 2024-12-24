using System.Web.Http;


namespace FirstApi.Controllers
{
    public class MyFirstApiController : ApiController
    {
        // GET: MyFirstApi

        [HttpGet]
        public IHttpActionResult Index()
        {
            var response = new
            {
                Title = "Home Page",
                Message = "Welcome to your first API!"
            };
            return Ok(response); // Returns HTTP 200 with the response data
        }
    }
}