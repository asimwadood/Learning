using ASmarte.Core.Domain.Media;

namespace ASmarte.Data.Mapping.Media
{
    public partial class DownloadMap : ASmarteEntityTypeConfiguration<Download>
    {
        public DownloadMap()
        {
            this.ToTable("Download");
            this.HasKey(p => p.Id);
            this.Property(p => p.DownloadBinary).IsMaxLength();
        }
    }
}