using EuroFin.BusinessLayer;
using EuroFin.DataClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EuroFinService.Controllers
{
    public class PasswordResetController : ApiController
    {
        IBusinessLayer _bal;
        public PasswordResetController(IBusinessLayer Ibal)
        {
            this._bal = Ibal;
        }
        // GET api/values
        public HttpResponseMessage Get()
        {
            //return new string[] { "value1", "value2" };
            try
            {
                Random random = new Random();
                var value = random.Next();

                return Request.CreateResponse(HttpStatusCode.OK, value);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
                throw;
            }


        }

        // GET api/values/5 getTaskByUser

        public string Get(int id)
        {
            return "value";
        }

        // GET api/values
        [Route("api/MyToDoList/gettaskbyuser/{user}")]
        public HttpResponseMessage Get(string user)
        {
            try
            {
                //return new string[] { "value1", "value2" };
                var task = _bal.getTaskByUser(user);
                return Request.CreateResponse(HttpStatusCode.OK, task);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
                throw;
            }
        }

        // POST api/values
        public HttpResponseMessage Post([FromBody]TaskToDo value)
        {
            try
            {
                bool bcheck = _bal.saveMyToDoList(value);
                return Request.CreateResponse(HttpStatusCode.OK, bcheck);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
                throw;
            }
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                bool bvalue = _bal.deleteMyToDoList(id);
                return Request.CreateResponse(HttpStatusCode.OK, bvalue);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
                throw;
            }
        }
    }
}
