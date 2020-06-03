using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;

namespace CatCattery.API.StartupConfiguration {
    public static class MvcOptionsExtensions {
        public static void UseCentralRoutePrefix(this MvcOptions opts, IRouteTemplateProvider routeAttribute) {
            opts.Conventions.Insert(0, new RouteConvention(routeAttribute)); // set global route prefix before each method 
        }
    }
}