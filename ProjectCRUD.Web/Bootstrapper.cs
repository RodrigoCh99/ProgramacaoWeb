using Microsoft.Practices.Unity;
using ProjectCRUD.Domain.Interfaces.Repositorys;
using ProjectCRUD.Domain.Interfaces.Services;
using ProjectCRUD.Domain.Models;
using ProjectCRUD.Domain.Services;
using ProjectCRUD.Infrastructure.Interfaces;
using ProjectCRUD.Infrastructure.Repositorys;
using System.Web.Mvc;
using Unity.Mvc4;

namespace ProjectCRUD.Web
{
    public static class Bootstrapper
    {
        public static IUnityContainer Initialise()
        {
            var container = BuildUnityContainer();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));

            return container;
        }

        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();

            container.RegisterType<IUsuarioServices, UsuarioServices>();
            container.RegisterType<IUsuarioRepository, UsuarioRepository>();

            container.RegisterType<IEmpresaServices, EmpresaServices>();
            container.RegisterType<IEmpresaRepository, EmpresaRepository>();

            container.RegisterType<IPerfilServices, PerfilServices>();
            container.RegisterType<IPerfilRepository, PerfilRepository>();


            // register all your components with the container here
            // it is NOT necessary to register your controllers

            //e.g. container.RegisterType<ITestService, TestService>();    
            RegisterTypes(container);

            return container;
        }

        public static void RegisterTypes(IUnityContainer container)
        {

        }
    }
}