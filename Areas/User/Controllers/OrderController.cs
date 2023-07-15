using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVCProjectHamburger.Data;
using MVCProjectHamburger.Models.Entities.Concrete;
using MVCProjectHamburger.Models.Enums;
using MVCProjectHamburger.Models.ViewModels;

namespace MVCProjectHamburger.Areas.User.Controllers
{
    [Area("User")]
    public class OrderController : Controller
    {
        private readonly HamburgerDbContext _context;
        private readonly UserManager<AppUser> userManager;
        
        public OrderController(HamburgerDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            this.userManager = userManager;
            
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
        //public IActionResult AddToOrder()
        //{
        //    return PartialView("_GetPartialShoppingCart");
        //}

        [HttpPost]
        public IActionResult AddToOrder(int menuID, int number, int menuSize)
        {
            var sortedOrders = _context.Orders.OrderBy(o => o.ID);
            Order od = sortedOrders.LastOrDefault();

            _context.MenuOrders.Add(new MenuOrder {AppUserID = GetUserID(), MenuID = menuID, Number = number, MenuSizes = (MenuSize)EnumBelirle(menuSize),OrderID=od.ID});
            _context.SaveChanges();
            return NoContent();


        }
        [HttpPost]
        public IActionResult NewOrder()
        {
            Order od = new Order();
            _context.Orders.Add(od);
            _context.SaveChanges();
            return NoContent();
        }


        //Login olununca new Order yapılacak 
        //AddToOrder actioununda menu seçildi menuorderdan ordera ekleme yapılacak

        //Sipariş tamamla denildiğinde orders listesine order eklenecek
        //Sipariş tamamla deninldiğinde new order yapılacak


        private int GetUserID()
        {
            return int.Parse(userManager.GetUserId(User));
        }
        private Enum EnumBelirle(int sayi)
        {
            if (sayi == 0)
            {
                return MenuSize.Small;
            }
            else if (sayi == 10)
            {
                return MenuSize.Medium;
            }
            else
            {
                return MenuSize.Large;
            }
        }

    }
}
