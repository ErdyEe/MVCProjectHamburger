using Microsoft.AspNetCore.Identity;

namespace MVCProjectHamburger.Models.Entities.Concrete
{
    public class AppUser : IdentityUser<int>
    {
        public AppUser()
        {
            Orders = new List<Order>();
        }
        public ICollection<Order> Orders { get; set; }
    }
}
