using ASmarte.Core.Domain.Logging;

namespace ASmarte.Data.Mapping.Logging
{
    public partial class ActivityLogTypeMap : ASmarteEntityTypeConfiguration<ActivityLogType>
    {
        public ActivityLogTypeMap()
        {
            this.ToTable("ActivityLogType");
            this.HasKey(alt => alt.Id);

            this.Property(alt => alt.SystemKeyword).IsRequired().HasMaxLength(100);
            this.Property(alt => alt.Name).IsRequired().HasMaxLength(200);
        }
    }
}
