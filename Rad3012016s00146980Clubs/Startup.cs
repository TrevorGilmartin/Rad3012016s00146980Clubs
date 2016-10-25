using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Rad3012016s00146980Clubs.Startup))]
namespace Rad3012016s00146980Clubs
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
