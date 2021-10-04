using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StepperApis.Controllers
{
    [Route("User")]
    public class UserController : Controller
    {
        [Route("GetDetails")]
        [HttpGet]
        public IEnumerable<string> GetDetails()
        {
            return new string[] { "test","api" };
        }

        [Route("GetDetails")]
        [HttpGet]
        public IEnumerable<string> GetAll()
        {
            return new string[] { "test", "api" };
        }

    }
}
