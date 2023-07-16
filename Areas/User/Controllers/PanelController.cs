using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace MVCProjectHamburger.Areas.User.Controllers
{
    public class PanelController : Controller
    {
        [Area("User")]
        [Authorize(Roles = "User")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
