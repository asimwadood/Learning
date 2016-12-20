using ASmarte.Core.Domain.Orders;

namespace ASmarte.Data.Mapping.Orders
{
    public partial class ReturnRequestReasonMap : ASmarteEntityTypeConfiguration<ReturnRequestReason>
    {
        public ReturnRequestReasonMap()
        {
            this.ToTable("ReturnRequestReason");
            this.HasKey(rrr => rrr.Id);
            this.Property(rrr => rrr.Name).IsRequired().HasMaxLength(400);
        }
    }
}