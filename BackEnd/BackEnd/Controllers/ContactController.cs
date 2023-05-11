using Microsoft.AspNetCore.Mvc;

namespace BackEnd.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
