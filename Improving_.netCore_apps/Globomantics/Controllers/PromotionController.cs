using Microsoft.AspNetCore.Mvc;

namespace Globomantics.Controllers
{
    public class PromotionController:Controller
    {
        [HttpGet]
        [Route("promotion/{token:tokenCheck}")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("promotion")]
        public IActionResult Submit()
        {
            return View();
        }
        
    }
}