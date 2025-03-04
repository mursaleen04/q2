using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
     
            {
                Employee emp1 = new Employee(2772, "ali", "finance", 55000);
                emp1.IncreaseSalary(6000);
                emp1.DisplayEmployeeDetails();

                Employee emp2 = new Employee(5665, "tahir", "marketing", 62000);
                emp2.IncreaseSalary(8000);
                emp2.DisplayEmployeeDetails();

                Employee emp3 = new Employee(7878, "usman", "sale and purchase", 72000);
                emp3.IncreaseSalary(4000);
                emp3.DisplayEmployeeDetails();
            }
        }

    }
}
