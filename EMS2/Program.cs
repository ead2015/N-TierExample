using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Views;

namespace EMS2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Employee Management System");

            Console.WriteLine("To Save, press 1");
            Console.WriteLine("To Read, press 2");

            string s = Console.ReadLine();

            EmployeeView view = new EmployeeView();

            if (s == "1")
            {
                view.Input();
            }
            else if (s == "2")
            {
                view.Display();
            }
    
        }
    }
}
