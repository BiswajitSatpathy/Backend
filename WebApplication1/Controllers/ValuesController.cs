//using Microsoft.AspNetCore.Mvc;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;



//namespace WebApplication1.Controllers
//{
//    [Route("api/v1/[controller]")]
//    [ApiController]
//    public class ValuesController : ControllerBase
//    {
//        // GET: api/<ValuesController>
//        [HttpGet]
//        public IEnumerable<string> Get()
//        {
//            return new string[] { "value1", "value2" };
//        }

//        // GET api/<ValuesController>/5
//        [HttpGet("{id}")]
//        public IActionResult Get(int id)
//        {
//            var a = new string[] { "value1", "value2" };
//            //if (id <= a.Length) return BadRequest(); else return Ok(a[id]);
//            return id <= a.Length ? (IActionResult)Ok(a[id]) : BadRequest();


//        }

//        // POST api/<ValuesController>
//        [HttpPost]
//        public IActionResult Post([FromBody] Employee value)
//        {
//            return Ok(value.UserName);
//        }

//        // PUT api/<ValuesController>/5
//        [HttpPut("{id}")]
//        public void Put(int id, [FromBody] Employee value)
//        {
//        }

//        // DELETE api/<ValuesController>/5
//        [HttpDelete("{id}")]
//        public void Delete(int id)
//        {
//        }
//    }
//}
