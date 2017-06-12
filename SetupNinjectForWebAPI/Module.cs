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
            Bind<ISecondDependency>().To<SecondDependency>();
        }
    }
}