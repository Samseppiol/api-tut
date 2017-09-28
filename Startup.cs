using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(vidly_two.Startup))]
namespace vidly_two
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
