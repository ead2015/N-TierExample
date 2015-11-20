using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
//Presentation Layer
namespace Views
{
    public class EmployeeView
    {
        public void Input()
        {
            Console.Write("Enter Name = ");
            string name = Console.ReadLine();
            Console.Write("Enter Age = ");
            string age = Console.ReadLine();

            EmployeeBO bo = new EmployeeBO();
            bo.Name = name;
            bo.Age = int.Parse( age);

            EmployeeBLL employeeBll = new EmployeeBLL();

            employeeBll.Save(bo);
            Console.WriteLine("Data saved");
       
        }

        public void Display()
        {
            EmployeeBLL bll = new EmployeeBLL();

            List<EmployeeBO> list = bll.ReadAll();

            foreach (var employee in list)
            {
                Console.WriteLine("Name  =" + employee.Name);
                Console.WriteLine("Age  =" + employee.Age);
                Console.WriteLine("Salary  =" + employee.Salary);
                Console.WriteLine("------------------------------");

            }

        }
    }
}
