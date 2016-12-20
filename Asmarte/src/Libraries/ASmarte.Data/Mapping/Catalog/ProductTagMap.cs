using ASmarte.Core.Domain.Catalog;

namespace ASmarte.Data.Mapping.Catalog
{
    public partial class ProductTagMap : ASmarteEntityTypeConfiguration<ProductTag>
    {
        public ProductTagMap()
        {
            this.ToTable("ProductTag");
            this.HasKey(pt => pt.Id);
            this.Property(pt => pt.Name).IsRequired().HasMaxLength(400);
        }
    }
}