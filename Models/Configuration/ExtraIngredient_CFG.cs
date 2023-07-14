using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVCProjectHamburger.Models.Entities.Concrete;

namespace MVCProjectHamburger.Models.Configuration
{
    public class ExtraIngredient_CFG : IEntityTypeConfiguration<ExtraIngredient>
    {
        public void Configure(EntityTypeBuilder<ExtraIngredient> builder)
        {
            //builder.HasData(
            //    new ExtraIngredient
            //    {
            //        ID = 1,
            //        Name = "BBQ",
            //        CoverImage = "bbq.jpg",
            //        Price = 18
            //    });
        }
    } }
