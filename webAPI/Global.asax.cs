using SimpleInjector;
using SimpleInjector.Integration.WebApi;
using System.Web;
using System.Web.Http;
using playbook.MongoData.Interface;
using playbook.MongoData.Repository;

namespace playbookAPI
{
    public class WebApiApplication : HttpApplication
    {
        protected void Application_Start()
        {
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new WebApiRequestLifestyle();

            container.Register<ICarRepository, CarRepository>(Lifestyle.Scoped);
			container.Register<IUserRepository, UserRepository>(Lifestyle.Scoped);
            container.Register<IUserTokenRepository, UserTokenRepository>(Lifestyle.Scoped);
            container.Register<IAdminUserRepository, AdminUserRepository>(Lifestyle.Scoped);
            container.Register<IAdminUserTokenRepository, AdminUserTokenRepository>(Lifestyle.Scoped);

            container.RegisterWebApiControllers(GlobalConfiguration.Configuration);

            container.Verify();

            GlobalConfiguration.Configuration.DependencyResolver = new SimpleInjectorWebApiDependencyResolver(container);

            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
