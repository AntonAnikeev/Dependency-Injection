using Ninject;
using Ninject.Modules;
using SetupNinjectForWebAPI.Dependencies;

namespace SetupNinjectForWebAPI
{
    public class Module : NinjectModule
    {
        public override void Load()
        {
            Bind<IDependency>().To<FirstDependency>().InTransientScope();
            Bind<IDependency>().To<FirstDependency>().InSingletonScope();
            Bind<IDependency>().To<FirstDependency>().InThreadScope();
            Bind<ISecondDependency>().To<SecondDependency>();
        }
    }
}