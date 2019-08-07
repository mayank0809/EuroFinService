using System;
using EuroFin.DataClasses;
using EuroFin.DataLayer;

namespace EuroFin.BusinessLayer
{
    public class BusinessLayer
    {
        public void Login(User1 value)
        {
            DataLayer.DataLayer dal = new DataLayer.DataLayer();
            dal.Login(value);
        }
    }
}
