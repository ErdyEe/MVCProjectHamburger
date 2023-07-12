using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVCProjectHamburger.Models.Entities.Concrete;

namespace MVCProjectHamburger.Models.Configuration
{
    public class Order_CFG : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
           
        }
    }
}
