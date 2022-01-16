using Autofac;
using Autofac.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TheDigitalClock_WPF.MVVM.ViewModels;

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

            builder.RegisterAssemblyTypes(assemblies)
                .Where(t => typeof(IViewModel).IsAssignableFrom(t))
                .AsImplementedInterfaces();

            _rootScope = builder.Build();
        }
        

        public static void Dispose()
        {
            _rootScope.Dispose();
        }






        public static T Resolve<T>()
        {
            if(_rootScope == null)
            {
                throw new Exception("Bootstrapper not started");
            }

            return _rootScope.Resolve<T>();
        }
        public static T Resolve<T>(Parameter[] parameters)
        {
            if(_rootScope == null)
            {
                throw new Exception("Bootstrapper not started");
            }

            return _rootScope.Resolve<T>(parameters);
        }
    }
}
