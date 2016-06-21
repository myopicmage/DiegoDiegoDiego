using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DiegoDiegoDiego.Startup))]
namespace DiegoDiegoDiego
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
