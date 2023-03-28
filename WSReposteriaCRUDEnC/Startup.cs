using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WSReposteriaCRUDEnC.Startup))]
namespace WSReposteriaCRUDEnC
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
