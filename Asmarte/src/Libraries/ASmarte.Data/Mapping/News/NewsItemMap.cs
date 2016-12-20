using ASmarte.Core.Domain.News;

namespace ASmarte.Data.Mapping.News
{
    public partial class NewsItemMap : ASmarteEntityTypeConfiguration<NewsItem>
    {
        public NewsItemMap()
        {
            this.ToTable("News");
            this.HasKey(ni => ni.Id);
            this.Property(ni => ni.Title).IsRequired();
            this.Property(ni => ni.Short).IsRequired();
            this.Property(ni => ni.Full).IsRequired();
            this.Property(ni => ni.MetaKeywords).HasMaxLength(400);
            this.Property(ni => ni.MetaTitle).HasMaxLength(400);

            this.HasRequired(ni => ni.Language)
                .WithMany()
                .HasForeignKey(ni => ni.LanguageId).WillCascadeOnDelete(true);
        }
    }
}