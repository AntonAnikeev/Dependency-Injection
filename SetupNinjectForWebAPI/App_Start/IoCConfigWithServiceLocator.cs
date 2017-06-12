using System;
using Ninject;

namespace SetupNinjectForWebAPI
{
    public static class IoCConfigWithServiceLocator
    {
        public static IKernel Kernel { get; private set; }

        static IoCConfigWithServiceLocator()
        {
            try
            {
                Kernel = new StandardKernel(new Module());
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