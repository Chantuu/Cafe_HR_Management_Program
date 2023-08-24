using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Program.HR
{
    internal class Manager: Employee
    {
        public Manager(string firstName, string lastName, string email, double rate, DateOnly birthDate, DateOnly hireDate, string address1, string address2, string zipcode, string city) : base(firstName, lastName, email, rate, birthDate, hireDate, address1, address2, zipcode, city)
        {

        }

        public void AttendMeeting() 
        {
            numberOfHoursWorked += 5;
            Console.WriteLine($"{FirstName} {LastName} has attended 5 hour long meeting");
        }

        public void TrainEmployees() 
        { 
            numberOfHoursWorked += 5;
            Console.WriteLine($"{FirstName} {LastName} has trained employees for 3 hours");
        }
    }
}
