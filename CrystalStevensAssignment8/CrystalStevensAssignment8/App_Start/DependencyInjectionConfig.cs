using System.Reflection;
using System.Web.Mvc;
using SimpleInjector;
using SimpleInjector.Integration.Web;
using SimpleInjector.Integration.Web.Mvc;
using CrystalStevensAssignment8.Repositories;
using CrystalStevensAssignment8.Services;
using CrystalStevensAssignment8.Models;

namespace CrystalStevensAssignment8.App_Start
{
    public class DependencyInjectionConfig
    {
        public static void Register()
        {
            // Create the container as usual.
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new WebRequestLifestyle();

            // Register types:
            
            container.Register<IEntityRepository, EntityRepository>(Lifestyle.Scoped);
            //container.Register<IUserService, UserService>(Lifestyle.Scoped);
            container.Register<IPetService, PetService>(Lifestyle.Scoped);
            container.Register<AppDbContext, AppDbContext>(Lifestyle.Scoped);

           // This is an extension method from the integration package.
            container.RegisterMvcControllers(Assembly.GetExecutingAssembly());

            container.Verify();

            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
        }
    }
}