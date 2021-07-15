using System;

namespace SolidPrinciples.Liskov
{
    public class RegularEmployee : EmployeeBase
    {
        public override string GetProjectDetails(int employeeId)
        {
            return "Child Project";
        }

        public override string GetEmployeeDetails(int employeeId)
        {
            return "Child Employee";
        }
    }
}