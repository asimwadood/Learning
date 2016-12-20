using ASmarte.Core.Domain.Catalog;

namespace ASmarte.Data.Mapping.Catalog
{
    public partial class CrossSellProductMap : ASmarteEntityTypeConfiguration<CrossSellProduct>
    {
        public CrossSellProductMap()
        {
            this.ToTable("CrossSellProduct");
            this.HasKey(c => c.Id);
        }
    }
}