using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TheDigitalClock_WPF
{
    public static class Bootstrapper
    {
        private static ILifetimeScope _rootScope;

        public static void StartConfiguration()
        {
            if(_rootScope != null)
            {
                return;
            }

            var builder = new ContainerBuilder();

            var assemblies = new[] { Assembly.GetExecutingAssembly() };

            builder.RegisterAssemblyTypes(assemblies);
        }
        


    }
}
