using EuroFin.DataClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace EuroFin.BusinessLayer
{
    public interface IBusinessLayer
    {
        void Login(User value);
        void getMyToDoList();
        void getTaskByUser(string user);
        void saveMyToDoList(TaskToDo value);
        void deleteMyToDoList(int id);
        void getRegisterUser(string user);
        void postRegisterUser(User value);
    }
}
