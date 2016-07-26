using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BookLife.Web.Startup))]
namespace BookLife.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
