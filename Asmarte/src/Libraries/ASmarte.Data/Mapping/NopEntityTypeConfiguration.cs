using System.Data.Entity.ModelConfiguration;

namespace ASmarte.Data.Mapping
{
    public abstract class ASmarteEntityTypeConfiguration<T> : EntityTypeConfiguration<T> where T : class
    {
        protected ASmarteEntityTypeConfiguration()
        {
            PostInitialize();
        }

        /// <summary>
        /// Developers can override this method in custom partial classes
        /// in order to add some custom initialization code to constructors
        /// </summary>
        protected virtual void PostInitialize()
        {
            
        }
    }
}