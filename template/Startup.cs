using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(template.Startup))]
namespace template
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
