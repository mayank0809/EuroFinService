using System;
using EuroFin.DataClasses;

namespace EuroFin.DataLayer
{
    public class DataLayer:IDataLayer
    {
        public void deleteMyToDoList(int id)
        {
            throw new NotImplementedException();
        }

        public void getMyToDoList()
        {
            throw new NotImplementedException();
        }

        public void getRegisterUser(string user)
        {
            throw new NotImplementedException();
        }

        public void getTaskByUser(string user)
        {
            throw new NotImplementedException();
        }

        public void Login(User value)
        {
            EuroFinDBContext dBContext = new EuroFinDBContext();
            var a = dBContext.User.SingleOrDefault(x => x.UserName == value.UserName && x.Password == value.Password);

            if (a == null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, new User());
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.OK, a);
            }
        }

        public void postRegisterUser(User value)
        {
            throw new NotImplementedException();
        }

        public void saveMyToDoList(TaskToDo value)
        {
            throw new NotImplementedException();
        }
    }
}
