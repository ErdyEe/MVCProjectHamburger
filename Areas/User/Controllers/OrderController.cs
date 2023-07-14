using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVCProjectHamburger.Data;
using MVCProjectHamburger.Models.Entities.Concrete;
using MVCProjectHamburger.Models.ViewModels;

namespace MVCProjectHamburger.Areas.User.Controllers
{
    [Area("User")]
    public class OrderController : Controller
    {
        private readonly HamburgerDbContext _context;

        public OrderController(HamburgerDbContext context)
        {
            _context = context;
        }

        // GET: User/Order
        public async Task<IActionResult> Index()
        {
            var hamburgerDbContext = _context.Orders.Include(o => o.AppUser).Include(o => o.OrderMenus).Include(o => o.OrderExtraIngredients);
            return View(await hamburgerDbContext.ToListAsync());
        }

        public IActionResult GetMenu()
        {
            List<Menu> menu = _context.Menus.ToList();
            return PartialView("_GetMenuPartial", menu);
        }

        public IActionResult GetExtraIngredient()
        {
            List<ExtraIngredient> extraIngredients = _context.ExtraIngredients.ToList();
            return PartialView("_GetExtraIngredientPartial", extraIngredients);
        }

        public IActionResult AddToOrder(int id)
        {
            Menu menu = _context.Menus.Find(id);
            return PartialView("_GetMenuPartial", menu);
        }
        //[HttpPost]
        //public IActionResult AddToOrder(Menu menu)
        //{

        //}


    }
}
