using ASmarte.Core.Domain.Catalog;

namespace ASmarte.Data.Mapping.Catalog
{
    public partial class RelatedProductMap : ASmarteEntityTypeConfiguration<RelatedProduct>
    {
        public RelatedProductMap()
        {
            this.ToTable("RelatedProduct");
            this.HasKey(c => c.Id);
        }
    }
}