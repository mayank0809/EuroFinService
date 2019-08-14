using System;
using EuroFin.DataClasses;
using EuroFin.DataLayer;

namespace EuroFin.BusinessLayer
{
    public class BusinessLayer :IBusinessLayer
    {
        IDataLayer dal;

        public BusinessLayer(IDataLayer Idal)
        {
            this.dal = Idal;
        }
        

        public void getMyToDoList()
        {
            dal.getMyToDoList();
        }

        public void deleteMyToDoList(int id)
        {
            dal.deleteMyToDoList(id);
        }

        public void getRegisterUser(string user)
        {
            dal.getRegisterUser(user);
        }

        public void getTaskByUser(string user)
        {
            dal.getTaskByUser(user);
        }

        public void Login(User value)
        {
            dal.Login(value);
            //DataLayer.DataLayer dal = new DataLayer.DataLayer();
            //dal.Login(value);
        }

        public void postRegisterUser(User value)
        {
            dal.postRegisterUser(value);
        }

        public void saveMyToDoList(TaskToDo value)
        {
            dal.saveMyToDoList(value);
        }
    }
}
