using MVCProjectHamburger.Models.Entities.Abstract;

namespace MVCProjectHamburger.Models.Entities.Concrete
{
    public class ExtraIngredientOrder:BaseRelation
    {
        public int ExtraIngredientID { get; set; }
        public int OrderID { get; set; }

        public ExtraIngredient? ExtraIngredient { get; set; }
        public Order Order { get; set; }

    }
}
