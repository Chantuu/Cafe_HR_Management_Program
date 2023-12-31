﻿using Cafe_Program.HR;
using Cafe_Program.Misc;
using System.Text;

namespace Cafe_Program.App
{
    internal class Processes
    {
        public static void AddNewEmployeeProcess(EmployeeSelection selection)
        {
            Messages.DisplayTitle(Utilities.newEmployeeMenuTitle);
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

                Console.Write("Please input employee birth date in 'DD/MM/YYYY' format: ");
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
                            Utilities.managers.Add(new Manager(name, surname, email, rate, birthDate, hireDate, address1, address2, zipcode, city));
                            break;

                        case EmployeeSelection.accountant:
                            Utilities.accoutants.Add(new Accountant(name, surname, email, rate, birthDate, hireDate, address1, address2, zipcode, city));
                            break;

                        case EmployeeSelection.chef:
                            Utilities.chefs.Add(new Chef(name, surname, email, rate, birthDate, hireDate, address1, address2, zipcode, city));
                            break;

                        case EmployeeSelection.bartender:
                            Utilities.bartenders.Add(new Bartender(name, surname, email, rate, birthDate, hireDate, address1, address2, zipcode, city));
                            break;

                        case EmployeeSelection.waitress:
                            Utilities.waitresses.Add(new Waitress(name, surname, email, rate, birthDate, hireDate, address1, address2, zipcode, city));
                            break;

                    }

                    Messages.DisplaySuccessMessage(Utilities.employeeAdditionSuccessMessage);

                }
                catch (Exception ex)
                {
                    Messages.DisplayErrorMessage(ex.Message);
                }

            }
            catch (Exception ex)
            {
                Messages.DisplayErrorMessage(ex.Message);
            }
        }

        public static void DisplayCommonEmployeeOpeartionsProcess(int startIndex=1)
        {
            string[] menuItems = new string[4] {"Perform Work", "Give Bonus", "Give Wage", "Display Full Information"};

            foreach (string item in menuItems)
            {
                Console.WriteLine($"{startIndex}. {item}");
                startIndex += 1;
            }
        }

        public static void DisplayManagerOpeartionsProcess(int startIndex = 1)
        {
            string[] menuItems = new string[2] { "Attend Meeting", "Train Employees"};

            foreach (string item in menuItems)
            {
                Console.WriteLine($"{startIndex}. {item}");
                startIndex += 1;
            }
        }

        public static void DisplayAccountantOpeartionsProcess(int startIndex = 1)
        {
            string[] menuItems = new string[2] { "Calculate Expenses", "Make Financial Audits" };

            foreach (string item in menuItems)
            {
                Console.WriteLine($"{startIndex}. {item}");
                startIndex += 1;
            }
        }

        public static void DisplayChefOpeartionsProcess(int startIndex = 1)
        {
            string[] menuItems = new string[2] { "Make Meal", "Find New Tastes" };

            foreach (string item in menuItems)
            {
                Console.WriteLine($"{startIndex}. {item}");
                startIndex += 1;
            }
        }

        public static void DisplayBartenderOpeartionsProcess(int index = 1)
        {
            Console.WriteLine($"{index}. Make Drink");
        }

        public static void DisplayWaitressOpeartionsProcess(int index = 1)
        {
            Console.WriteLine($"{index}. Clean Tables");
        }

        public static void ListEmployeesIndexedProcess(EmployeeSelection choice)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            int startIndex = 1;

            switch (choice)
            {
                case EmployeeSelection.manager:
                    if (Utilities.managers.Count == 0)
                    {
                        Messages.DisplayListWarningMessage(Utilities.noManagerInListMessage);
                    }
                    else
                    {
                        foreach (Manager manager in Utilities.managers)
                        {
                            Console.WriteLine($"{startIndex}. {manager.ReturnShortInfo()}");
                            startIndex += 1;
                        }
                    }
                    break;

                case EmployeeSelection.accountant:
                    if (Utilities.accoutants.Count == 0)
                    {
                        Messages.DisplayListWarningMessage(Utilities.noAccountantInListMessage);
                    }
                    else
                    {
                        foreach (Accountant accountant in Utilities.accoutants)
                        {
                            Console.WriteLine($"{startIndex}. {accountant.ReturnShortInfo()}");
                            startIndex += 1;
                        }
                    }
                    break;

                case EmployeeSelection.chef:
                    if (Utilities.chefs.Count == 0)
                    {
                        Messages.DisplayListWarningMessage(Utilities.noChefInListMessage);
                    }
                    else
                    {
                        foreach (Chef chef in Utilities.chefs)
                        {
                            Console.WriteLine($"{startIndex}. {chef.ReturnShortInfo()}");
                            startIndex += 1;
                        }
                    }
                    break;

                case EmployeeSelection.bartender:
                    if (Utilities.bartenders.Count == 0)
                    {
                        Messages.DisplayListWarningMessage(Utilities.noBartenderInListMessage);
                    }
                    else
                    {
                        foreach (Bartender bartender in Utilities.bartenders)
                        {
                            Console.WriteLine($"{startIndex}. {bartender.ReturnShortInfo()}");
                            startIndex += 1;
                        }
                    }
                    break;

                case EmployeeSelection.waitress:
                    if (Utilities.waitresses.Count == 0)
                    {
                        Messages.DisplayListWarningMessage(Utilities.noWaitressInListMessage);
                    }
                    else
                    {
                        foreach (Waitress waitress in Utilities.waitresses)
                        {
                            Console.WriteLine($"{startIndex}. {waitress.ReturnShortInfo()}");
                            startIndex += 1;
                        }
                    }
                    break;
            }

            Console.ResetColor();
        }

        public static void PerformCommonEmployeeOperationsProcess(Employee employee, int choice)
        {
            switch (choice)
            {
                case 1:
                    Console.Write("Please specify, how much hours has employee worked: ");
                    string userInput = Console.ReadLine();
                    
                    try
                    {
                        employee.PerformWork(int.Parse(userInput));
                    }
                    catch (Exception e)
                    {
                        Messages.DisplayErrorMessage(e.Message);
                    }
                    break;

                case 2:
                    Console.Write("Please specify bonus rate (Leave blank for default): ");
                    string userInput2 = Console.ReadLine();

                    try
                    {
                        if (userInput2 == "")
                        {
                            employee.GiveBonus();
                        }
                        else
                        {
                            employee.GiveBonus(double.Parse(userInput2));
                        }
                    }
                    catch
                    {
                        Messages.DisplayErrorMessage(Utilities.incorrectInputMessage);
                    }
                    break;

                case 3:
                    employee.GiveWage();
                    break;

                case 4:
                    employee.DisplayFullInfo();
                    break;
            }
        }

        public static void CurrentEmployeesMenuChoiceProcess()
        {
            string userInput = "";
            string currentPage = "1";

            Menus.CurrentEmployeesMenuPage1(ref userInput);

            do
            {
                switch (userInput)
                {
                    case "1":
                        Console.Clear();
                        currentPage = userInput;
                        Menus.CurrentEmployeesMenuPage1(ref userInput);
                        break;

                    case "2":
                        Console.Clear();
                        currentPage = userInput;
                        Menus.CurrentEmployeesMenuPage2(ref userInput);
                        break;

                    case "3":
                        Console.Clear();
                        currentPage = userInput;
                        Menus.CurrentEmployeesMenuPage3(ref userInput);
                        break;

                    case "4":
                        Console.Clear();
                        currentPage = userInput;
                        Menus.CurrentEmployeesMenuPage4(ref userInput);
                        break;

                    case "5":
                        Console.Clear();
                        currentPage = userInput;
                        Menus.CurrentEmployeesMenuPage5(ref userInput);
                        break;

                    case "6":
                        Console.Clear();
                        currentPage = userInput;
                        Menus.CurrentEmployeesMenuPage6(ref userInput);
                        break;

                    case "menu":
                        break;

                    default:
                        Messages.DisplayErrorMessage(Utilities.incorrectInputMessage);

                        switch (currentPage)
                        {
                            case "1":
                                Menus.CurrentEmployeesMenuPage1(ref userInput);
                                break;

                            case "2":
                                Menus.CurrentEmployeesMenuPage2(ref userInput);
                                break;

                            case "3":
                                Menus.CurrentEmployeesMenuPage3(ref userInput);
                                break;

                            case "4":
                                Menus.CurrentEmployeesMenuPage4(ref userInput);
                                break;

                            case "5":
                                Menus.CurrentEmployeesMenuPage5(ref userInput);
                                break;

                            case "6":
                                Menus.CurrentEmployeesMenuPage6(ref userInput);
                                break;
                        }

                        break;
                }
            }
            while (userInput != "menu");
        }

        public static void ListEmployeesNoIndexedProcess(EmployeeSelection filter)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;

            switch (filter)
            {
                case EmployeeSelection.manager:
                    if (Utilities.managers.Count == 0)
                    {
                        Messages.DisplayListWarningMessage(Utilities.noManagerInListMessage);
                    }
                    else
                    {
                        foreach (Manager manager in Utilities.managers)
                        {
                            manager.DisplayShortInfo();
                        }
                    }
                    break;

                case EmployeeSelection.accountant:
                    if (Utilities.accoutants.Count == 0)
                    {
                        Messages.DisplayListWarningMessage(Utilities.noAccountantInListMessage);
                    }
                    else
                    {
                        foreach (Accountant accountant in Utilities.accoutants)
                        {
                            accountant.DisplayShortInfo();
                        }
                    }
                    break;

                case EmployeeSelection.chef:
                    if (Utilities.chefs.Count == 0)
                    {
                        Messages.DisplayListWarningMessage(Utilities.noChefInListMessage);
                    }
                    else
                    {
                        foreach (Chef chef in Utilities.chefs)
                        {
                            chef.DisplayShortInfo();
                        }
                    }
                    break;

                case EmployeeSelection.bartender:
                    if (Utilities.bartenders.Count == 0)
                    {
                        Messages.DisplayListWarningMessage(Utilities.noBartenderInListMessage);
                    }
                    else
                    {
                        foreach (Bartender bartender in Utilities.bartenders)
                        {
                            bartender.DisplayShortInfo();
                        }
                    }
                    break;

                case EmployeeSelection.waitress:
                    if (Utilities.waitresses.Count == 0)
                    {
                        Messages.DisplayListWarningMessage(Utilities.noWaitressInListMessage);
                    }
                    else
                    {
                        foreach (Waitress waitress in Utilities.waitresses)
                        {
                            waitress.DisplayShortInfo();
                        }
                    }
                    break;

                case EmployeeSelection.all:
                    if (Utilities.managers.Count == 0 && Utilities.accoutants.Count == 0 && Utilities.chefs.Count == 0 && Utilities.bartenders.Count == 00 && Utilities.waitresses.Count == 0)
                    {
                        Messages.DisplayListWarningMessage(Utilities.noCurrentEmployeesInListMessage);
                    }
                    else
                    {
                        foreach (Manager manager in Utilities.managers)
                        {
                            manager.DisplayShortInfo();
                        }

                        foreach (Accountant accountant in Utilities.accoutants)
                        {
                            accountant.DisplayShortInfo();
                        }

                        foreach (Chef chef in Utilities.chefs)
                        {
                            chef.DisplayShortInfo();
                        }

                        foreach (Bartender bartender in Utilities.bartenders)
                        {
                            bartender.DisplayShortInfo();
                        }

                        foreach (Waitress waitress in Utilities.waitresses)
                        {
                            waitress.DisplayShortInfo();
                        }
                    }
                    break;
            }

            Console.ResetColor();
        }

        public static string ReturnUserInputProcess()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("Your input: ");
            string userInput = Console.ReadLine();
            Console.ResetColor();
            return userInput;
        }

        public static void DisplayAllEmployeeTypesProcess()
        {
            Console.WriteLine("1. Manager");
            Console.WriteLine("2. Accountant");
            Console.WriteLine("3. Chef");
            Console.WriteLine("4. Bartender");
            Console.WriteLine("5. Waitress");
        }

        public static void ListEmployeeTypeBasedIndexedProcess(EmployeeSelection selection) 
        {
            switch (selection)
            {
                case EmployeeSelection.manager:
                    Processes.ListEmployeesIndexedProcess(EmployeeSelection.manager);
                    break;

                case EmployeeSelection.accountant:
                    Processes.ListEmployeesIndexedProcess(EmployeeSelection.accountant);
                    break;

                case EmployeeSelection.chef:
                    Processes.ListEmployeesIndexedProcess(EmployeeSelection.chef);
                    break;

                case EmployeeSelection.bartender:
                    Processes.ListEmployeesIndexedProcess(EmployeeSelection.bartender);
                    break;

                case EmployeeSelection.waitress:
                    Processes.ListEmployeesIndexedProcess(EmployeeSelection.waitress);
                    break;
            }
        }


        public static void ChooseEmployeeAndMenuProcess(EmployeeSelection selection, int userChoice, MenuSelection destination)
        {
            switch (selection)
            {
                case EmployeeSelection.manager:
                    if (userChoice > 0 && userChoice <= Utilities.managers.Count)
                    {
                        Console.Clear();
                        if (destination == MenuSelection.employeeOperationsMenu)
                        {
                            Menus.EmployeeOperationsMenuSelectedEmployee(selection, userChoice - 1);
                        }
                        else if (destination == MenuSelection.removeEmployeeMenu)
                        {
                            Menus.RemoveEmployeeMenuConfirming(selection, userChoice - 1);
                        }
                        else if (destination == MenuSelection.financialReportMenu)
                        {
                            Menus.FinancialReportMenuResult(selection, userChoice - 1);
                        }
                        
                    }
                    else
                    {
                        Messages.DisplayErrorMessage(Utilities.incorrectChoiceMessage);
                    }
                    break;

                case EmployeeSelection.accountant:
                    if (userChoice > 0 && userChoice <= Utilities.accoutants.Count)
                    {
                        Console.Clear();
                        if (destination == MenuSelection.employeeOperationsMenu)
                        {
                            Menus.EmployeeOperationsMenuSelectedEmployee(selection, userChoice - 1);
                        }
                        else if (destination == MenuSelection.removeEmployeeMenu)
                        {
                            Menus.RemoveEmployeeMenuConfirming(selection, userChoice - 1);
                        }
                        else if (destination == MenuSelection.financialReportMenu)
                        {
                            Menus.FinancialReportMenuResult(selection, userChoice - 1);
                        }

                    }
                    else
                    {
                        Messages.DisplayErrorMessage(Utilities.incorrectChoiceMessage);
                    }
                    break;

                case EmployeeSelection.chef:
                    if (userChoice > 0 && userChoice <= Utilities.chefs.Count)
                    {
                        Console.Clear();
                        if (destination == MenuSelection.employeeOperationsMenu)
                        {
                            Menus.EmployeeOperationsMenuSelectedEmployee(selection, userChoice - 1);
                        }
                        else if (destination == MenuSelection.removeEmployeeMenu)
                        {
                            Menus.RemoveEmployeeMenuConfirming(selection, userChoice - 1);
                        }
                        else if (destination == MenuSelection.financialReportMenu)
                        {
                            Menus.FinancialReportMenuResult(selection, userChoice - 1);
                        }

                    }
                    else
                    {
                        Messages.DisplayErrorMessage(Utilities.incorrectChoiceMessage);
                    }
                    break;

                case EmployeeSelection.bartender:
                    if (userChoice > 0 && userChoice <= Utilities.bartenders.Count)
                    {
                        Console.Clear();
                        if (destination == MenuSelection.employeeOperationsMenu)
                        {
                            Menus.EmployeeOperationsMenuSelectedEmployee(selection, userChoice - 1);
                        }
                        else if (destination == MenuSelection.removeEmployeeMenu)
                        {
                            Menus.RemoveEmployeeMenuConfirming(selection, userChoice - 1);
                        }
                        else if (destination == MenuSelection.financialReportMenu)
                        {
                            Menus.FinancialReportMenuResult(selection, userChoice - 1);
                        }

                    }
                    else
                    {
                        Messages.DisplayErrorMessage(Utilities.incorrectChoiceMessage);
                    }
                    break;

                case EmployeeSelection.waitress:
                    if (userChoice > 0 && userChoice <= Utilities.waitresses.Count)
                    {
                        Console.Clear();
                        if (destination == MenuSelection.employeeOperationsMenu)
                        {
                            Menus.EmployeeOperationsMenuSelectedEmployee(selection, userChoice - 1);
                        }
                        else if (destination == MenuSelection.removeEmployeeMenu)
                        {
                            Menus.RemoveEmployeeMenuConfirming(selection, userChoice - 1);
                        }
                        else if (destination == MenuSelection.financialReportMenu)
                        {
                            Menus.FinancialReportMenuResult(selection, userChoice - 1);
                        }

                    }
                    else
                    {
                        Messages.DisplayErrorMessage(Utilities.incorrectChoiceMessage);
                    }
                    break;
            }
        }

        public static StatusEnum SaveToFileProcess()
        { 
            StatusEnum status = StatusEnum.pending;

            StringBuilder sb = new StringBuilder();

            if (Utilities.managers.Count > 0)
            {
                foreach (Manager manager in Utilities.managers)
                {
                    sb.Append($"manager>{manager.FirstName},{manager.LastName},{manager.Email},{manager.Rate},{manager.BirthDate},{manager.HireDate},{manager.Address.Address_1},{manager.Address.Address_2},{manager.Address.Zipcode},{manager.Address.City}#");
                }
            }
            if (Utilities.accoutants.Count > 0)
            {
                foreach (Accountant accountant in Utilities.accoutants)
                {
                    sb.Append($"accountant>{accountant.FirstName},{accountant.LastName},{accountant.Email},{accountant.Rate},{accountant.BirthDate},{accountant.HireDate},{accountant.Address.Address_1},{accountant.Address.Address_2},{accountant.Address.Zipcode},{accountant.Address.City}#");
                }
            }
            if (Utilities.chefs.Count > 0)
            {
                foreach (Chef chef in Utilities.chefs)
                {
                    sb.Append($"chef>{chef.FirstName},{chef.LastName},{chef.Email},{chef.Rate},{chef.BirthDate},{chef.HireDate},{chef.Address.Address_1},{chef.Address.Address_2},{chef.Address.Zipcode},{chef.Address.City}#");
                }
            }
            if (Utilities.bartenders.Count > 0)
            {
                foreach (Bartender bartender in Utilities.bartenders)
                {
                    sb.Append($"bartender>{bartender.FirstName},{bartender.LastName},{bartender.Email},{bartender.Rate},{bartender.BirthDate},{bartender.HireDate},{bartender.Address.Address_1},{bartender.Address.Address_2},{bartender.Address.Zipcode},{bartender.Address.City}#");
                }
            }
            if (Utilities.waitresses.Count > 0)
            {
                foreach (Waitress waitress in Utilities.waitresses)
                {
                    sb.Append($"waitress>{waitress.FirstName},{waitress.LastName},{waitress.Email},{waitress.Rate},{waitress.BirthDate},{waitress.HireDate},{waitress.Address.Address_1},{waitress.Address.Address_2},{waitress.Address.Zipcode},{waitress.Address.City}#");
                }
            }
            
            try
            {
                File.WriteAllText(Utilities.filepath, sb.ToString().Substring(0, sb.ToString().Length-1));
                status = StatusEnum.success;
            }
            catch
            {
                status = StatusEnum.error;
            }

            return status;
        }

        public static StatusEnum LoadUsersFromFile()
        {
            StatusEnum status = StatusEnum.pending;

            try
            {
                string fileContent = File.ReadAllText(Utilities.filepath);
                string[] employeeArray = fileContent.Split("#");

                foreach (string employee in employeeArray)
                {
                    try
                    {
                        string type = employee.Split(">")[0];
                        string employeeDetails = employee.Split(">")[1];

                        string firstName = employeeDetails.Split(",")[0];
                        string lastName = employeeDetails.Split(",")[1];
                        string email = employeeDetails.Split(",")[2];
                        double rate = Double.Parse(employeeDetails.Split(",")[3]);
                        DateOnly birthDate = DateOnly.Parse(employeeDetails.Split(",")[4]);
                        DateOnly hireDate = DateOnly.Parse(employeeDetails.Split(",")[5]);
                        string address1 = employeeDetails.Split(",")[6];
                        string address2 = employeeDetails.Split(",")[7];
                        string zipcode = employeeDetails.Split(",")[8];
                        string city = employeeDetails.Split(",")[9];

                        if (type == "manager")
                        {
                            Utilities.managers.Add(new Manager(firstName, lastName, email, rate, birthDate, hireDate, address1, address2, zipcode, city));
                        }
                        else if (type == "accountant")
                        {
                            Utilities.accoutants.Add(new Accountant(firstName, lastName, email, rate, birthDate, hireDate, address1, address2, zipcode, city));
                        }
                        else if (type == "chef")
                        {
                            Utilities.chefs.Add(new Chef(firstName, lastName, email, rate, birthDate, hireDate, address1, address2, zipcode, city));
                        }
                        else if (type == "bartender")
                        {
                            Utilities.bartenders.Add(new Bartender(firstName, lastName, email, rate, birthDate, hireDate, address1, address2, zipcode, city));
                        }
                        else if (type == "waitress")
                        {
                            Utilities.waitresses.Add(new Waitress(firstName, lastName, email, rate, birthDate, hireDate, address1, address2, zipcode, city));
                        }

                        status = StatusEnum.success;
                    }
                    catch
                    {
                        status = StatusEnum.error;
                    }
                }
            }
            catch
            {
                status = StatusEnum.fileNotFound;
            }

            return status;
        }
    }
}
