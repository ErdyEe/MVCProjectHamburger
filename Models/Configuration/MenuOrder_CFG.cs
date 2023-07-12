using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVCProjectHamburger.Models.Entities.Concrete;

namespace MVCProjectHamburger.Models.Configuration
{
    public class MenuOrder_CFG : IEntityTypeConfiguration<MenuOrder>
    {
        public void Configure(EntityTypeBuilder<MenuOrder> builder)
        {
           
        }
    }
}
