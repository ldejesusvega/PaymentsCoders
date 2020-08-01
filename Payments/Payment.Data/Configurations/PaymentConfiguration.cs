using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Payment.Domain;

namespace Payment.Data.Configurations
{
    public class PaymentConfiguration : IEntityTypeConfiguration<PaymentD>
    {
        public void Configure(EntityTypeBuilder<PaymentD> builder)
        {
            builder
                .HasKey(x => x.Id);

            builder
                .Property(x => x.Id)
                .UseIdentityColumn();

            builder
                .Property(x => x.Concept)
                .IsRequired()
                .HasMaxLength(250);

            builder
                .Property(x => x.Date)
                .IsRequired();

            builder
                .Property(x => x.Amount)
                .IsRequired();

            builder
                .ToTable("Payments");
        }
    }
}