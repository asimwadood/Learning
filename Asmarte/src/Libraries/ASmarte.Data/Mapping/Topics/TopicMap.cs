using ASmarte.Core.Domain.Topics;

namespace ASmarte.Data.Mapping.Topics
{
    public class TopicMap : ASmarteEntityTypeConfiguration<Topic>
    {
        public TopicMap()
        {
            this.ToTable("Topic");
            this.HasKey(t => t.Id);
        }
    }
}
