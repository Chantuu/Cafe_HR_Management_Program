
namespace Cafe_Program.HR
{
    internal class Chef: Employee
    {
        public Chef(string firstName, string lastName, string email, double rate, DateOnly birthDate, DateOnly hireDate, string address1, string address2, string zipcode, string city) : base(firstName, lastName, email, rate, birthDate, hireDate, address1, address2, zipcode, city)
        {

        }

        public void MakeMeal()
        {
            numberOfHoursWorked += 1;
            Console.WriteLine($"{FirstName} {LastName} has made delicios meal in 1 hour");
        }

        public void FindNewTastes()
        {
            Random rnd = new Random();
            int result = rnd.Next(0, 1);

            if (result == 0 )
            {
                Console.WriteLine($"{FirstName} {LastName} is still working on new taste");
            } 
            else if (result == 1 )
            {
                Console.WriteLine($"{FirstName} {LastName} has found new taste");
            }
        }
    }
}
