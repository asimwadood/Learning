using ASmarte.Core.Domain.Forums;

namespace ASmarte.Data.Mapping.Forums
{
    public partial class ForumGroupMap : ASmarteEntityTypeConfiguration<ForumGroup>
    {
        public ForumGroupMap()
        {
            this.ToTable("Forums_Group");
            this.HasKey(fg => fg.Id);
            this.Property(fg => fg.Name).IsRequired().HasMaxLength(200);
        }
    }
}
