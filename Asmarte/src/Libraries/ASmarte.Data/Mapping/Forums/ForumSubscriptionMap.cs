using ASmarte.Core.Domain.Forums;

namespace ASmarte.Data.Mapping.Forums
{
    public partial class ForumSubscriptionMap : ASmarteEntityTypeConfiguration<ForumSubscription>
    {
        public ForumSubscriptionMap()
        {
            this.ToTable("Forums_Subscription");
            this.HasKey(fs => fs.Id);

            this.HasRequired(fs => fs.Customer)
                .WithMany()
                .HasForeignKey(fs => fs.CustomerId)
                .WillCascadeOnDelete(false);
        }
    }
}
