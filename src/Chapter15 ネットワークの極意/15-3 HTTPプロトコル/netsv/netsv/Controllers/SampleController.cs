using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace netsv.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SampleController : ControllerBase
    {
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return $"GET ID is {id}";
        }

        [HttpPost]
        public string Post([FromBody] string name)
        {
            return $"POST name is {name}";
        }
    }
}
