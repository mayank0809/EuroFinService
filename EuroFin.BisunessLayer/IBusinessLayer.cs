using EuroFin.DataClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace EuroFin.BusinessLayer
{
    public interface IBusinessLayer
    {
        User Login(User value);
        IEnumerable<TaskToDo> getMyToDoList();
        IEnumerable<TaskToDo> getTaskByUser(string user);
        bool saveMyToDoList(TaskToDo value);
        bool deleteMyToDoList(int id);
        string getRegisterUser(string user);
        bool postRegisterUser(User value);
    }
}
