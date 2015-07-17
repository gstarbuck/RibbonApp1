using Catel;
using Catel.IoC;
using Orchestra.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RibbonApp1.Services
{
    public class ApplicationInitializationService : ApplicationInitializationServiceBase
    {
        private readonly IServiceLocator _serviceLocator;

        public override async Task InitializeBeforeCreatingShell()
        {            
            // Non-async first
            await RegisterTypes();
            //await InitializeCommands();

            //await RunAndWaitAsync(new Func<Task>[]
            //{
            //    InitializePerformance
            //});
        }

        //private async Task InitializeCommands()
        //{
            
        //}

        public ApplicationInitializationService(IServiceLocator serviceLocator)
        {
            Argument.IsNotNull(() => serviceLocator);

            _serviceLocator = serviceLocator;
        }

        public override async Task InitializeAfterCreatingShell()
        {
            Thread.Sleep(2500);
        }
        
        private async Task RegisterTypes()
        {
            var serviceLocator = _serviceLocator;

            serviceLocator.RegisterType<IAboutInfoService, AboutInfoService>();

            //throw new Exception("this is a test exception");
        }
    }
}
