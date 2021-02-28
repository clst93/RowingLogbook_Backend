using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RowingLookbook_backend.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RowingLookbook_backend.Controllers
{
    [Route("api/person")]
    public class PersonsController : Controller
    {
        public PersonsController()
        {
            Context = LogBookContext.GetContext();
        }
        private LogBookContext Context;
        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<Person> Get()
        {
            return Context.Persons;
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public Person Get(int id)
        {
            //return null;
            return Context.Persons.Single(p => p.PersonID.Equals(id));
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]Person value)
        {
            
            Context.Persons.Update(value);
            Context.SaveChanges();
            
        }

        // PUT api/<controller>/5
        [HttpPut()]
        public Person Put([FromBody]Person value)
        {
            var created = Context.Persons.Add(value);
            Context.SaveChanges();
            return created.Entity;
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Context.Persons.Remove(Get(id));
            Context.SaveChanges();
        }
    }
}
