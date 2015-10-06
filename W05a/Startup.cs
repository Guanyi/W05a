using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(W05a.Startup))]
namespace W05a
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
