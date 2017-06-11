using System.Collections.Generic;

namespace SetupNinjectForWebAPI.Dependencies
{
    public class FirstDependency: IDependency
    {
        public List<string> GetList()
        {
            return new List<string>{"Boo", "Foo"};
        }
    }
}