﻿using Cafe_Program.HR;
using Cafe_Program.Misc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Program.App
{
    internal class Processes
    {
        public static void AddNewEmployeeProcess(EmployeeSelection selection)
        {
            Messages.DisplayTitle(Utilites.newEmployeeMenuTitle);
            Console.Write("Please input new employee name: ");
            string name = Console.ReadLine();

            Console.Write("Please input new employee surname: ");
            string surname = Console.ReadLine();

            Console.Write("Please input new employee email: ");
            string email = Console.ReadLine();

            Console.Write("Please input new employee rate: ");
            try
            {
                double rate = Double.Parse(Console.ReadLine());

                Console.Write("Please input employee birth date in 'MM/DD/YYYY' format: ");
                try
                {
                    DateOnly birthDate = DateOnly.Parse(Console.ReadLine());
                    DateOnly hireDate = DateOnly.FromDateTime(DateTime.Now);

                    Console.Write("Please input 1st street address of new employee: ");
                    string address1 = Console.ReadLine();

                    Console.Write("Please input 2nd street address of new employee (Press enter, if it is not available): ");
                    string address2 = Console.ReadLine();

                    Console.Write("Please input zipcode of new employee: ");
                    string zipcode = Console.ReadLine();

                    Console.Write("Please input city of new employee: ");
                    string city = Console.ReadLine();

                    switch (selection)
                    {
                        case EmployeeSelection.manager:
                            Utilites.managers.Add(new Manager(name, surname, email, rate, birthDate, hireDate, address1, address2, zipcode, city));
                            break;

                        case EmployeeSelection.accountant:
                            Utilites.accoutants.Add(new Accountant(name, surname, email, rate, birthDate, hireDate, address1, address2, zipcode, city));
                            break;

                        case EmployeeSelection.chef:
                            Utilites.chefs.Add(new Chef(name, surname, email, rate, birthDate, hireDate, address1, address2, zipcode, city));
                            break;

                        case EmployeeSelection.bartender:
                            Utilites.bartenders.Add(new Bartender(name, surname, email, rate, birthDate, hireDate, address1, address2, zipcode, city));
                            break;

                        case EmployeeSelection.waitress:
                            Utilites.waitresses.Add(new Waitress(name, surname, email, rate, birthDate, hireDate, address1, address2, zipcode, city));
                            break;

                    }

                    Messages.DisplaySuccessMessage("New employee has been successfully added to application!");

                }
                catch (FormatException ex)
                {
                    Messages.DisplayErrorMessage(ex.Message);
                }
                catch (Exception ex)
                {
                    Messages.DisplayErrorMessage(ex.Message);
                }

            }
            catch (FormatException ex)
            {
                Messages.DisplayErrorMessage(ex.Message);
            }
            catch (Exception ex)
            {
                Messages.DisplayErrorMessage(ex.Message);
            }
        }

        public static void currentEmployeesMenuChoiceProcess()
        {
            string userInput = "";
            string currentPage = "1";

            Menus.currentEmployeesMenuPage1(ref userInput);

            do
            {
                switch (userInput)
                {
                    case "1":
                        Console.Clear();
                        currentPage = userInput;
                        Menus.currentEmployeesMenuPage1(ref userInput);
                        break;

                    case "2":
                        Console.Clear();
                        currentPage = userInput;
                        Menus.currentEmployeesMenuPage2(ref userInput);
                        break;

                    case "3":
                        Console.Clear();
                        currentPage = userInput;
                        Menus.currentEmployeesMenuPage3(ref userInput);
                        break;

                    case "4":
                        Console.Clear();
                        currentPage = userInput;
                        Menus.currentEmployeesMenuPage4(ref userInput);
                        break;

                    case "5":
                        Console.Clear();
                        currentPage = userInput;
                        Menus.currentEmployeesMenuPage5(ref userInput);
                        break;

                    case "6":
                        Console.Clear();
                        currentPage = userInput;
                        Menus.currentEmployeesMenuPage6(ref userInput);
                        break;

                    case "menu":
                        break;

                    default:
                        Messages.DisplayErrorMessage("Incorrect Input! Please try again!");

                        switch (currentPage)
                        {
                            case "1":
                                Menus.currentEmployeesMenuPage1(ref userInput);
                                break;

                            case "2":
                                Menus.currentEmployeesMenuPage2(ref userInput);
                                break;

                            case "3":
                                Menus.currentEmployeesMenuPage3(ref userInput);
                                break;

                            case "4":
                                Menus.currentEmployeesMenuPage4(ref userInput);
                                break;

                            case "5":
                                Menus.currentEmployeesMenuPage5(ref userInput);
                                break;

                            case "6":
                                Menus.currentEmployeesMenuPage6(ref userInput);
                                break;
                        }

                        break;
                }
            }
            while (userInput != "menu");
        }

        public static void listAllEmployeesProcess(EmployeeSelection filter)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;

            switch (filter)
            {
                case EmployeeSelection.manager:
                    if (Utilites.managers.Count == 0)
                    {
                        Messages.DisplayListWarningMessage("There are not any manager employees");
                    }
                    else
                    {
                        foreach (Manager manager in Utilites.managers)
                        {
                            manager.DisplayShortInfo();
                        }
                    }
                    break;

                case EmployeeSelection.accountant:
                    if (Utilites.accoutants.Count == 0)
                    {
                        Messages.DisplayListWarningMessage("There are not any accountant employees");
                    }
                    else
                    {
                        foreach (Accountant accountant in Utilites.accoutants)
                        {
                            accountant.DisplayShortInfo();
                        }
                    }
                    break;

                case EmployeeSelection.chef:
                    if (Utilites.chefs.Count == 0)
                    {
                        Messages.DisplayListWarningMessage("There are not any chef employees");
                    }
                    else
                    {
                        foreach (Chef chef in Utilites.chefs)
                        {
                            chef.DisplayShortInfo();
                        }
                    }
                    break;

                case EmployeeSelection.bartender:
                    if (Utilites.bartenders.Count == 0)
                    {
                        Messages.DisplayListWarningMessage("There are not any bartender employees");
                    }
                    else
                    {
                        foreach (Bartender bartender in Utilites.bartenders)
                        {
                            bartender.DisplayShortInfo();
                        }
                    }
                    break;

                case EmployeeSelection.waitress:
                    if (Utilites.waitresses.Count == 0)
                    {
                        Messages.DisplayListWarningMessage("There are not any waitress employees");
                    }
                    else
                    {
                        foreach (Waitress waitress in Utilites.waitresses)
                        {
                            waitress.DisplayShortInfo();
                        }
                    }
                    break;

                case EmployeeSelection.all:
                    if (Utilites.managers.Count == 0 && Utilites.accoutants.Count == 0 && Utilites.chefs.Count == 0 && Utilites.bartenders.Count == 00 && Utilites.waitresses.Count == 0)
                    {
                        Messages.DisplayListWarningMessage("There are not any current employees");
                    }
                    else
                    {
                        foreach (Manager manager in Utilites.managers)
                        {
                            manager.DisplayShortInfo();
                        }

                        foreach (Accountant accountant in Utilites.accoutants)
                        {
                            accountant.DisplayShortInfo();
                        }

                        foreach (Chef chef in Utilites.chefs)
                        {
                            chef.DisplayShortInfo();
                        }

                        foreach (Bartender bartender in Utilites.bartenders)
                        {
                            bartender.DisplayShortInfo();
                        }

                        foreach (Waitress waitress in Utilites.waitresses)
                        {
                            waitress.DisplayShortInfo();
                        }
                    }
                    break;
            }

            Console.ResetColor();
        }
    }
}
