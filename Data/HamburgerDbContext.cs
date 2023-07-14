using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MVCProjectHamburger.Models.Configuration;
using MVCProjectHamburger.Models.Entities.Concrete;

namespace MVCProjectHamburger.Data
{
    public class HamburgerDbContext : IdentityDbContext<AppUser, AppRole, int>
    {
        public HamburgerDbContext(DbContextOptions<HamburgerDbContext> options)
            : base(options)
        {
        }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<ExtraIngredient> ExtraIngredients { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<ExtraIngredientOrder> ExtraIngredientOrders { get; set; }
       
        public DbSet<MenuOrder> MenuOrders { get; set; }
        public DbSet<AppUser> Users { get; set; }
        public DbSet<AppRole> Roles { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<ExtraIngredient>().HasKey(x => x.ID);
            builder.Entity<Order>().HasKey(x => x.ID);
            builder.Entity<Menu>().HasKey(x => x.ID);
            builder.Entity<ExtraIngredientOrder>().HasKey(x => x.ID);
           
            builder.Entity<MenuOrder>().HasKey(x => x.ID);
            


            builder.Entity<AppRole>().HasData(
                new AppRole { Id = 1, Name = "Admin", NormalizedName = "ADMIN" },
                new AppRole { Id = 2, Name = "User", NormalizedName = "USER" }
                );

            builder.ApplyConfiguration<Menu>(new Menu_CFG());
            builder.ApplyConfiguration<ExtraIngredient>(new ExtraIngredient_CFG());
            builder.ApplyConfiguration<Order>(new Order_CFG());
           
            builder.ApplyConfiguration<ExtraIngredientOrder>(new ExtraIngredientOrder_CFG());
            builder.ApplyConfiguration<MenuOrder>(new MenuOrder_CFG());

            base.OnModelCreating(builder);
        }
    }
}
