using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Norma_Brown_Photography.Startup))]
namespace Norma_Brown_Photography
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
