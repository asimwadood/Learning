using ASmarte.Core;
using ASmarte.Core.Data;
using ASmarte.Core.Infrastructure;

namespace ASmarte.Data
{
    public class EfStartUpTask : IStartupTask
    {
        public void Execute()
        {
            var settings = EngineContext.Current.Resolve<DataSettings>();
            if (settings != null && settings.IsValid())
            {
                var provider = EngineContext.Current.Resolve<IDataProvider>();
                if (provider == null)
                    throw new ASmarteException("No IDataProvider found");
                provider.SetDatabaseInitializer();
            }
        }

        public int Order
        {
            //ensure that this task is run first 
            get { return -1000; }
        }
    }
}
