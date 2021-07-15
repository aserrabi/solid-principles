namespace SolidPrinciples.Liskov
{ 
    public abstract class EmployeeBase
    {
        public virtual string GetProjectDetails(int employeeId)
        {
            return "Base Project";
        }
        
        public virtual string GetEmployeeDetails(int employeeId)
        {
            return "Base Employee";
        }
    }
}