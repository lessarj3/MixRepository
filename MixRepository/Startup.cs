using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MixRepository.Startup))]
namespace MixRepository
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
