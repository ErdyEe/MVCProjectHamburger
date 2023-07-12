using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVCProjectHamburger.Models.Entities.Concrete;

namespace MVCProjectHamburger.Models.Configuration
{
    public class MenuExtraIngredient_CFG : IEntityTypeConfiguration<MenuExtraIngredient>
    {
        public void Configure(EntityTypeBuilder<MenuExtraIngredient> builder)
        {
           
        }
    }
}
