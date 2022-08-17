using System.Diagnostics;
using System.Web;
using System.Web.Http;

namespace RestierServiceV2
{
    public class WebApiApplication : HttpApplication
    {
        protected void Application_Start()
        {
            Debug.WriteLine("Application_start");
            var config = GlobalConfiguration.Configuration;
            config.IncludeErrorDetailPolicy = IncludeErrorDetailPolicy.Always;
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
