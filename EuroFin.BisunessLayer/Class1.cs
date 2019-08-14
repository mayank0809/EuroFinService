using System;
using System.Collections.Generic;
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
        

        public IEnumerable<TaskToDo> getMyToDoList()
        {
            IEnumerable<TaskToDo> task = dal.getMyToDoList();
            return task;
        }

        public bool deleteMyToDoList(int id)
        {
            bool bcheck = dal.deleteMyToDoList(id);
            return bcheck;
        }

        public string getRegisterUser(string user)
        {
            string str = dal.getRegisterUser(user);

            return str;
        }

        public IEnumerable<TaskToDo> getTaskByUser(string user)
        {
            IEnumerable<TaskToDo> task = dal.getTaskByUser(user);
            return task;
        }

        public User Login(User value)
        {
            User user = dal.Login(value);
            return user;
            //DataLayer.DataLayer dal = new DataLayer.DataLayer();
            //dal.Login(value);
        }

        public bool postRegisterUser(User value)
        {
            bool bcheck = dal.postRegisterUser(value);
            return bcheck;
        }

        public bool saveMyToDoList(TaskToDo value)
        {
            bool save = dal.saveMyToDoList(value);
            return save;
        }
    }
}
