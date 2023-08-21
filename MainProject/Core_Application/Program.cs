
string userInput;

do
{
    userInput = MainMenu();

    switch (userInput)
    {
        case "1":
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
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Incorrect Input! Please try again!");
            Console.ResetColor();
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