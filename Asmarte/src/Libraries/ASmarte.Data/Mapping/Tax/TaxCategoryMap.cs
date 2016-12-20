using ASmarte.Core.Domain.Tax;

namespace ASmarte.Data.Mapping.Tax
{
    public class TaxCategoryMap : ASmarteEntityTypeConfiguration<TaxCategory>
    {
        public TaxCategoryMap()
        {
            this.ToTable("TaxCategory");
            this.HasKey(tc => tc.Id);
            this.Property(tc => tc.Name).IsRequired().HasMaxLength(400);
        }
    }
}
