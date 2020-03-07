using System.Web.Http;

namespace WebApiSampleProject
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
           // System.Web.Http.GlobalConfiguration.Configure(WebApiConfig.Register);
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
