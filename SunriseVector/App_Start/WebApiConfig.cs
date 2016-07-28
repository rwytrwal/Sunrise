using System.Net.Http.Headers;
using System.Web.Http;


namespace SunriseVector
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
        config.MapHttpAttributeRoutes();
        config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));
      
    }
    }
}
