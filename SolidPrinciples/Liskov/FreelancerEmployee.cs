using System;

namespace SolidPrinciples.Liskov
{
    public class FreelancerEmployee : EmployeeBase
    {
        public override string GetProjectDetails(int employeeId)
        {
            return "Child Project";
        }
        
        public override string GetEmployeeDetails(int employeeId)
        {
            throw new NotImplementedException();
        }
    }
}