using ASmarte.Core.Domain.Orders;

namespace ASmarte.Data.Mapping.Orders
{
    public partial class CheckoutAttributeMap : ASmarteEntityTypeConfiguration<CheckoutAttribute>
    {
        public CheckoutAttributeMap()
        {
            this.ToTable("CheckoutAttribute");
            this.HasKey(ca => ca.Id);
            this.Property(ca => ca.Name).IsRequired().HasMaxLength(400);

            this.Ignore(ca => ca.AttributeControlType);
        }
    }
}