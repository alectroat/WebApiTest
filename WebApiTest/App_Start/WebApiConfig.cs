using System.Web.Http;
using System.Web.Http.Dependencies;
using Unity;
using WebApiTest.Abstract;
using WebApiTest.App_Start;
using WebApiTest.Concrete;

namespace WebApiTest
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {            
            config.DependencyResolver = RegisterTypes();

            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
        public static IDependencyResolver RegisterTypes() {
            var container = new UnityContainer();
            container.RegisterType<IEmployeeRepository, EmployeeRepository>();
            return new UnityResolver(container);
        }
    }
}
