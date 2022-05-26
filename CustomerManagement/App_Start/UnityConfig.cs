using _DataCustomerManagement.Interfases;
using _DataCustomerManagement.Repositorys;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace CustomerManagement
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            container.RegisterType<ICustomerActions, RepositoryCustomerActions>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}