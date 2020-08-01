using Microsoft.EntityFrameworkCore;
using Payment.Data.Configurations;
using Payment.Domain;

namespace Payment.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }

        public DbSet<PaymentD> Payments { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                .ApplyConfiguration(new PaymentConfiguration());
        }
    }
}