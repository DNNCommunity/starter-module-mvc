using DotNetNuke.Web.Mvc.Routing;

namespace starter_module_mvc
{
    public class RouteConfig : IMvcRouteMapper
    {
        public void RegisterRoutes(IMapRoute mapRouteManager)
        {
            mapRouteManager.MapRoute(
                "starter_module_mvc",
                "default", 
                "{controller}/{action}", 
                new[] {"starter_module_mvc.Controllers"});
        }
    }
}