using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Program.Misc
{
    internal struct Address
    {
        private string address_1;
        private string address_2;

        private string zipcode;
        private string city;

        public string Address_1 
        { 
            get { return address_1; } 
            set {  address_1 = value; } 
        }

        public string Address_2
        {
            get { return address_2; }
            set { address_2 = value; }
        }

        public string Zipcode
        {
            get { return zipcode; }
            set { zipcode = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public Address(string address1, string address2, string zipcode, string city)
        {
            Address_1 = address1;
            Address_2 = address2;
            Zipcode = zipcode;
            City = city;
        }

        public Address(string address1, string zipcode, string city) : this(address1, "", zipcode, city)
        {

        }

        public void Display()
        {
            if (Address_2 == "")
            {
                Console.WriteLine($"Main address: {Address_1}\nZip Code: {Zipcode}\nCity: {City}");
            }
            else
            {
                Console.WriteLine($"Main address: {Address_1}\nSecondary address: {Address_2}\nZip Code: {Zipcode}\nCity: {City}");
            }          
        }
    }
}
