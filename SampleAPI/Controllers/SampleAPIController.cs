using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using SampleAPI.Models;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SampleAPI.Controllers
{
    [Route("api/SampleAPI")]
    public class SampleAPIController : Controller
    {

        private readonly SampleAPIContext _context;

        public SampleAPIController(SampleAPIContext context)
        {
            _context = context;

            if (_context.customer.Count() == 0)
            {
                _context.customer.Add(new Customer { customerPk = 1 });
                _context.SaveChanges();
            }
        }


        /*
         * These methods implement the two GET methods:
         * GET /api/customers
         * GET /api/customers/{customerPk}
         * 
         * */



        // GET: api/values
        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return _context.customer.ToList();
        }

        /*
        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        */

        [HttpGet("{id}", Name = "GetCustomer")]
        public IActionResult GetById(long id)
        {
            var item = _context.customer.FirstOrDefault(t => t.customerPk == id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }




        /*
        // POST api/values
        [HttpPost]
        public void Post([]string value)
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
        */
    }
}
