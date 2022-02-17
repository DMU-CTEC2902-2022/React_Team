using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(InformationandTechnologyCollege.Startup))]
namespace InformationandTechnologyCollege
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
