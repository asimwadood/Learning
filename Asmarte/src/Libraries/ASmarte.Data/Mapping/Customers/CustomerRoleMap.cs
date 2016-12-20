using ASmarte.Core.Domain.Customers;

namespace ASmarte.Data.Mapping.Customers
{
    public partial class CustomerRoleMap : ASmarteEntityTypeConfiguration<CustomerRole>
    {
        public CustomerRoleMap()
        {
            this.ToTable("CustomerRole");
            this.HasKey(cr => cr.Id);
            this.Property(cr => cr.Name).IsRequired().HasMaxLength(255);
            this.Property(cr => cr.SystemName).HasMaxLength(255);
        }
    }
}