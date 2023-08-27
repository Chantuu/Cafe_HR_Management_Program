
namespace Cafe_Program.HR
{
    internal class Waitress: Employee
    {
        public Waitress(string firstName, string lastName, string email, double rate, DateOnly birthDate, DateOnly hireDate, string address1, string address2, string zipcode, string city) : base(firstName, lastName, email, rate, birthDate, hireDate, address1, address2, zipcode, city)
        {

        }

        public void CleanTables(int tableCount=20)
        {
            numberOfHoursWorked += (int)tableCount / 20;
            Console.WriteLine($"{FirstName} {LastName} has cleaned {tableCount} tables in {(int)tableCount / 20} hour(s)");
        }
    }
}
