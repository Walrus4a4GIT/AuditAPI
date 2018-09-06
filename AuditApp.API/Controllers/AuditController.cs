using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuditApp.API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AuditApp.API.Controllers
{
    [Route("api/[controller]")]
    public class AuditController : Controller
    {
        private readonly DataContext _context;

        public AuditController(DataContext context)
        {
            _context = context;

        }

        // GET api/values
        [HttpGet]
        public async Task<IActionResult> GetAudit()
        {
            var Audit = await _context.Audit.ToListAsync();

            return Ok(Audit);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAuditRow(int id)
        {
            var AuditRow = await _context.Audit.FirstOrDefaultAsync(x => x.Id == id);
                                            //.Select(b => new { ActionDescription = b.element("ActionDescription").Value});

            return Ok(AuditRow);
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
