using ASmarte.Core.Domain.Shipping;

namespace ASmarte.Data.Mapping.Shipping
{
    public class DeliveryDateMap : ASmarteEntityTypeConfiguration<DeliveryDate>
    {
        public DeliveryDateMap()
        {
            this.ToTable("DeliveryDate");
            this.HasKey(dd => dd.Id);
            this.Property(dd => dd.Name).IsRequired().HasMaxLength(400);
        }
    }
}
