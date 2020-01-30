using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RestSharpExample.Startup))]
namespace RestSharpExample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
