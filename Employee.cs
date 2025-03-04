using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q2
{
 
  
class Employee
    {
        public int EmployeeID;
        public string Name;
        public string Department;
        public double Salary;

        public Employee(int id, string name, string department, double salary)
        {
            EmployeeID = id;
            Name = name;
            Department = department;
            Salary = salary;
        }

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine($"Employee ID = {EmployeeID}");
            Console.WriteLine($"Name = {Name}");
            Console.WriteLine($"Department = {Department}");
            Console.WriteLine($"Salary = {Salary} RUPEES");
            Console.WriteLine("---------------------------------");
        }

        public void IncreaseSalary(double amount)
        {
            Salary += amount;
        }
    }





}
