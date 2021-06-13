using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SQLServerOLTP.Startup))]
namespace SQLServerOLTP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
