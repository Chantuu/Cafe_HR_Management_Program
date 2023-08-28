using Cafe_Program.App;
using Cafe_Program.Misc;

string userInput;

// Example employees used for testing (Temporary)
Utilites.managers.Add(new Cafe_Program.HR.Manager("Gio", "Chanturia", "gio@gmail.com", 23, DateOnly.FromDateTime(new DateTime(2003, 10, 23)), DateOnly.FromDateTime(DateTime.Now), "Address1", "", "4400", "Poti"));
Utilites.accoutants.Add(new Cafe_Program.HR.Accountant("Gio", "Chanturia", "gio@gmail.com", 23, DateOnly.FromDateTime(new DateTime(2003, 10, 23)), DateOnly.FromDateTime(DateTime.Now), "Address1", "", "4400", "Poti"));
Utilites.chefs.Add(new Cafe_Program.HR.Chef("Gio", "Chanturia", "gio@gmail.com", 23, DateOnly.FromDateTime(new DateTime(2003, 10, 23)), DateOnly.FromDateTime(DateTime.Now), "Address1", "", "4400", "Poti"));
Utilites.bartenders.Add(new Cafe_Program.HR.Bartender("Gio", "Chanturia", "gio@gmail.com", 23, DateOnly.FromDateTime(new DateTime(2003, 10, 23)), DateOnly.FromDateTime(DateTime.Now), "Address1", "", "4400", "Poti"));
Utilites.waitresses.Add(new Cafe_Program.HR.Waitress("Gio", "Chanturia", "gio@gmail.com", 23, DateOnly.FromDateTime(new DateTime(2003, 10, 23)), DateOnly.FromDateTime(DateTime.Now), "Address1", "", "4400", "Poti"));

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
            Menus.employeeOperationsMenu();
            Console.Clear();
            break;

        case "3":
            Console.Clear();
            break;

        case "4":
            Console.Clear();
            Processes.CurrentEmployeesMenuChoiceProcess();
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
