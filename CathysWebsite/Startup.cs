using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CathysWebsite.Startup))]
namespace CathysWebsite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
