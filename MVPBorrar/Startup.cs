using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVPBorrar.Startup))]
namespace MVPBorrar
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
