using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JazGrandCircus.Startup))]
namespace JazGrandCircus
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
