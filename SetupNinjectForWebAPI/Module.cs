using Ninject;
using Ninject.Modules;
using SetupNinjectForWebAPI.Dependencies;

namespace SetupNinjectForWebAPI
{
    public class Module : NinjectModule
    {
        public override void Load()
        {
            Bind<IDependency>().To<FirstDependency>();
            Bind<ISecondDependency>().To<SecondDependency>();
        }
    }
}