using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public class DepartmentBLL
    {

       public void Save(BO.DepartmentBO o)
       {
           DAL.DepartmentDAL dal = new DAL.DepartmentDAL();
           dal.Save(o);
       }
    }
}
