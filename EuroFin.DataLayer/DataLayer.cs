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

        public IEnumerable<TaskToDo> getMyToDoList()
        {
            try
            {
                EuroFinDBContext dBContext = new EuroFinDBContext();
                return dBContext.TaskToDo.ToList();
            }
            catch (Exception ex)
            {

                throw;
            }            
        }

        public string getRegisterUser(string user)
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

        public IEnumerable<TaskToDo> getTaskByUser(string user)
        {
            try
            {
                EuroFinDBContext dBContext = new EuroFinDBContext();
                return dBContext.TaskToDo.Where(x => x.UserName == user);
            }
            catch (Exception)
            {

                throw;
            }            
        }

        public User Login(User value)
        {
            EuroFinDBContext dBContext = new EuroFinDBContext();
            var a = dBContext.User.SingleOrDefault(x => x.UserName == value.UserName && x.Password == value.Password);

            if (a == null)
            {
                return new User();
            }
            else
            {
                return a;
            }
        }

        public bool postRegisterUser(User value)
        {
            try
            {
                EuroFinDBContext dBContext = new EuroFinDBContext();

                value.CreateDate = DateTime.Now;
                dBContext.User.Add(value);
                dBContext.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }            
        }

        public bool saveMyToDoList(TaskToDo value)
        {
            try
            {
                EuroFinDBContext dBContext = new EuroFinDBContext();
                TaskToDo t = new TaskToDo { Note = value.Note, UserName = value.UserName };
                dBContext.TaskToDo.Add(t);
                dBContext.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }            
        }
    }
}
