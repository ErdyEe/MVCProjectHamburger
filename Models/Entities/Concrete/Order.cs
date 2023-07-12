namespace MVCProjectHamburger.Models.Entities.Concrete
{
    public class Order
    {
        public Order()
        {
            OrderMenus = new List<MenuOrder>();
            OrderExtraIngredients = new List<ExtraIngredientOrder>();
        }
        public int ID { get; set; }
        public int Number { get; set; }
        public int TotalPrice { get; set; }
        public ICollection<MenuOrder> OrderMenus { get; set; }
        public ICollection<ExtraIngredientOrder> OrderExtraIngredients { get; set; }
        public int AppUserID { get; set; }
        public  AppUser AppUser { get; set; }
    }
}
