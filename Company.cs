using System;
using System.Collections.Generic;

namespace Employees
{
    public class Company
    {
        public Company(string name, DateTime dateCreated)
        {
            Name = name;
            CreatedOn = dateCreated;
        }
        public string Name { get; }
        public DateTime CreatedOn { get; }
        public List<Employee> EmployeeList = new List<Employee>();

        public void ListEmployees()
        {
            foreach (Employee employee in EmployeeList)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName}");
            }
        }

    }
}