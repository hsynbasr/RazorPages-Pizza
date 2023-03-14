using Microsoft.EntityFrameworkCore;
using WebRazorTest.Model;

namespace WebRazorTest.Data
{
    public class PizzaDbContext :DbContext
    {
        public DbSet<PizzaOrder> PizzaOrders { get; set; }


        public PizzaDbContext(DbContextOptions<PizzaDbContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PizzaOrder>()
                .ToTable("Orders");
        }
    }
}
