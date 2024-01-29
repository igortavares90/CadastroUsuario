using CadastroUsuario.Data;
using CadastroUsuario.Interfaces;
using CadastroUsuario.Repository;
using SimpleInjector;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace CadastroUsuario
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            var container = new Container();

            container.Register<IUserRepository, UserRepository>(Lifestyle.Singleton);
            container.Register<IDapperORM, DapperORM>(Lifestyle.Singleton);

        }
    }
}
