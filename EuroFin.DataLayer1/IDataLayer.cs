using System;
using System.Collections.Generic;
using System.Text;
using EuroFin.DataClasses;

namespace EuroFin.DataLayer
{
    public interface IDataLayer
    {
        void getMyToDoList();
        void deleteMyToDoList(int id);
        void getRegisterUser(string user);
        void getTaskByUser(string user);
        void Login(User value);
        void postRegisterUser(User value);
        void saveMyToDoList(TaskToDo value);
    }
}
