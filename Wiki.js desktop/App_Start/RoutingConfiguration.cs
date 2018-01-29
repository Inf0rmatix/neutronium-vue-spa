using Neutronium.Core.Navigation.Routing;
using Wiki.js_desktop.Application.Navigation;

namespace Wiki.js_desktop
{
    public class RoutingConfiguration
    {
        public static IRouterSolver Register()
        {
            var router = new Router();
            BuildRoutes(router);
            return router;
        }

        private static void BuildRoutes(IRouterBuilder routeBuilder)
        {
            var convention = routeBuilder.GetTemplateConvention("{vm}");
            typeof(RoutingConfiguration).GetTypesFromSameAssembly()
                .InNamespace("Wiki.js_desktop.ViewModel.Pages")
                .Register(convention);
        }
    }
}
