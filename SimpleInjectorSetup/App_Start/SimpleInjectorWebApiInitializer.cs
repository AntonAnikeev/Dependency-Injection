using SimpleInjectorSetup.Dependencies;

//[assembly: WebActivator.PostApplicationStartMethod(typeof(SimpleInjectorSetup.App_Start.SimpleInjectorWebApiInitializer), "Initialize")]

namespace SimpleInjectorSetup.App_Start
{
    using System.Web.Http;
    using SimpleInjector;
    using SimpleInjector.Integration.WebApi;
    
    public static class SimpleInjectorWebApiInitializer
    {
        /// <summary>Initialize the container and register it as Web API Dependency Resolver.</summary>
        public static void Initialize()
        {
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new WebApiRequestLifestyle();
            
            InitializeContainer(container);

            container.RegisterWebApiControllers(GlobalConfiguration.Configuration);
       
            container.Verify();
            
            GlobalConfiguration.Configuration.DependencyResolver =
                new SimpleInjectorWebApiDependencyResolver(container);
        }
     
        private static void InitializeContainer(Container container)
        {

            container.Register<IDependency, Depencency1>();
            //container.Register<IDependency, Depencency1>(Lifestyle.Scoped);
        }
    }
}