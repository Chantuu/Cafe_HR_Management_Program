
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
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("***********************************");
    Console.WriteLine("**         HR Management         **");
    Console.WriteLine("***********************************");
    Console.ResetColor();

    Console.WriteLine();

    Console.WriteLine("1. Add New Employee");
    Console.WriteLine("2. Employee Operations");
    Console.WriteLine("3. Financial Data");
    Console.WriteLine("4. View Current Employees");
    Console.WriteLine("5. Remove Employee");
    Console.WriteLine("6. Save To File");
    Console.WriteLine("7. About Application");
    Console.WriteLine("8. Exit Application");
    Console.Write("Your input: ");

    string userInput = Console.ReadLine();
    return userInput;
}

static void NewEmployeeMenu()
{
    string title = "***********************************\n**       Add New Employee        **\n***********************************";
    string userInput;

    do
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(title);
        Console.ResetColor();
        Console.WriteLine();

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
                NewEmployeeMenu();
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

            case "menu":
                break;

            default:
                DisplayErrorMessage("Incorrect Input! Please Try again!");
                break;
        }
    }
    while(userInput != "menu");
    
}

static void DisplayErrorMessage(string message)
{
    Console.Clear();

    Console.ForegroundColor = ConsoleColor.Red;
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