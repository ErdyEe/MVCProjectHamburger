using Microsoft.AspNetCore.Mvc;

namespace MVCProjectHamburger.Areas.User.Controllers
{
    public class PanelController : Controller
    {
        [Area("User")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
