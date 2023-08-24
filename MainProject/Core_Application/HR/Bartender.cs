using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Program.HR
{
    internal class Bartender: Employee
    {
        public Bartender(string firstName, string lastName, string email, double rate, DateOnly birthDate, DateOnly hireDate, string address1, string address2, string zipcode, string city) : base(firstName, lastName, email, rate, birthDate, hireDate, address1, address2, zipcode, city)
        {

        }

        public void MakeDrink()
        {
            string[] drinks = new string[7] { "Margarita", "Martini", "Old Fashioned", "Mimosa", "Moscow Mule", "Cosmopolitan", "Bloody Mary" };
            Random rndm = new Random();

            Console.WriteLine($"{FirstName} {LastName} has made {drinks[rndm.Next(7)]}");
        }
    }
}
