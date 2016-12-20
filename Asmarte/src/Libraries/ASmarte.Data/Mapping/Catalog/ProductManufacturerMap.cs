using ASmarte.Core.Domain.Catalog;

namespace ASmarte.Data.Mapping.Catalog
{
    public partial class ProductManufacturerMap : ASmarteEntityTypeConfiguration<ProductManufacturer>
    {
        public ProductManufacturerMap()
        {
            this.ToTable("Product_Manufacturer_Mapping");
            this.HasKey(pm => pm.Id);
            
            this.HasRequired(pm => pm.Manufacturer)
                .WithMany()
                .HasForeignKey(pm => pm.ManufacturerId);


            this.HasRequired(pm => pm.Product)
                .WithMany(p => p.ProductManufacturers)
                .HasForeignKey(pm => pm.ProductId);
        }
    }
}