using System;
using System.Collections.Generic;
using System.Text;
using EuroFin.DataClasses;

namespace EuroFin.DataLayer
{
    public interface IDataLayer
    {
        IEnumerable<TaskToDo> getMyToDoList();
        bool deleteMyToDoList(int id);
        string getRegisterUser(string user);
        IEnumerable<TaskToDo> getTaskByUser(string user);
        User Login(User value);
        bool postRegisterUser(User value);
        bool saveMyToDoList(TaskToDo value);
    }
}
