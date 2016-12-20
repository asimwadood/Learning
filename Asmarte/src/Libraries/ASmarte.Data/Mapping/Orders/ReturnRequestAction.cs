using ASmarte.Core.Domain.Orders;

namespace ASmarte.Data.Mapping.Orders
{
    public partial class ReturnRequestActionMap : ASmarteEntityTypeConfiguration<ReturnRequestAction>
    {
        public ReturnRequestActionMap()
        {
            this.ToTable("ReturnRequestAction");
            this.HasKey(rra => rra.Id);
            this.Property(rra => rra.Name).IsRequired().HasMaxLength(400);
        }
    }
}