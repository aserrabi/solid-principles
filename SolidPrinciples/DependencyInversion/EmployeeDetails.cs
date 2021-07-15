namespace SolidPrinciples.DependencyInversion
{
    public class EmployeeDetails
    {
        public int HoursWorked { get; set; }
        
        public int HourlyRate { get; set; }
        
        public float GetSalary()
        {  
            var salaryCalculator = new SalaryCalculator();
            return salaryCalculator.CalculateSalary(HoursWorked, HourlyRate);
        }  
    }
}