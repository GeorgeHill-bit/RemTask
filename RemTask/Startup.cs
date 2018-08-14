using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RemTask.Startup))]
namespace RemTask
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
