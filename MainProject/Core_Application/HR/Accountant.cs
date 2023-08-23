using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Program.HR
{
    internal class Accountant: Employee
    {
        public Accountant(string firstName, string lastName, string email, double rate, DateOnly birthDate, DateOnly hireDate, string address1, string address2, string zipcode, string city) : base(firstName, lastName, email, rate, birthDate, hireDate, address1, address2, zipcode, city)
        {

        }

        public Accountant(string firstName, string lastName, string email, double rate, DateOnly birthDate, DateOnly hireDate, string address1, string zipcode, string city) : base(firstName, lastName, email, rate, birthDate, hireDate, address1, zipcode, city)
        {

        }

        public void CalculateExpenses()
        {
            numberOfHoursWorked += 6;
            Console.WriteLine($"{FirstName} {LastName} has been calculating expenses for 6 hours");
        }

        public void MakeFinancialAudit()
        {
            numberOfHoursWorked += 2;
            Console.WriteLine($"{FirstName} {LastName} has been making financial audits for 2 hours");
        }
    }
}
