using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IdeaForSellsrc.Startup))]
namespace IdeaForSellsrc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
