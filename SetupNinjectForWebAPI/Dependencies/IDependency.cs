using System.Collections.Generic;

namespace SetupNinjectForWebAPI.Dependencies
{
    public interface IDependency
    {
        List<string> GetList();
    }
}