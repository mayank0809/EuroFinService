using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Practices.Unity;
using EuroFin.BusinessLayer;
using System.Net.Http;
using System.Net;
using EuroFinService.Controllers;
using EuroFin.DataClasses;

namespace EuroFinService.Tests.Controllers
{
    [TestClass()]
    public class RegisterControllerTest
    {
        [TestMethod()]
        public void GetToDoTest()
        {
            var container = ContainerRegister.getContainer();
            IBusinessLayer IBusinessLayerobj = container.Resolve<IBusinessLayer>();
            var OrderObj = new RegisterController(IBusinessLayerobj)
            {
                Request = new System.Net.Http.HttpRequestMessage(),
                Configuration = new System.Web.Http.HttpConfiguration()
            };

            //MyToDoListController myToDoList = new MyToDoListController(IBusinessLayerobj);
            HttpResponseMessage toDos = OrderObj.Get("User1");
            Assert.AreEqual((toDos.Content as ObjectContent).Value, "User1");
        }

        [TestMethod()]
        public void PostToDo()
        {
            var container = ContainerRegister.getContainer();
            IBusinessLayer IBusinessLayerobj = container.Resolve<IBusinessLayer>();

            User task = new User()
            {
                UserName="User3",
                EmailId="a@a.com",
                Password="a",
                PhoneNo="1"
            };
            var OrderObj = new RegisterController(IBusinessLayerobj)
            {
                Request = new System.Net.Http.HttpRequestMessage(),
                Configuration = new System.Web.Http.HttpConfiguration()
            };

            //MyToDoListController myToDoList = new MyToDoListController(IBusinessLayerobj);
            HttpResponseMessage toDos = OrderObj.Post(task);
            Assert.AreEqual(toDos.StatusCode, HttpStatusCode.OK);

        }
    }
}
