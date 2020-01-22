using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatingApp.api.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace DatingApp.api.Controllers
{
    //http://localhost:5000/api/values
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : Controller
    {
        private readonly DataContext _context;
        public ValuesController(DataContext Context)
        {
            _context = Context;

        }


        // GET api/values
        [HttpGet]
        public async Task<IActionResult> Getvalues()
        {
            var values = await _context.Values.ToListAsync();

            return Ok(values);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Getvalue(int id)
        {
            var values = await _context.Values.FirstOrDefaultAsync(x => x.id == id);
            return Ok(values);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
