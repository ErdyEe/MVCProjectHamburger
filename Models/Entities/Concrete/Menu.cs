using MVCProjectHamburger.Models.Entities.Abstract;
using MVCProjectHamburger.Models.Enums;

namespace MVCProjectHamburger.Models.Entities.Concrete
{
    public class Menu: BaseEntity
    {
        public Menu()
        {
            MenuExtraIngredients = new List<MenuExtraIngredient>();
            MenuOrders = new List<MenuOrder>();
        }
        public ICollection<MenuExtraIngredient> MenuExtraIngredients { get; set; }
        public ICollection<MenuOrder> MenuOrders { get; set; }
    }
}
