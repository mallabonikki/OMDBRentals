using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OMDBRentals.Startup))]
namespace OMDBRentals
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
