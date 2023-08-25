using Cafe_Program.App;

string userInput;

do
{
    userInput = Menus.MainMenu();

    switch (userInput)
    {
        case "1":
            Console.Clear();
            Menus.NewEmployeeMenu();
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
            Processes.currentEmployeesMenuChoiceProcess();
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
            Messages.DisplayErrorMessage("Incorrect Input! Please try again!");
            break;
    }
}
while (userInput != "8");
