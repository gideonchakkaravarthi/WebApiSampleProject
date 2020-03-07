using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAjaxSampleApplication.Startup))]
namespace WebAjaxSampleApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
