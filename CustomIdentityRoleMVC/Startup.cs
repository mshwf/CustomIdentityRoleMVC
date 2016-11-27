using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CustomIdentityRoleMVC.Startup))]
namespace CustomIdentityRoleMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
