using Ninject;
using SetupNinjectForWebAPI.App_Start;

namespace SetupNinjectForWebAPI
{
    public static class ServiceLocator 
    {
        public static IKernel Kernel { get; private set; }

        static ServiceLocator()
        {
            try
            {
                Kernel = NinjectWebCommon.GlobalKernel;
            }
            catch 
            {
                Kernel.Dispose();
                throw;
            }
        }

        public static T GetService<T>() where T : class
        {
            return Kernel.Get<T>();
        }
    }
}