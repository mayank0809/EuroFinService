using EuroFin.BusinessLayer;
using EuroFin.DataClasses;
using EuroFinService.Models;
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
        public string Get(string user)
        {
            _bal.getRegisterUser(user);
            EuroFinDBContext11 dBContext = new EuroFinDBContext11();
            var a = dBContext.User.SingleOrDefault(x => x.UserName == user );

            if (a == null)
            {
                return "";
            }
            else
            {
                return a.UserName;
            }
        }

        // POST api/values
        public void Post([FromBody]User value)
        {
            _bal.postRegisterUser(value);

            //EuroFinDBContext11 dBContext = new EuroFinDBContext11();

            //value.CreateDate = DateTime.Now;
            //dBContext.User.Add(value);
            //dBContext.SaveChanges();
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
