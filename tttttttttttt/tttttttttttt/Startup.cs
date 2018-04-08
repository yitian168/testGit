using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(tttttttttttt.Startup))]
namespace tttttttttttt
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
