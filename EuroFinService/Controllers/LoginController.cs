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
    public class LoginController : ApiController
    {
        

        // POST api/values
        public User Post([FromBody]User value)
        {
            //BusinessLayer bal = new BusinessLayer();
            //bal.Login(value);

            EuroFinDBContext dBContext = new EuroFinDBContext();
            var a = dBContext.User.SingleOrDefault(x=>x.UserName==value.UserName && x.Password==value.Password);

            if (a == null)
            {
                return new User();
            }
            else
            {
                return a;
            }
        }
    }
}
