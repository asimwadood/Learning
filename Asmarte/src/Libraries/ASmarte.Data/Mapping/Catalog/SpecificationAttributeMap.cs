using ASmarte.Core.Domain.Catalog;

namespace ASmarte.Data.Mapping.Catalog
{
    public partial class SpecificationAttributeMap : ASmarteEntityTypeConfiguration<SpecificationAttribute>
    {
        public SpecificationAttributeMap()
        {
            this.ToTable("SpecificationAttribute");
            this.HasKey(sa => sa.Id);
            this.Property(sa => sa.Name).IsRequired();
        }
    }
}