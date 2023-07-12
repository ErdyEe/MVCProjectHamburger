using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVCProjectHamburger.Models.Entities.Concrete;

namespace MVCProjectHamburger.Models.Configuration
{
    public class ExtraIngredientOrder_CFG : IEntityTypeConfiguration<ExtraIngredientOrder>
    {
        public void Configure(EntityTypeBuilder<ExtraIngredientOrder> builder)
        {
            
        }
    }
}
