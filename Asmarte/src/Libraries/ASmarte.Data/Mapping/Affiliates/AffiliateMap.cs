using ASmarte.Core.Domain.Affiliates;

namespace ASmarte.Data.Mapping.Affiliates
{
    public partial class AffiliateMap : ASmarteEntityTypeConfiguration<Affiliate>
    {
        public AffiliateMap()
        {
            this.ToTable("Affiliate");
            this.HasKey(a => a.Id);

            this.HasRequired(a => a.Address).WithMany().HasForeignKey(x => x.AddressId).WillCascadeOnDelete(false);
        }
    }
}