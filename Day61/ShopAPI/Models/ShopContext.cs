using Microsoft.EntityFrameworkCore;


namespace ShopAPI.Models
{
    public class ShopContext :DbContext
    {
        public ShopContext(DbContextOptions options):base(options) { }
        public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product { Id=101,Name="Pencil",Price=10}
                );
        }
    }
}
