//------------------------------------------------------------------------------
// The contents of this file are subject to the ASmarteCommerce Public License Version 1.0 ("License"); you may not use this file except in compliance with the License.
// You may obtain a copy of the License at  http://www.ASmarteCommerce.com/License.aspx. 
// 
// Software distributed under the License is distributed on an "AS IS" basis, WITHOUT WARRANTY OF ANY KIND, either express or implied. 
// See the License for the specific language governing rights and limitations under the License.
// 
// The Original Code is ASmarteCommerce.
// The Initial Developer of the Original Code is ASmarteSolutions.
// All Rights Reserved.
// 
// Contributor(s): _______. 
//------------------------------------------------------------------------------

using System;
using System.Linq;
using System.Reflection;
using Autofac;
using System.IO;
using System.Collections.Generic;
using ASmarte.Core.Tasks;

namespace ASmarte.Core.Infrastructure
{
    [Obsolete("This work is performed in ASmarteEngine", true)]
    public class ASmarteStarter
    {
        private readonly object _locker = new object();
        private bool _configured;
        private IContainer _container;

        public IContainer BuildContainer()
        {
            lock (_locker)
            {
                if (_configured)
                    return _container;

                var builder = new ContainerBuilder();

                //type finder
                var typeFinder = new TypeFinder();
                builder.Register(c => typeFinder);
                
                //find IDependencyRegistar implementations
                var drTypes = typeFinder.FindClassesOfType<IDependencyRegistar>();
                foreach (var t in drTypes)
                {
                    dynamic dependencyRegistar = Activator.CreateInstance(t);
                    dependencyRegistar.Register(builder, typeFinder);
                }

                //event
                OnContainerBuilding(new ContainerBuilderEventArgs(builder));
                _container = builder.Build();
                //event
                OnContainerBuildingComplete(new ContainerBuilderEventArgs(builder));

                _configured = true;
                return _container;
            }
        }

        /// <summary>
        /// Execute startup tasks
        /// </summary>
        public void ExecuteStartUpTasks()
        {
            var startUpTaskTypes = _container.Resolve<ITypeFinder>().FindClassesOfType<IStartupTask>();
            foreach (var startUpTaskType in startUpTaskTypes)
            {
                var startUpTask = ((IStartupTask)Activator.CreateInstance(startUpTaskType));
                startUpTask.Execute();
            }
        }

        protected void OnContainerBuilding(ContainerBuilderEventArgs args)
        {
            if (ContainerBuilding != null)
            {
                ContainerBuilding(this, args);
            }
        }

        protected void OnContainerBuildingComplete(ContainerBuilderEventArgs args)
        {
            if (ContainerBuildingComplete != null)
            {
                ContainerBuildingComplete(this, args);
            }
        }

        public event EventHandler<ContainerBuilderEventArgs> ContainerBuilding;

        public event EventHandler<ContainerBuilderEventArgs> ContainerBuildingComplete;

    }
}
