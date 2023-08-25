using Cafe_Program.HR;
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
                Messages.DisplayNavigationMessage("Type menu to go back to Main Menu");
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

        public static void currentEmployeesMenuPage1(ref string choice)
        {
            Messages.DisplayTitle(Utilites.currentEmployeesMenuTitle);
            Console.WriteLine("Displaying all current employees:");
            Messages.DisplayPageMessage(1, 6);
            Messages.DisplayNavigationMessage("Type 1-6 to move between pages\nType menu to go back to Main Menu");
            Console.Write("Your input: ");
            choice = Console.ReadLine();
        }

        public static void currentEmployeesMenuPage2(ref string choice)
        {
            Messages.DisplayTitle(Utilites.currentEmployeesMenuTitle);
            Console.WriteLine("Displaying all current managers:");
            Messages.DisplayPageMessage(2, 6);
            Messages.DisplayNavigationMessage("Type 1-6 to move between pages\nType menu to go back to Main Menu");
            Console.Write("Your input: ");
            choice = Console.ReadLine();
        }

        public static void currentEmployeesMenuPage3(ref string choice)
        {
            Messages.DisplayTitle(Utilites.currentEmployeesMenuTitle);
            Console.WriteLine("Displaying all current accountants:");
            Messages.DisplayPageMessage(3, 6);
            Messages.DisplayNavigationMessage("Type 1-6 to move between pages\nType menu to go back to Main Menu");
            Console.Write("Your input: ");
            choice = Console.ReadLine();
        }

        public static void currentEmployeesMenuPage4(ref string choice)
        {
            Messages.DisplayTitle(Utilites.currentEmployeesMenuTitle);
            Console.WriteLine("Displaying all current chefs:");
            Messages.DisplayPageMessage(4, 6);
            Messages.DisplayNavigationMessage("Type 1-6 to move between pages\nType menu to go back to Main Menu");
            Console.Write("Your input: ");
            choice = Console.ReadLine();
        }

        public static void currentEmployeesMenuPage5(ref string choice)
        {
            Messages.DisplayTitle(Utilites.currentEmployeesMenuTitle);
            Console.WriteLine("Displaying all current bartenders:");
            Messages.DisplayPageMessage(5, 6);
            Messages.DisplayNavigationMessage("Type 1-6 to move between pages\nType menu to go back to Main Menu");
            Console.Write("Your input: ");
            choice = Console.ReadLine();
        }

        public static void currentEmployeesMenuPage6(ref string choice)
        {
            Messages.DisplayTitle(Utilites.currentEmployeesMenuTitle);
            Console.WriteLine("Displaying all current waitresses:");
            Messages.DisplayPageMessage(6, 6);
            Messages.DisplayNavigationMessage("Type 1-6 to move between pages\nType menu to go back to Main Menu");
            Console.Write("Your input: ");
            choice = Console.ReadLine();
        }
    }
}
