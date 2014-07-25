using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Hello_Grand_Circus.Startup))]
namespace Hello_Grand_Circus
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
