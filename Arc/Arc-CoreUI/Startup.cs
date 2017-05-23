using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Arc_CoreUi.Startup))]
namespace Arc_CoreUi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
