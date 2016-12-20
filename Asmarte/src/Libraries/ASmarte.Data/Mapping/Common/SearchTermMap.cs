using ASmarte.Core.Domain.Common;

namespace ASmarte.Data.Mapping.Common
{
    public partial class SearchTermMap : ASmarteEntityTypeConfiguration<SearchTerm>
    {
        public SearchTermMap()
        {
            this.ToTable("SearchTerm");
            this.HasKey(st => st.Id);
        }
    }
}
