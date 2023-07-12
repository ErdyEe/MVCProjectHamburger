using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVCProjectHamburger.Models.Entities.Concrete;

namespace MVCProjectHamburger.Models.Configuration
{
    public class Menu_CFG : IEntityTypeConfiguration<Menu>
    {
        public void Configure(EntityTypeBuilder<Menu> builder)
        {
            
        }
    }
}
