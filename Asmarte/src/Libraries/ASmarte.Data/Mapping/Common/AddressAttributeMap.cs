using ASmarte.Core.Domain.Common;

namespace ASmarte.Data.Mapping.Common
{
    public partial class AddressAttributeMap : ASmarteEntityTypeConfiguration<AddressAttribute>
    {
        public AddressAttributeMap()
        {
            this.ToTable("AddressAttribute");
            this.HasKey(aa => aa.Id);
            this.Property(aa => aa.Name).IsRequired().HasMaxLength(400);

            this.Ignore(aa => aa.AttributeControlType);
        }
    }
}