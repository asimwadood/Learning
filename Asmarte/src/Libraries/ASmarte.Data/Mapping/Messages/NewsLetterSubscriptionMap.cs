using ASmarte.Core.Domain.Messages;

namespace ASmarte.Data.Mapping.Messages
{
    public partial class NewsLetterSubscriptionMap : ASmarteEntityTypeConfiguration<NewsLetterSubscription>
    {
        public NewsLetterSubscriptionMap()
        {
            this.ToTable("NewsLetterSubscription");
            this.HasKey(nls => nls.Id);

            this.Property(nls => nls.Email).IsRequired().HasMaxLength(255);
        }
    }
}