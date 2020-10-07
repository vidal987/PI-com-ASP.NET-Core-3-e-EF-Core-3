using Microsoft.EntityFrameworkCore;
using projeto1.Models;

namespace projeto1.Data
{
    public class DataContext : DbContext 
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Product> Products {get; set;}
        public DbSet<Category> Categories {get; set;    }
    }
}