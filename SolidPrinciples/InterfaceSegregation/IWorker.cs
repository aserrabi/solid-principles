namespace SolidPrinciples.InterfaceSegregation
{
    public interface IWorker
    {
        string Id { get; set; }
        
        string Name { get; set; }
        
        string Email { get; set; }
        
        float MonthlySalary { get; set; }
        
        float OtherBenefits { get; set; }
        
        float HourlyRate { get; set; }
        
        float HoursInMonth { get; set; }
        
        float CalculateNetSalary();
        
        float CalculateWorkedSalary();
    }
}