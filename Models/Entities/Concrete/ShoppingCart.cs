using MVCProjectHamburger.Models.Entities.Abstract;

namespace MVCProjectHamburger.Models.Entities.Concrete
{
    public class ShoppingCart:BaseRelation
    {
        public int OrderID { get; set; }
        public string Name { get; set; }
        public int TotalPrice { get; set; }
        public int Number { get; set; }
        public string MenuSize { get; set; }
        public int MenuOrderId { get; set; }
    }
}
