using ASmarte.Core.Domain.Shipping;

namespace ASmarte.Data.Mapping.Shipping
{
    public partial class ShipmentItemMap : ASmarteEntityTypeConfiguration<ShipmentItem>
    {
        public ShipmentItemMap()
        {
            this.ToTable("ShipmentItem");
            this.HasKey(si => si.Id);

            this.HasRequired(si => si.Shipment)
                .WithMany(s => s.ShipmentItems)
                .HasForeignKey(si => si.ShipmentId);
        }
    }
}