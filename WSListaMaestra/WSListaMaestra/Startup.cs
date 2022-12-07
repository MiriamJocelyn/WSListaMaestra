using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WSListaMaestra.Startup))]
namespace WSListaMaestra
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
