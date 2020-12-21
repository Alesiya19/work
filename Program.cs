using System;
using System.Collections.Generic;

namespace Recruitment
{
    class Program
    {
        static void Main(string[] args)
        {
           
            /* try
             {
                Employee a = new Employee {Name = "dbhsj", Age = 18, Rezident = 12 };
             }
             catch(Minor ex)
             {
                Console.WriteLine($"Ошибка: {ex.Message}");
             }
             Console.Read();
            try
            {
                Employee a = new Employee { Name = "dbhsj",Rezident = 12 }; 
            }
            catch (Non_resident ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }*/

            List<Employee> workers = new List<Employee>();
            Work firm = new Work();
            Prinimaet s = new Prinimaet { Name = "Александр" };
            workers.Add(new Employee ("Иван", "иывр","Официант", (2015, 04, 02), (2019, 03, 24) ));
            Employee a1 = new Employee("Иван", "иывр", "Официант", (2015, 04, 02), (2019, 03, 24));
            firm.AddWorker(a1);
            a1.PrintExpiriense();
            a1.LastWorke();
            a1.PrintWhoPrinimaet();
            Random rdm = new Random();
            int i = rdm.Next(1,8);
            //a.LastWork = a.GetLastWork();

            //a.Print();

        }
    }
}
