using ASmarte.Core.Domain.Catalog;

namespace ASmarte.Data.Mapping.Catalog
{
    public partial class ProductAttributeMap : ASmarteEntityTypeConfiguration<ProductAttribute>
    {
        public ProductAttributeMap()
        {
            this.ToTable("ProductAttribute");
            this.HasKey(pa => pa.Id);
            this.Property(pa => pa.Name).IsRequired();
        }
    }
}