using System.Data.Entity;
using System.Reflection;
using System.Web.Mvc;
using SimpleInjector;
using SimpleInjector.Integration.Web;
using SimpleInjector.Integration.Web.Mvc;
using CrystalStevensLab3Week4.Data;
using CrystalStevensLab3Week4.Repositories;
using CrystalStevensLab3Week4.Services;

namespace CrystalStevensLab3Week4.App_Start
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
            container.Register<IUserService, UserService>(Lifestyle.Scoped);
            container.Register<IPetService, PetService>(Lifestyle.Scoped);
            container.Register<AppDbContext, AppDbContext>(Lifestyle.Scoped);

           // This is an extension method from the integration package.
            container.RegisterMvcControllers(Assembly.GetExecutingAssembly());

            container.Verify();

            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
        }
    }
}