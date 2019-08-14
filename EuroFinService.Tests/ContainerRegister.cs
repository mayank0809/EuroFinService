using EuroFinService.Resolver;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuroFinService.Tests
{
    public class ContainerRegister
    {

        static IUnityContainer container = new UnityContainer();

        private static void Initialise()
        {
            container = BuildUnityContainer();
        }

        private static IUnityContainer BuildUnityContainer()
        {
            RegisterTypes(container);
            return container;
        }

        public static void RegisterTypes(IUnityContainer container)
        {
            ComponentLoader.LoadContainer(container, ".\\", "EuroFinService.dll");
        }

        public static IUnityContainer getContainer()
        {
            Initialise();
            var container = BuildUnityContainer();
            return container;
        }
    }
}
