using Microsoft.VisualStudio.TestTools.UnitTesting;
using EuroFinService.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EuroFinService.Models;
using EuroFinService.Tests;
using EuroFin.BusinessLayer;
using EuroFin.DataClasses;
using System.Net.Http;

using Microsoft.Practices.Unity;
using System.Net;

namespace EuroFinService.Controllers.Tests
{
    [TestClass()]
    public class MyToDoListControllerTests
    {
        [TestMethod()]
        public void GetToDoTest()
        {
            var container = ContainerRegister.getContainer();
            IBusinessLayer IBusinessLayerobj = container.Resolve <IBusinessLayer>();
            var OrderObj = new MyToDoListController(IBusinessLayerobj) {
                Request= new System.Net.Http.HttpRequestMessage(),
                Configuration=new System.Web.Http.HttpConfiguration()
            };

            //MyToDoListController myToDoList = new MyToDoListController(IBusinessLayerobj);
            HttpResponseMessage toDos = OrderObj.Get("User1");
            Assert.AreEqual(toDos.StatusCode,HttpStatusCode.OK);
        }

        [TestMethod()]
        public void PostToDo()
        {
            //MyToDoListController myToDoList = new MyToDoListController();
            //TaskToDo childTask = new TaskToDo();
            //childTask.Id = 101;
            //childTask.Note = "Test Note";
            // myToDoList.Post(childTask);
            
        }
    }
}