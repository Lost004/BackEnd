using Microsoft.AspNetCore.Mvc;

namespace BackEnd.Controllers
{
    public class PortfolioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
