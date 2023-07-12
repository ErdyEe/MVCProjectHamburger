using MVCProjectHamburger.Models.Entities.Abstract;

namespace MVCProjectHamburger.Models.Entities.Concrete
{
    public class ExtraIngredient: BaseEntity
    {
        public ExtraIngredient()
        {
            MenuExtraIngredients = new List<MenuExtraIngredient>();
            OrderExtraIngredients = new List<ExtraIngredientOrder>();  
        }
        public ICollection<MenuExtraIngredient> MenuExtraIngredients { get; set; }
        public ICollection<ExtraIngredientOrder> OrderExtraIngredients { get; set; }
    }
}
