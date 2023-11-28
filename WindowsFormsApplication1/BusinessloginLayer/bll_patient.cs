using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessloginLayer
{
    public class bll_patient
    {
        public void getting_values(string ID, string Name, string Address) 
        {
            DAL obj = new DAL();
            obj.OpenConnection();
            obj.LoadSpParameters("insert_values", ID, Name, Address);
            obj.ExecuteQuery();
            obj.UnLoadSpParameters();
            obj.CloseConnection();


        }
    }
}
