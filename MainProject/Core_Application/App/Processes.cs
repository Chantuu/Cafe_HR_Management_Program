using Cafe_Program.HR;
using Cafe_Program.Misc;
using System.IO;
using System.Text;

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
                    if (Utilites.managers.Count == 0)
                    {
                        Messages.DisplayListWarningMessage("There are not any manager employees");
                    }
                    else
                    {
                        foreach (Manager manager in Utilites.managers)
                        {
                            Console.WriteLine($"{startIndex}. {manager.ReturnShortInfo()}");
                            startIndex += 1;
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
                            Console.WriteLine($"{startIndex}. {accountant.ReturnShortInfo()}");
                            startIndex += 1;
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
                            Console.WriteLine($"{startIndex}. {chef.ReturnShortInfo()}");
                            startIndex += 1;
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
                            Console.WriteLine($"{startIndex}. {bartender.ReturnShortInfo()}");
                            startIndex += 1;
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
                        break;
                    }
                    catch (Exception e)
                    {
                        Messages.DisplayErrorMessage(e.Message);
                    }
                    break;

                case 2:
                    employee.GiveBonus();
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
                        Messages.DisplayErrorMessage("Incorrect Input! Please try again!");

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

        public static string ReturnUserInputProcess()
        {
            Console.Write("Your input: ");

            string userInput = Console.ReadLine();
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
                    if (userChoice > 0 && userChoice <= Utilites.managers.Count)
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
                        
                    }
                    else
                    {
                        Messages.DisplayErrorMessage("Incorrect Selection! Please try again!");
                    }
                    break;

                case EmployeeSelection.accountant:
                    if (userChoice > 0 && userChoice <= Utilites.accoutants.Count)
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
                    }
                    else
                    {
                        Messages.DisplayErrorMessage("Incorrect Selection! Please try again!");
                    }
                    break;

                case EmployeeSelection.chef:
                    if (userChoice > 0 && userChoice <= Utilites.chefs.Count)
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
                    }
                    else
                    {
                        Messages.DisplayErrorMessage("Incorrect Selection! Please try again!");
                    }
                    break;

                case EmployeeSelection.bartender:
                    if (userChoice > 0 && userChoice <= Utilites.bartenders.Count)
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
                    }
                    else
                    {
                        Messages.DisplayErrorMessage("Incorrect Selection! Please try again!");
                    }
                    break;

                case EmployeeSelection.waitress:
                    if (userChoice > 0 && userChoice <= Utilites.waitresses.Count)
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
                    }
                    else
                    {
                        Messages.DisplayErrorMessage("Incorrect Selection! Please try again!");
                    }
                    break;
            }
        }

        public static StatusEnum SaveToFileProcess()
        {
            

            StatusEnum status = StatusEnum.pending;

            StringBuilder sb = new StringBuilder();

            if (Utilites.managers.Count > 0)
            {
                foreach (Manager manager in Utilites.managers)
                {
                    sb.Append($"manager>{manager.FirstName},{manager.LastName},{manager.Email},{manager.Rate},{manager.BirthDate},{manager.HireDate},{manager.Address},{manager.Address.Address_1},{manager.Address.Address_2},{manager.Address.Zipcode},{manager.Address.City}#");
                }
            }
            if (Utilites.accoutants.Count > 0)
            {
                foreach (Accountant accountant in Utilites.accoutants)
                {
                    sb.Append($"accountant>{accountant.FirstName},{accountant.LastName},{accountant.Email},{accountant.Rate},{accountant.BirthDate},{accountant.HireDate},{accountant.Address},{accountant.Address.Address_1},{accountant.Address.Address_2},{accountant.Address.Zipcode},{accountant.Address.City}#");
                }
            }
            if (Utilites.chefs.Count > 0)
            {
                foreach (Chef chef in Utilites.chefs)
                {
                    sb.Append($"chef>{chef.FirstName},{chef.LastName},{chef.Email},{chef.Rate},{chef.BirthDate},{chef.HireDate},{chef.Address},{chef.Address.Address_1},{chef.Address.Address_2},{chef.Address.Zipcode},{chef.Address.City}#");
                }
            }
            if (Utilites.bartenders.Count > 0)
            {
                foreach (Bartender bartender in Utilites.bartenders)
                {
                    sb.Append($"bartender>{bartender.FirstName},{bartender.LastName},{bartender.Email},{bartender.Rate},{bartender.BirthDate},{bartender.HireDate},{bartender.Address},{bartender.Address.Address_1},{bartender.Address.Address_2},{bartender.Address.Zipcode},{bartender.Address.City}#");
                }
            }
            if (Utilites.waitresses.Count > 0)
            {
                foreach (Waitress waitress in Utilites.waitresses)
                {
                    sb.Append($"waitress>{waitress.FirstName},{waitress.LastName},{waitress.Email},{waitress.Rate},{waitress.BirthDate},{waitress.HireDate},{waitress.Address},{waitress.Address.Address_1},{waitress.Address.Address_2},{waitress.Address.Zipcode},{waitress.Address.City}#");
                }
            }
            
            try
            {
                if (!File.Exists(Utilites.filepath))
                {
                    File.Create(Utilites.filepath);
                    File.WriteAllText(Utilites.filepath, sb.ToString());
                }
                else if (File.Exists(Utilites.filepath))
                {
                    File.WriteAllText(Utilites.filepath, sb.ToString());
                }
                status = StatusEnum.success;
            }
            catch (Exception ex)
            {
                status = StatusEnum.error;
            }

            return status;
        }
    }
}
