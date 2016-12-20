using ASmarte.Core.Domain.Catalog;

namespace ASmarte.Data.Mapping.Catalog
{
    public partial class ProductReviewMap : ASmarteEntityTypeConfiguration<ProductReview>
    {
        public ProductReviewMap()
        {
            this.ToTable("ProductReview");
            this.HasKey(pr => pr.Id);

            this.HasRequired(pr => pr.Product)
                .WithMany(p => p.ProductReviews)
                .HasForeignKey(pr => pr.ProductId);

            this.HasRequired(pr => pr.Customer)
                .WithMany()
                .HasForeignKey(pr => pr.CustomerId);

            this.HasRequired(pr => pr.Store)
                .WithMany()
                .HasForeignKey(pr => pr.StoreId);
        }
    }
}