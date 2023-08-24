using Cafe_Program.HR;
using Cafe_Program.Misc;
using System.Runtime.InteropServices;

string userInput;

do
{
    userInput = MainMenu();

    switch (userInput)
    {
        case "1":
            Console.Clear();
            NewEmployeeMenu();
            Console.Clear();
            break;

        case "2":
            Console.Clear();
            break;

        case "3":
            Console.Clear();
            break;

        case "4":
            Console.Clear();
            break;

        case "5":
            Console.Clear();
            break;

        case "6":
            Console.Clear();
            break;

        case "7":
            Console.Clear();
            break;

        case "8":
            Console.Clear();
            break;

        default:
            DisplayErrorMessage("Incorrect Input! Please try again!");
            break;
    }
}
while (userInput != "8");

static string MainMenu()
{
    DisplayTitle(Utilites.mainMenuTitle);

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

static void NewEmployeeMenu()
{
    string userInput;

    do
    {
        DisplayTitle(Utilites.newEmployeeMenuTitle);
        Console.WriteLine("Please select role for new Employee:");
        Console.WriteLine("1. Manager");
        Console.WriteLine("2. Accountant");
        Console.WriteLine("3. Chef");
        Console.WriteLine("4. Bartender");
        Console.WriteLine("5. Waitress");
        DisplayBackMessage();
        Console.Write("Your input: ");

        userInput = Console.ReadLine();

        switch(userInput) 
        {
            case "1":
                Console.Clear();
                AddNewEmployeeProcess(EmployeeSelection.manager);
                break;

            case "2":
                Console.Clear();
                AddNewEmployeeProcess(EmployeeSelection.accountant);
                break;

            case "3":
                Console.Clear();
                AddNewEmployeeProcess(EmployeeSelection.chef);
                break;

            case "4":
                Console.Clear();
                AddNewEmployeeProcess(EmployeeSelection.bartender);
                break;

            case "5":
                Console.Clear();
                AddNewEmployeeProcess(EmployeeSelection.waitress);
                break;

            case "menu":
                break;

            default:
                DisplayErrorMessage("Incorrect Input! Please Try again!");
                break;
        }
    }
    while (userInput != "menu");
    
}

static void AddNewEmployeeProcess(EmployeeSelection selection)
{
    DisplayTitle(Utilites.newEmployeeMenuTitle);
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

            DisplaySuccessMessage("New employee has been successfully added to application!");

        }
        catch (FormatException ex)
        {
            DisplayErrorMessage(ex.Message);
        }
        catch (Exception ex)
        {
            DisplayErrorMessage(ex.Message);
        }

    }
    catch (FormatException ex)
    {
        DisplayErrorMessage(ex.Message);
    }
    catch (Exception ex)
    {
        DisplayErrorMessage(ex.Message);
    }
}

static void DisplayErrorMessage(string message)
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(message);
    Console.WriteLine();
    Console.ResetColor();
}

static void DisplaySuccessMessage(string message)
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine(message);
    Console.WriteLine();
    Console.ResetColor();
}

static void DisplayBackMessage() 
{
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Type menu to go back to Main Menu");
    Console.ResetColor();
}

static void DisplayTitle(string title)
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine(title);
    Console.ResetColor();
    Console.WriteLine();
}