using EuroFinService.Filter;
using EuroFinService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EuroFinService.Controllers
{
    [BasicAuthorize]
    public class MyToDoListController : ApiController
    {
        // GET api/values
        public IEnumerable<TaskToDo> Get()
        {
            //return new string[] { "value1", "value2" };

            EuroFinDBContext dBContext = new EuroFinDBContext();
            return dBContext.TaskToDo.ToList();
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]TaskToDo value)
        {
            EuroFinDBContext dBContext = new EuroFinDBContext();
            TaskToDo t = new TaskToDo { Note = value.Note };
            dBContext.TaskToDo.Add(t);
            dBContext.SaveChanges();
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            EuroFinDBContext dBContext = new EuroFinDBContext();
            dBContext.TaskToDo.Remove(dBContext.TaskToDo.SingleOrDefault(x=>x.Id==id));
            dBContext.SaveChanges();
        }
    }
}
