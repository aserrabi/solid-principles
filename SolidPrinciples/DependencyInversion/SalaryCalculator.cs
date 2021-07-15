namespace SolidPrinciples.DependencyInversion
{
    public class SalaryCalculator
    {
        public float CalculateSalary(int hoursWorked, float hourlyRate) => hoursWorked * hourlyRate;
    }
}