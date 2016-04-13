using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCHomework.Startup))]
namespace MVCHomework
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
