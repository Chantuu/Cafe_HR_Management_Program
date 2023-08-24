using Cafe_Program.Misc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Program.App
{
    internal class Menus
    {
        public static string MainMenu()
        {
            Messages.DisplayTitle(Utilites.mainMenuTitle);

            Console.WriteLine("1. Add New Employee");
            Console.WriteLine("2. Employee Operations");
            Console.WriteLine("3. Financial Data");
            Console.WriteLine("4. View Current Employees");
            Console.WriteLine("5. Remove Employee");
            Console.WriteLine("6. Save To File");
            Console.WriteLine("7. About Application");
            Console.WriteLine("8. Exit Application");
            Console.WriteLine();
            Console.Write("Your input: ");

            string userInput = Console.ReadLine();
            return userInput;
        }

        public static void NewEmployeeMenu()
        {
            string userInput;

            do
            {
                Messages.DisplayTitle(Utilites.newEmployeeMenuTitle);
                Console.WriteLine("Please select role for new Employee:");
                Console.WriteLine("1. Manager");
                Console.WriteLine("2. Accountant");
                Console.WriteLine("3. Chef");
                Console.WriteLine("4. Bartender");
                Console.WriteLine("5. Waitress");
                Messages.DisplayBackMessage();
                Console.Write("Your input: ");

                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        Console.Clear();
                        Processes.AddNewEmployeeProcess(EmployeeSelection.manager);
                        break;

                    case "2":
                        Console.Clear();
                        Processes.AddNewEmployeeProcess(EmployeeSelection.accountant);
                        break;

                    case "3":
                        Console.Clear();
                        Processes.AddNewEmployeeProcess(EmployeeSelection.chef);
                        break;

                    case "4":
                        Console.Clear();
                        Processes.AddNewEmployeeProcess(EmployeeSelection.bartender);
                        break;

                    case "5":
                        Console.Clear();
                        Processes.AddNewEmployeeProcess(EmployeeSelection.waitress);
                        break;

                    case "menu":
                        break;

                    default:
                        Messages.DisplayErrorMessage("Incorrect Input! Please Try again!");
                        break;
                }
            }
            while (userInput != "menu");

        }
    }
}
