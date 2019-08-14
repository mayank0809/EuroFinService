using Microsoft.VisualStudio.TestTools.UnitTesting;
using EuroFinService.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EuroFinService.Models;
using EuroFinService.Tests;

namespace EuroFinService.Controllers.Tests
{
    [TestClass()]
    public class MyToDoListControllerTests
    {
        [TestMethod()]
        public void GetToDoTest()
        {
            //var container = ContainerRegister.getContainer();
            //IOrderService IOrderServicesobj = container.Resolve<IOrderService>();
            //OrderObj = new OrderController(IOrderServicesobj);
          
            MyToDoListController myToDoList = new MyToDoListController();
            IEnumerable<TaskToDo> toDos = myToDoList.Get();
            Assert.IsTrue(toDos.Count()>0);
        }

        [TestMethod()]
        public void PostToDo()
        {
            MyToDoListController myToDoList = new MyToDoListController();
            TaskToDo childTask = new TaskToDo();
            childTask.Id = 101;
            childTask.Note = "Test Note";
             myToDoList.Post(childTask);
            
        }
    }
}