using System.Collections.Generic;
using System.Web.Http;
using SetupNinjectForWebAPI.Dependencies;

namespace SetupNinjectForWebAPI.Controllers
{
    public class BooController : ApiController
    {
        private readonly IDependency _dependency;
        private readonly ISecondDependency _secondDependency;

        public BooController(IDependency dependency, ISecondDependency secondDependency)
        {
            _dependency = dependency;
            _secondDependency = secondDependency;
        }

        [HttpGet]
        [Route("api/test")]
        public List<string> GetList()
        {
            return _dependency.GetList();   
        }

        [HttpGet]
        [Route("api/test-second-dependency")]
        public List<string> GetListFromSecondDependency()
        {
            return _secondDependency.GetList();
        } 

    }
}
