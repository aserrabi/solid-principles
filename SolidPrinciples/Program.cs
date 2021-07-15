using System;
using System.Collections.Generic;
using SolidPrinciples.Liskov;

namespace SolidPrinciples
{
    class Program
    {
        static void Main(string[] args)
        {
            // LISKOV Failing
            var employeeList = new List<EmployeeBase>
            {
                new FreelancerEmployee(),
                new RegularEmployee()
            };
            
            foreach (var employee in employeeList)
            {
                employee.GetEmployeeDetails(1245);
            }
        }
    }
}