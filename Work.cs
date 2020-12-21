using System;
using System.Collections.Generic;
using System.Text;

namespace Recruitment
{
    class Work
    {
        private List<Employee> workers;
        public List<Employee> Workers { get { return workers; } }//можем управлять доступом к переменной workers

        public Work(List<Employee> list)
        {
            workers = list;
        }

        public Work() 
        {
        }

        //Добавление сотрудника
        public void AddWorker(Employee worker)
        {
            workers.Add(worker);
        }
    }
}
