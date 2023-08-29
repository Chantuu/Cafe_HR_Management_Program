using Cafe_Program.HR;
using Cafe_Program.Misc;

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

            string userInput = Processes.ReturnUserInputProcess();
            return userInput;
        }

        public static void EmployeeOperationsMenu()
        {
            string userInput;

            do
            {
                Messages.DisplayTitle(Utilites.currentEmployeesMenuTitle);
                Console.WriteLine("Choose which type of employee do you want to select:");
                Processes.DisplayAllEmployeeTypesProcess();
                Messages.DisplayNavigationMessage("Type menu to go back to Main Menu");
                
                userInput = Processes.ReturnUserInputProcess();

                switch (userInput)
                {
                    case "1":
                        Console.Clear();
                        EmployeeOperationsMenuTypeSelection(EmployeeSelection.manager);
                        break;

                    case "2":
                        Console.Clear();
                        EmployeeOperationsMenuTypeSelection(EmployeeSelection.accountant);
                        break;

                    case "3":
                        Console.Clear();
                        EmployeeOperationsMenuTypeSelection(EmployeeSelection.chef);
                        break;

                    case "4":
                        Console.Clear();
                        EmployeeOperationsMenuTypeSelection(EmployeeSelection.bartender);
                        break;

                    case "5":
                        Console.Clear();
                        EmployeeOperationsMenuTypeSelection(EmployeeSelection.waitress);
                        break;

                    case "menu":
                        break;

                    default:
                        Messages.DisplayErrorMessage("Incorrect Input! Please try again!");
                        break;
                }
            }
            while (userInput != "menu");  
        }

        public static void EmployeeOperationsMenuTypeSelection(EmployeeSelection selection)
        {
            string userInput;

            do
            {
                Messages.DisplayTitle(Utilites.employeeOperationsMenuTitle);
                Console.WriteLine("Please select desired employee: ");

                Processes.ListEmployeeTypeBasedIndexedProcess(selection);

                Messages.DisplayNavigationMessage("Type back to go back");
                userInput = Processes.ReturnUserInputProcess();

                switch (userInput)
                {
                    case "back":
                        Console.Clear();
                        break;

                    default:
                        try
                        {
                            int userChoice = int.Parse(userInput);

                            Processes.ChooseEmployeeAndMenuProcess(selection, userChoice, MenuSelection.employeeOperationsMenu);
                        }
                        catch (Exception e)
                        {
                            Messages.DisplayErrorMessage(e.Message);
                        }
                        break;
                }
            }
            while (userInput != "back");
        }
        
        public static void EmployeeOperationsMenuSelectedEmployee(EmployeeSelection selection, int employeeIndex)
        {
            string userInput;

            do
            {
                Messages.DisplayTitle(Utilites.employeeOperationsMenuTitle);
                Console.WriteLine("Which operation do you want to perform?");
                Processes.DisplayCommonEmployeeOpeartionsProcess();

                switch (selection)
                {
                    case EmployeeSelection.manager:
                        Processes.DisplayManagerOpeartionsProcess(5);
                        break;

                    case EmployeeSelection.accountant:
                        Processes.DisplayAccountantOpeartionsProcess(5);
                        break;

                    case EmployeeSelection.chef:
                        Processes.DisplayChefOpeartionsProcess(5);
                        break;

                    case EmployeeSelection.bartender:
                        Processes.DisplayBartenderOpeartionsProcess(5);
                        break;

                    case EmployeeSelection.waitress:
                        Processes.DisplayWaitressOpeartionsProcess(5);
                        break;
                }

                Messages.DisplayNavigationMessage("Type back to go back");
                userInput = Processes.ReturnUserInputProcess();

                switch (userInput)
                {
                    case "back":
                        Console.Clear();
                        break;

                    default:
                        try
                        {
                            int userChoice = int.Parse(userInput);

                            switch (selection)
                            {
                                case EmployeeSelection.manager:
                                    if (userChoice > 0 && userChoice <= 6)
                                    {
                                        Console.Clear();
                                        EmployeeOperationsMenuResults(selection, employeeIndex, userChoice);
                                    }
                                    else
                                    {
                                        Messages.DisplayErrorMessage("Incorrect choice! Please try again!");
                                    }
                                    break;

                                case EmployeeSelection.accountant:
                                    if (userChoice > 0 && userChoice <= 6)
                                    {
                                        Console.Clear();
                                        EmployeeOperationsMenuResults(selection, employeeIndex, userChoice);
                                    }
                                    else
                                    {
                                        Messages.DisplayErrorMessage("Incorrect choice! Please try again!");
                                    }
                                    break;

                                case EmployeeSelection.chef:
                                    if (userChoice > 0 && userChoice <= 6)
                                    {
                                        Console.Clear();
                                        EmployeeOperationsMenuResults(selection, employeeIndex, userChoice);
                                    }
                                    else
                                    {
                                        Messages.DisplayErrorMessage("Incorrect choice! Please try again!");
                                    }
                                    break;

                                case EmployeeSelection.bartender:
                                    if (userChoice > 0 && userChoice <= 5)
                                    {
                                        Console.Clear();
                                        EmployeeOperationsMenuResults(selection, employeeIndex, userChoice);
                                    }
                                    else
                                    {
                                        Messages.DisplayErrorMessage("Incorrect choice! Please try again!");
                                    }
                                    break;

                                case EmployeeSelection.waitress:
                                    if (userChoice > 0 && userChoice <= 5)
                                    {
                                        Console.Clear();
                                        EmployeeOperationsMenuResults(selection, employeeIndex, userChoice);
                                    }
                                    else
                                    {
                                        Messages.DisplayErrorMessage("Incorrect choice! Please try again!");
                                    }
                                    break;
                            }
                        }
                        catch (Exception ex)
                        {
                            Messages.DisplayErrorMessage(ex.Message);
                        }
                        break;
                }
            }
            while (userInput != "back");
        }

        public static void EmployeeOperationsMenuResults(EmployeeSelection selection, int employeeIndex, int operationChoice)
        {
            Messages.DisplayTitle(Utilites.employeeOperationsMenuTitle);

            switch (selection)
            {
                case EmployeeSelection.manager:
                    Manager manager = Utilites.managers[employeeIndex];

                    if (operationChoice >= 1 && operationChoice <= 4)
                    {
                        Processes.PerformCommonEmployeeOperationsProcess(manager, operationChoice);
                    }
                    else if (operationChoice == 5)
                    {
                        manager.AttendMeeting();
                    }
                    else if (operationChoice == 6)
                    {
                        manager.TrainEmployees();
                    }

                    break;

                case EmployeeSelection.accountant:
                    Accountant accountant = Utilites.accoutants[employeeIndex];

                    if (operationChoice >= 1 && operationChoice <= 4)
                    {
                        Processes.PerformCommonEmployeeOperationsProcess(accountant, operationChoice);
                    }
                    else if (operationChoice == 5)
                    {
                        accountant.CalculateExpenses();
                    }
                    else if (operationChoice == 6)
                    {
                        accountant.MakeFinancialAudit();
                    }

                    break;

                case EmployeeSelection.chef:
                    Chef chef = Utilites.chefs[employeeIndex];

                    if (operationChoice >= 1 && operationChoice <= 4)
                    {
                        Processes.PerformCommonEmployeeOperationsProcess(chef, operationChoice);
                    }
                    else if (operationChoice == 5)
                    {
                        chef.MakeMeal();
                    }
                    else if (operationChoice == 6)
                    {
                        chef.FindNewTastes();
                    }

                    break;

                case EmployeeSelection.bartender:
                    Bartender bartender = Utilites.bartenders[employeeIndex];

                    if (operationChoice >= 1 && operationChoice <= 4)
                    {
                        Processes.PerformCommonEmployeeOperationsProcess(bartender, operationChoice);
                    }
                    else if (operationChoice == 5)
                    {
                        bartender.MakeDrink();
                    }


                    break;

                case EmployeeSelection.waitress:
                    Waitress waitress = Utilites.waitresses[employeeIndex];

                    if (operationChoice >= 1 && operationChoice <= 4)
                    {
                        Processes.PerformCommonEmployeeOperationsProcess(waitress, operationChoice);
                    }
                    else if (operationChoice == 5)
                    {
                        Console.Write("Input how many tables have been cleaned (Press enter for 20 tables): ");
                        string userInput = Console.ReadLine();

                        try
                        {
                            if (userInput == "")
                            {
                                waitress.CleanTables();
                            }
                            else
                            {
                                waitress.CleanTables(int.Parse(userInput));
                            }
                        }
                        catch (Exception ex)
                        {
                            Messages.DisplayErrorMessage(ex.Message);
                        }
                    }

                    break;
            }

            Messages.DisplayNavigationMessage("Press enter to go back!");
            Console.ReadLine();
            Console.Clear();
        }

        public static void NewEmployeeMenu()
        {
            string userInput;

            do
            {
                Messages.DisplayTitle(Utilites.newEmployeeMenuTitle);
                Console.WriteLine("Please select role for new Employee:");
                Processes.DisplayAllEmployeeTypesProcess();
                Messages.DisplayNavigationMessage("Type menu to go back to Main Menu");

                userInput = Processes.ReturnUserInputProcess();

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

        public static void CurrentEmployeesMenuPage1(ref string choice)
        {
            Messages.DisplayTitle(Utilites.currentEmployeesMenuTitle);
            Console.WriteLine("Displaying all current employees:");
            Processes.ListEmployeesNoIndexedProcess(EmployeeSelection.all);
            Messages.DisplayPageMessage(1, 6);
            Messages.DisplayNavigationMessage("Type 1-6 to move between pages\nType menu to go back to Main Menu");
            choice = Processes.ReturnUserInputProcess();
        }

        public static void CurrentEmployeesMenuPage2(ref string choice)
        {
            Messages.DisplayTitle(Utilites.currentEmployeesMenuTitle);
            Console.WriteLine("Displaying all current managers:");
            Processes.ListEmployeesNoIndexedProcess(EmployeeSelection.manager);
            Messages.DisplayPageMessage(2, 6);
            Messages.DisplayNavigationMessage("Type 1-6 to move between pages\nType menu to go back to Main Menu");
            choice = Processes.ReturnUserInputProcess();
        }

        public static void CurrentEmployeesMenuPage3(ref string choice)
        {
            Messages.DisplayTitle(Utilites.currentEmployeesMenuTitle);
            Console.WriteLine("Displaying all current accountants:");
            Processes.ListEmployeesNoIndexedProcess(EmployeeSelection.accountant);
            Messages.DisplayPageMessage(3, 6);
            Messages.DisplayNavigationMessage("Type 1-6 to move between pages\nType menu to go back to Main Menu");
            choice = Processes.ReturnUserInputProcess();
        }

        public static void CurrentEmployeesMenuPage4(ref string choice)
        {
            Messages.DisplayTitle(Utilites.currentEmployeesMenuTitle);
            Console.WriteLine("Displaying all current chefs:");
            Processes.ListEmployeesNoIndexedProcess(EmployeeSelection.chef);
            Messages.DisplayPageMessage(4, 6);
            Messages.DisplayNavigationMessage("Type 1-6 to move between pages\nType menu to go back to Main Menu");
            choice = Processes.ReturnUserInputProcess();
        }

        public static void CurrentEmployeesMenuPage5(ref string choice)
        {
            Messages.DisplayTitle(Utilites.currentEmployeesMenuTitle);
            Console.WriteLine("Displaying all current bartenders:");
            Processes.ListEmployeesNoIndexedProcess(EmployeeSelection.bartender);
            Messages.DisplayPageMessage(5, 6);
            Messages.DisplayNavigationMessage("Type 1-6 to move between pages\nType menu to go back to Main Menu");
            choice = Processes.ReturnUserInputProcess();
        }

        public static void CurrentEmployeesMenuPage6(ref string choice)
        {
            Messages.DisplayTitle(Utilites.currentEmployeesMenuTitle);
            Console.WriteLine("Displaying all current waitresses:");
            Processes.ListEmployeesNoIndexedProcess(EmployeeSelection.waitress);
            Messages.DisplayPageMessage(6, 6);
            Messages.DisplayNavigationMessage("Type 1-6 to move between pages\nType menu to go back to Main Menu");
            choice = Processes.ReturnUserInputProcess();
        }

        public static void RemoveEmployeeMenu()
        {
            string userInput;

            do
            {
                Messages.DisplayTitle(Utilites.removeEmployeesMenuTitle);
                Console.WriteLine("Please select which type of employee do you want to remove:");
                Processes.DisplayAllEmployeeTypesProcess();
                Messages.DisplayNavigationMessage("Type menu to go back to Main Menu");
                userInput = Processes.ReturnUserInputProcess();

                switch (userInput)
                {
                    case "1":
                        Console.Clear();
                        RemoveEmployeeMenuTypeSelection(EmployeeSelection.manager);
                        break;

                    case "2":
                        Console.Clear();
                        RemoveEmployeeMenuTypeSelection(EmployeeSelection.accountant);
                        break;

                    case "3":
                        Console.Clear();
                        RemoveEmployeeMenuTypeSelection(EmployeeSelection.chef);
                        break;

                    case "4":
                        Console.Clear();
                        RemoveEmployeeMenuTypeSelection(EmployeeSelection.bartender);
                        break;

                    case "5":
                        Console.Clear();
                        RemoveEmployeeMenuTypeSelection(EmployeeSelection.waitress);
                        break;

                    case "menu":
                        break;

                    default:
                        Messages.DisplayErrorMessage("Incorrect Input! Please try again!");
                        break;
                }
            }
            while (userInput != "menu");
        }

        public static void RemoveEmployeeMenuTypeSelection(EmployeeSelection selection)
        {
            string userInput;

            do
            {
                Messages.DisplayTitle(Utilites.removeEmployeesMenuTitle);
                Console.WriteLine("Please select desired employee to remove: ");

                Processes.ListEmployeeTypeBasedIndexedProcess(selection);

                Messages.DisplayNavigationMessage("Type back to go back");
                userInput = Processes.ReturnUserInputProcess();

                switch (userInput)
                {
                    case "back":
                        Console.Clear();
                        break;

                    default:
                        try
                        {
                            int userChoice = int.Parse(userInput);
                            Processes.ChooseEmployeeAndMenuProcess(selection, userChoice, MenuSelection.removeEmployeeMenu);
                        }
                        catch (Exception e)
                        {
                            Messages.DisplayErrorMessage(e.Message);
                        }
                        break;
                }
            }
            while (userInput != "back");
        }

        public static void RemoveEmployeeMenuConfirming(EmployeeSelection selection, int employeeIndex)
        {
            string userInput;

            do
            {
                Messages.DisplayTitle(Utilites.removeEmployeesMenuTitle);
                Console.WriteLine("This action can not be undone!\nAre you sure, You want to remove this employee?");

                Messages.DisplayNavigationMessage("Type yes to continue, no to cancel");
                userInput = Processes.ReturnUserInputProcess();

                if (userInput == "yes")
                {
                    switch (selection)
                    {
                        case EmployeeSelection.manager:
                            Utilites.managers.RemoveAt(employeeIndex);
                            break;

                        case EmployeeSelection.accountant:
                            Utilites.accoutants.RemoveAt(employeeIndex);
                            break;

                        case EmployeeSelection.chef:
                            Utilites.chefs.RemoveAt(employeeIndex);
                            break;

                        case EmployeeSelection.bartender:
                            Utilites.bartenders.RemoveAt(employeeIndex);
                            break;

                        case EmployeeSelection.waitress:
                            Utilites.waitresses.RemoveAt(employeeIndex);
                            break;
                    }

                    Messages.DisplaySuccessMessage("Successfully removed employee");
                    break;
                }
                else if (userInput == "no")
                {
                    Messages.DisplayInformationMessage("Operation has been cancelled by user");
                }
                else
                {
                    Messages.DisplayErrorMessage("Incorrect Input! Please try again!");
                }
                
            }
            while (userInput != "no");
        }

        public static void AboutMenu()
        {
            string userInput;

            do
            {
                Messages.DisplayTitle(Utilites.aboutMenuTitle);
                Console.WriteLine("This project was created for demonstrating");
                Console.WriteLine("my skills in C# and testing myself in");
                Console.WriteLine("using all my skills and knownledge.");
                Console.WriteLine();
                Console.WriteLine("I hope you have liked my project and");
                Console.WriteLine("don't forget to check out others on");
                Console.WriteLine("my GitHub profile!");
                Messages.DisplayNavigationMessage("Type menu to go back to Main Menu");
                userInput= Processes.ReturnUserInputProcess();

                switch (userInput)
                {
                    case "menu":
                        break;

                    default:
                        Messages.DisplayErrorMessage("Incorrect input! Please try again!");
                        break;
                }
            }
            while (userInput != "menu");
        }
    }
}
