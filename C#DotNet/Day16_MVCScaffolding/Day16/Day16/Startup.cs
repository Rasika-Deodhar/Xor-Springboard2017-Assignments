using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Day16.Startup))]
namespace Day16
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
