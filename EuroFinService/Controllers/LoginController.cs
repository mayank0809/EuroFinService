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
    public class LoginController : ApiController
    {
        IBusinessLayer _bal;
        public LoginController(IBusinessLayer Ibal)
        {
            this._bal = Ibal;
        }
        

        // POST api/values
        public HttpResponseMessage Post([FromBody]User value)
        {
            try
            {
               var user = _bal.Login(value);
                return Request.CreateResponse(HttpStatusCode.OK, user);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);                
            }
            //BusinessLayer bal = new BusinessLayer();
           
            //return Request.CreateResponse(HttpStatusCode.OK, "");
            //EuroFinDBContext dBContext = new EuroFinDBContext();
            //var a = dBContext.User.SingleOrDefault(x=>x.UserName==value.UserName && x.Password==value.Password);

            //if (a == null)
            //{
            //    return Request.CreateResponse(HttpStatusCode.OK, new User());
            //}
            //else
            //{
            //    return Request.CreateResponse(HttpStatusCode.OK, a);
            //}
        }
    }
}
