using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC5auto.Startup))]
namespace MVC5auto
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
