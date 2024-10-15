using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQexample
{
    class Employee
    {
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public string Job { get; set; }
        public string City { get; set; }
    }
        class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee(){EmpID=101,EmpName="Henry",Job="Designer",City="Boston"},
                new Employee(){EmpID=102,EmpName="Jack",Job="Developer",City="NewYork"},
                new Employee(){EmpID=103,EmpName="Gabriel",Job="Analyst",City="NewDelhi"},
                new Employee(){EmpID=104,EmpName="William",Job="Manager",City="Tokyo"},
                new Employee(){EmpID=105,EmpName="Henry",Job="Manager",City="NewYork"}
            };

            IEnumerable<Employee> res = employees.Where(emp => emp.City == "NewYork");
            foreach (Employee item in res)
            {
                Console.WriteLine(item.EmpID+" "+item.EmpName+" "+item.Job+" "+item.City);
            }
            Console.ReadKey();
        }
    }
}
