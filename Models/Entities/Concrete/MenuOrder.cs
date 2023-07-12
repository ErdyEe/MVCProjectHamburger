using MVCProjectHamburger.Models.Entities.Abstract;

namespace MVCProjectHamburger.Models.Entities.Concrete
{
    public class MenuOrder:BaseRelation
    {
        public int MenuID { get; set; }
        public int OrderID { get; set; }
        public Menu Menu { get; set; }
        public Order Order { get; set; }

    }
}
