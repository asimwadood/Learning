using ASmarte.Core.Domain.Tasks;

namespace ASmarte.Data.Mapping.Tasks
{
    public partial class ScheduleTaskMap : ASmarteEntityTypeConfiguration<ScheduleTask>
    {
        public ScheduleTaskMap()
        {
            this.ToTable("ScheduleTask");
            this.HasKey(t => t.Id);
            this.Property(t => t.Name).IsRequired();
            this.Property(t => t.Type).IsRequired();
        }
    }
}