using ASmarte.Core.Domain.Shipping;

namespace ASmarte.Data.Mapping.Shipping
{
    public class WarehouseMap : ASmarteEntityTypeConfiguration<Warehouse>
    {
        public WarehouseMap()
        {
            this.ToTable("Warehouse");
            this.HasKey(wh => wh.Id);
            this.Property(wh => wh.Name).IsRequired().HasMaxLength(400);
        }
    }
}
