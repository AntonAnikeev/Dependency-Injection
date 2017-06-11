using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using SimpleInjectorSetup.Dependencies;

namespace SimpleInjectorSetup.Controllers
{
    public class FooController: ApiController
    {
        private readonly IDependency _dependency;

        public FooController(IDependency dependency)
        {
            _dependency = dependency;
        }

        [HttpGet]
        [Route("api/print-value")]
        public string PrintValue()
        {
            return _dependency.PrintValue();
        }
    }
}