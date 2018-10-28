using Microsoft.AspNetCore.Mvc;
using System.Net.Http;

namespace WebApp.Properties.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet][HttpPost]
        public IActionResult Index()    // <== Action supporting more than one type of HTTP request.
        {
            // GET
            if (Request.Method.Equals(HttpMethod.Get.Method))
            {
                return View();
            }

            // POST
            if (Request.Method.Equals(HttpMethod.Post.Method))
            {
                return View();
            }

            return NotFound();
        }
    }
}
