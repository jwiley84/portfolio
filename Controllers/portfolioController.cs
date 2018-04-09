using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
 
namespace portfolio.Controllers
{
    public class portfolioController : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult portfolio()
        {
                return View("portfolio");
        }

        [HttpGet]
        [Route("photosite")]
        public IActionResult photosite()
        {
                return View();
        }
    }
}