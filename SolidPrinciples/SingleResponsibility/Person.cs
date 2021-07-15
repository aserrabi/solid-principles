namespace SolidPrinciples.SR
{
    public class Person
    {
        public int PersonId { get; set; }
        public string PersonName { get; set; }

        public bool InsertPerson(Person person)
        {
            // Insert person in a database table.
            return true;
        }
        
        public void GenerateReport(Person person)
        {
          // Generate report
        }
    }
}