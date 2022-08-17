using System;
using System.Diagnostics;
using System.Web.Http;
using System.Web.OData.Extensions;
using Microsoft.Restier.Providers.EntityFramework;
using Microsoft.Restier.Publishers.OData;
using Microsoft.Restier.Publishers.OData.Batch;
using Newtonsoft.Json;

namespace RestierServiceV2
{
    public static class WebApiConfig
    {
        public static async void Register(HttpConfiguration config)
        {
            Debug.WriteLine("OnRegister()");
            
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();
            var json = config.Formatters.JsonFormatter;
            json.SerializerSettings.PreserveReferencesHandling = PreserveReferencesHandling.Objects;
            json.SerializerSettings.NullValueHandling = NullValueHandling.Ignore;
            config.Formatters.Remove(config.Formatters.XmlFormatter);
            config.Filter().Expand().Select().OrderBy().MaxTop(null).Count();
            await config.MapRestierRoute<EntityFrameworkApi<PolModel>>("Pol","api/Pol",new RestierBatchHandler(GlobalConfiguration.DefaultServer));
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
