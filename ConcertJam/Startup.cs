using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ConcertJam.Startup))]
namespace ConcertJam
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
