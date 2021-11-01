using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirst_WebAPI_Project.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [Route("get-all")]
        public string GetAll()
        {
            return "Get All";
        }
        [Route("get-all-authors")]
        public string GetAllAuthors()
        {
            return "Get All Authors";
        }
    }
}
