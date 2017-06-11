using System.Collections.Generic;

namespace SetupNinjectForWebAPI.Dependencies
{
    public class SecondDependency : ISecondDependency
    {
        public List<string> GetList()
        {
            return new List<string>{"Hello","World"};
        }
    }
}