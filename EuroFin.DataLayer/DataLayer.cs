using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EuroFin.DataClasses;

namespace EuroFin.DataLayer
{
    public class DataLayer : IDataLayer
    {
        public bool deleteMyToDoList(int id)
        {
            try
            {
                EuroFinDBContext dBContext = new EuroFinDBContext();
                dBContext.TaskToDo.Remove(dBContext.TaskToDo.SingleOrDefault(x => x.Id == id));
                dBContext.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
                //throw;
            }
            
        }

        public void getMyToDoList()
        {
            EuroFinDBContext dBContext = new EuroFinDBContext();
            return dBContext.TaskToDo.ToList();
        }

        public void getRegisterUser(string user)
        {
            EuroFinDBContext dBContext = new EuroFinDBContext();
            var a = dBContext.User.SingleOrDefault(x => x.UserName == user);

            if (a == null)
            {
                return "";
            }
            else
            {
                return a.UserName;
            }
        }

        public void getTaskByUser(string user)
        {
            EuroFinDBContext dBContext = new EuroFinDBContext();
            return dBContext.TaskToDo.Where(x => x.UserName == user);
        }

        public void Login(User value)
        {
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

        public void postRegisterUser(User value)
        {
            EuroFinDBContext dBContext = new EuroFinDBContext();

            value.CreateDate = DateTime.Now;
            dBContext.User.Add(value);
            dBContext.SaveChanges();
        }

        public void saveMyToDoList(TaskToDo value)
        {
            EuroFinDBContext dBContext = new EuroFinDBContext();
            TaskToDo t = new TaskToDo { Note = value.Note, UserName = value.UserName };
            dBContext.TaskToDo.Add(t);
            dBContext.SaveChanges();
        }
    }
}
