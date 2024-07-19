using Microsoft.AspNetCore.Mvc;

namespace ImobiliariaMVC.Controllers
{
    public class ImovelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
