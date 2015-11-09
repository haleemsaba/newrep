using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mygit.Startup))]
namespace mygit
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
