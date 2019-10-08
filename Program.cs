using System;
using System.Collections.Generic;


namespace Employees
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Now;
            Company google = new Company("Google", today);

            Employee bud = new Employee() {
                FirstName = "Bud",
                LastName = "Mud",
                Title = "HR Rep",
                StartDate = today
            };
            google.EmployeeList.Add(bud);

            Employee ted = new Employee() {
                FirstName = "Ted",
                LastName = "Bread",
                Title = "Quabbity Assuance",
                StartDate = today
            };
            google.EmployeeList.Add(ted);

            Employee vlad = new Employee() {
                FirstName = "Vlad",
                LastName = "Plaid",
                Title = "World's Best Boss",
                StartDate = today
            };
            google.EmployeeList.Add(vlad);

            google.ListEmployees();
        }
    }
}
