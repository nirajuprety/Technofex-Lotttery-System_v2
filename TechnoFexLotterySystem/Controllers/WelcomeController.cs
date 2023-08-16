using Microsoft.AspNetCore.Mvc;

namespace TechnoFexLotterySystem.Controllers
{
    public class WelcomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
       
    }
}
