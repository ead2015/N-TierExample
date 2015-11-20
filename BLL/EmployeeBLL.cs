using BO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public class EmployeeBLL
    {
       public void Save(EmployeeBO bo)
       { 
           //salary calculate 
           if (bo.Age < 20)
           {
               bo.Salary = 40000;
           }
           else {
               bo.Salary = 80000;
           }
           EmployeeDAL dal = new EmployeeDAL();
           dal.Save(bo);
       
       }

       public List<EmployeeBO> ReadAll()
       {
           EmployeeDAL dal = new EmployeeDAL();
           return dal.ReadData();

       }


    }
}
