using ASmarte.Core.Domain.Discounts;

namespace ASmarte.Data.Mapping.Discounts
{
    public partial class DiscountRequirementMap : ASmarteEntityTypeConfiguration<DiscountRequirement>
    {
        public DiscountRequirementMap()
        {
            this.ToTable("DiscountRequirement");
            this.HasKey(dr => dr.Id);
        }
    }
}