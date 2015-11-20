using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace DAL
{
   public  class EmployeeDAL
    {
       public List<EmployeeBO> ReadData()
       {
           List<EmployeeBO> list = new List<EmployeeBO>();
           //read from file 
           FileStream fin = new FileStream("data.txt",FileMode.Open);
           StreamReader sr = new StreamReader(fin);
           string line;
          
           while((line = sr.ReadLine())!=null)
           {
               string[] data = line.Split(';');

               EmployeeBO bo = new EmployeeBO();
               bo.Name = data[0];
               bo.Age = int.Parse(data[1]);
               bo.Salary = double.Parse(data[2]);


               list.Add(bo);
           }

           

           return list;
       }

       public void Save(EmployeeBO bo)
       {
           string text = bo.Name + ";" + bo.Age + ";" + bo.Salary;
           FileStream fout = new FileStream("data.txt", FileMode.Append);
           StreamWriter sw = new StreamWriter(fout);

           sw.WriteLine(text);

           sw.Close();
           fout.Close();


      

       }
    }
}
