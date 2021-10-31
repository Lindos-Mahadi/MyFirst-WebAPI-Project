using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirst_WebAPI_Project.Controllers
{
    [ApiController]
    [Route("test/[action]")]
    public class TestController : Controller
    {
        public string Index()
        {
            return "hello from index";
        }
        public string Index1()
        {
            return "hello from index 1";
        }
    }
}
