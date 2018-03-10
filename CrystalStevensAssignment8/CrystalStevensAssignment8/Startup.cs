using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CrystalStevensAssignment8.Startup))]
namespace CrystalStevensAssignment8
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
