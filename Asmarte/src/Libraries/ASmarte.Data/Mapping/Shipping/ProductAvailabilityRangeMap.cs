using ASmarte.Core.Domain.Shipping;

namespace ASmarte.Data.Mapping.Shipping
{
    public class ProductAvailabilityRangeMap : ASmarteEntityTypeConfiguration<ProductAvailabilityRange>
    {
        public ProductAvailabilityRangeMap()
        {
            this.ToTable("ProductAvailabilityRange");
            this.HasKey(range => range.Id);
            this.Property(range => range.Name).IsRequired().HasMaxLength(400);
        }
    }
}
