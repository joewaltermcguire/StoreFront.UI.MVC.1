using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StoreFront.UI.MVC._1.Startup))]
namespace StoreFront.UI.MVC._1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
