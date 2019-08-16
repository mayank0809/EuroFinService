using EuroFin.BusinessLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Practices.Unity;
using EuroFin.DataClasses;
using EuroFinService.Controllers;
using System.Net.Http;

namespace EuroFinService.Tests.Controllers
{
    [TestClass()]
    public class LoginControllerTest
    {
        [TestMethod()]
        public void PostToDo()
        {
            var container = ContainerRegister.getContainer();
            IBusinessLayer IBusinessLayerobj = container.Resolve<IBusinessLayer>();

            User task = new User()
            {
                UserName="User2",
                Password="a"
            };
            var OrderObj = new LoginController(IBusinessLayerobj)
            {
                Request = new System.Net.Http.HttpRequestMessage(),
                Configuration = new System.Web.Http.HttpConfiguration()
            };

            //MyToDoListController myToDoList = new MyToDoListController(IBusinessLayerobj);
            HttpResponseMessage toDos = OrderObj.Post(task);
            Assert.AreEqual(toDos.StatusCode, System.Net.HttpStatusCode.OK);

        }
    }
}
