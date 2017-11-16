using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BetTrack.Startup))]
namespace BetTrack
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
