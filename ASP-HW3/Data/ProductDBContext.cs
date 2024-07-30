using System.Collections.Generic;

namespace ASP_HW3.Data
{
    public class ProductDBContext : DbContext
    {
        public ProductDBContext(DbContextOptions<ProductDBContext> options)
        : base(options) { }

        public DbSet<Product> Products { get; set; }

    }
}
