using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebMVCTest.Startup))]
namespace WebMVCTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
