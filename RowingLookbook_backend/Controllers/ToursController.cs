using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RowingLookbook_backend.Models;

namespace RowingLookbook_backend.Controllers
{

    [Route("api/tours")]
    public class ToursController : Controller
    {
        public ToursController()
        {
            Context = LogBookContext.GetContext();
        }
        private LogBookContext Context;
        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<Tour> Get()
        {
            return Context.Tours;
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public Tour Get(int id)
        {
            //return null;
            return Context.Tours.Single(p => p.TourID.Equals(id));
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]Tour value)
        {

            Context.Tours.Update(value);
            Context.SaveChanges();

        }

        // PUT api/<controller>/5
        [HttpPut()]
        public Tour Put([FromBody]Tour value)
        {
            var created = Context.Tours.Add(value);
            Context.SaveChanges();
            return created.Entity;
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Context.Tours.Remove(Get(id));
            Context.SaveChanges();
        }
    }
}