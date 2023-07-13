using Microsoft.AspNetCore.Mvc.Rendering;
using MVCProjectHamburger.Models.Entities.Concrete;

namespace MVCProjectHamburger.Models.ViewModels
{
    public class OrderVM
    {
        public Order Order { get; set; }
        public Menu Menu { get; set; }
        public SelectList ExtraIngredients { get; set; }
        public IFormFile ImgName { get; set; }

    }
}
