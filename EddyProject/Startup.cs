using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EddyProject.Startup))]
namespace EddyProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
