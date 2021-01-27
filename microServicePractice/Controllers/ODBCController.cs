using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using microServicePractice.Database;
using microServicePractice.Database.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace microServicePractice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ODBCController : ControllerBase
    {
        DatabaseContext db;
        public ODBCController()
        {
            db = new DatabaseContext();
        }
        // GET: api/<ODBCController>
        [HttpGet]
        public IEnumerable<ODBC> Get()
        {
            return db.odbc_table.ToList();
        }

        // GET api/<ODBCController>/5
        [HttpGet("{id}")]
        public ODBC Get(int id)
        {
            return db.odbc_table.Find(id);
        }

        // POST api/<ODBCController>
        [HttpPost]
        public IActionResult Post([FromBody] ODBC model)
        {
            try
            {
                db.odbc_table.Add(model);
                db.SaveChanges();
                return StatusCode(StatusCodes.Status201Created, model);
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }

        // PUT api/<ODBCController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ODBCController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
