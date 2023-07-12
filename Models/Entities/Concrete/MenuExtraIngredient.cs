using MVCProjectHamburger.Models.Entities.Abstract;

namespace MVCProjectHamburger.Models.Entities.Concrete
{
    public class MenuExtraIngredient:BaseRelation
    {
        public int MenuID { get; set; }
        public int ExtraIngredientID { get; set; }

        public Menu Menu { get; set; }
        public ExtraIngredient? ExtraIngredient { get; set; }

    }
}
