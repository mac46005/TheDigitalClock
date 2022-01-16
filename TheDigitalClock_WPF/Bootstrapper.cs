using Autofac;
using Autofac.Core;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TheDigitalClock_WPF.Core.MVVMHelper;
using TheDigitalClock_WPF.MVVM.ViewModels;

namespace TheDigitalClock_WPF
{
    public class Bootstrapper
    {
        private static ILifetimeScope _rootScope;
        private static IMainViewModel _mainViewModel;

        public static IViewModel RootVisual
        {
            get
            {
                if (_rootScope == null)
                {
                    Start();
                }
                _mainViewModel = _rootScope.Resolve<MainViewModel>();
                return _mainViewModel;
            }

        }

        public static void Start()
        {
            if (_rootScope != null)
            {
                return;
            }

            var builder = new ContainerBuilder();
            var assemblies = new[] { Assembly.GetExecutingAssembly() };
            builder.RegisterAssemblyTypes(assemblies)
                .Where(t => typeof(IViewModel).IsAssignableFrom(t))
                .InstancePerDependency();



            //builder.RegisterAssemblyTypes(assemblies)
            //    .Where(t => typeof(IViewModel).IsAssignableFrom(t))
            //    .Where(t =>
            //    {
            //        var isAssignable = typeof(ITransientViewModel).IsAssignableFrom(t);
            //        return isAssignable;
            //    })
            //    .AsImplementedInterfaces()
            //    .ExternallyOwned();

            

            _rootScope = builder.Build();

        }




        public static void Stop()
        {
            _rootScope.Dispose();
        }



        public static T Resolver<T>()
        {
            if (_rootScope == null)
            {
                throw new Exception("Bootstrapper hasn't started!");
            }

            return _rootScope.Resolve<T>(new Parameter[0]);
        }

        public static T Resolver<T>(Parameter[] parameters)
        {
            if (_rootScope == null)
            {
                throw new Exception("Bootstrapper hasn't started!");
            }

            return _rootScope.Resolve<T>(parameters);

        }
    }
}
