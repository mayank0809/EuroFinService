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
    public class RegisterController : ApiController
    {
        IBusinessLayer _bal;

        public RegisterController(IBusinessLayer Ibal)
        {
            this._bal = Ibal;
        }
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5

        [Route("api/register/getuser/{user}")]
        public HttpResponseMessage Get(string user)
        {
            try
            {
                string register = _bal.getRegisterUser(user);
                return Request.CreateResponse(HttpStatusCode.OK, register);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);                
            }
        }

        // POST api/values
        public HttpResponseMessage Post([FromBody]User value)
        {
            try
            {
                bool b =_bal.postRegisterUser(value);

                return Request.CreateResponse(HttpStatusCode.OK, b);
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
        public void Delete(int id)
        {
        }
    }
}
