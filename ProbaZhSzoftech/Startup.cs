using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProbaZhSzoftech.Startup))]
namespace ProbaZhSzoftech
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
