using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TichoArneSeesjarp.Startup))]
namespace TichoArneSeesjarp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
