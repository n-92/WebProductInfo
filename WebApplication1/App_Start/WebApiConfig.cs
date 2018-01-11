using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace ProductWebAPI.App_Start
{
    public class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Routes.Clear();
            config.Routes.MapHttpRoute(
               name: "DefaultApi",
               routeTemplate: "api/v1/{controller}/{id}",
               defaults: new{ id = RouteParameter.Optional }
            );
        }
    }
}