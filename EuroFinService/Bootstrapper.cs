using EuroFinService.Resolver;
using Microsoft.Practices.Unity;
using System.Web.Http;

namespace EuroFinService
{

    public static class Bootstrapper
    {
        public static void Initialise()
        {
            var container = BuildUnityContainer();

            System.Web.Mvc.DependencyResolver.SetResolver(new Unity.Mvc5.UnityDependencyResolver(container));

            GlobalConfiguration.Configuration.DependencyResolver = new Unity.WebApi.UnityDependencyResolver(container);
        }

        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();
            RegisterTypes(container);
            return container;
        }


        public static void RegisterTypes(IUnityContainer container)
        {
            ComponentLoader.LoadContainer(container, ".\\bin", "EuroFinService.dll");
        }
    }
}