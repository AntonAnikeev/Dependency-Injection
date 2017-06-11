using System.Collections.Generic;

namespace SetupNinjectForWebAPI.Dependencies
{
    public interface ISecondDependency
    {
        List<string> GetList();
    }
}