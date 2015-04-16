using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PutniNalozi.Startup))]
namespace PutniNalozi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
