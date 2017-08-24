using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppAula02_lab2.Startup))]
namespace WebAppAula02_lab2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
