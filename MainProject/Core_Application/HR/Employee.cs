using Cafe_Program.Misc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Program.HR
{
    internal class Employee
    {
        private string firstName;
        private string lastName;
        private string email;

        private double rate;
        private Address address;

        private DateOnly birthDate;
        private DateOnly hireDate;

        protected int numberOfHoursWorked;
        protected int bonusCount;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public Address Address
        {
            get { return address; }
            set {  address = value; }
        }

        public DateOnly BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }
        }

        public DateOnly HireDate
        {
            get { return hireDate; }
            set { hireDate = value; }
        }

        public double Rate
        {
            get { return rate; }
            protected set { rate = value; }
        }

        public Employee(string firstName, string lastName, string email, double rate, DateOnly birthDate, DateOnly hireDate, string address1, string address2, string zipcode, string city) 
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Rate = rate;
            BirthDate = birthDate;
            HireDate = hireDate;

            Address = new Address(address1, address2, zipcode, city);
        }

        public virtual void PerformWork(int numberOfHours)
        {
            numberOfHoursWorked = numberOfHours;
            Console.WriteLine($"{FirstName} {LastName} has totally worked for {numberOfHoursWorked}(s)");
        }

        public virtual void GiveBonus(int bonus=10)
        {
            bonusCount += bonus;
            Console.WriteLine($"{FirstName} {LastName} has been given bonus of {bonus}$");
        }

        public virtual void GiveWage()
        {
            double wage = (Rate * numberOfHoursWorked) + bonusCount;
            Console.WriteLine($"{FirstName} {LastName} has been given wage of {wage}$");
        }

        public virtual void DisplayShortInfo()
        {
            Console.WriteLine($"{FirstName} {LastName} - {Rate}$ - {HireDate.ToString()}\n");
        }

        public virtual string ReturnShortInfo()
        {
            return $"{FirstName} {LastName} - {Rate}$ - {HireDate.ToString()}";
        }

        public virtual void DisplayFullInfo()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}\nEmail: {Email}\nRate: {Rate}\nBirth Date: {BirthDate}\nHire Date: {HireDate}\n");
            Address.Display();
        }
    }
}
