using System;
using System.Collections.Generic;
using System.Linq;
namespace Lab8d
{
    class Employee
    {
        public string Name { get; set; }
        public string Department { get; set; }
    }

    class Program
    {
        static void Main()
        {
            List<Employee> employees = new List<Employee>
        {
            new Employee { Name = "HHH", Department = "HR" },
            new Employee { Name = "Steve", Department = "IT" },
            new Employee { Name = "Warren", Department = "Finance" },
            new Employee { Name = "Bill", Department = "IT" },
            new Employee { Name = "Sundar", Department = "HR" },
            new Employee { Name = "Elon", Department = "Finance" },
            new Employee { Name = "Mark", Department = "IT" },
            new Employee { Name = "Sam", Department = "IT" },
            new Employee { Name = "Donald", Department = "Finance" },
            new Employee { Name = "John", Department = "HR" }
        };
            var groupedEmployees = from employee in employees
                                   group employee by employee.Department into departmentGroup
                                   select departmentGroup;
            Console.WriteLine("Employees grouped by department:");
            foreach (var departmentGroup in groupedEmployees)
            {
                Console.WriteLine($"\nDepartment: {departmentGroup.Key}");
                foreach (var employee in departmentGroup)
                {
                    Console.WriteLine($"- {employee.Name}");
                }
            }
        }
    }
}
