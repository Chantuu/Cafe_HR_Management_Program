using Cafe_Program.App;
using Cafe_Program.Misc;

string userInput;

// Example employees used for testing (Temporary)
Utilities.managers.Add(new Cafe_Program.HR.Manager("Gio", "Chanturia", "gio@gmail.com", 23, DateOnly.FromDateTime(new DateTime(2003, 10, 23)), DateOnly.FromDateTime(DateTime.Now), "Address1", "", "4400", "Poti"));
Utilities.accoutants.Add(new Cafe_Program.HR.Accountant("Gio", "Chanturia", "gio@gmail.com", 23, DateOnly.FromDateTime(new DateTime(2003, 10, 23)), DateOnly.FromDateTime(DateTime.Now), "Address1", "", "4400", "Poti"));
Utilities.chefs.Add(new Cafe_Program.HR.Chef("Gio", "Chanturia", "gio@gmail.com", 23, DateOnly.FromDateTime(new DateTime(2003, 10, 23)), DateOnly.FromDateTime(DateTime.Now), "Address1", "", "4400", "Poti"));
Utilities.bartenders.Add(new Cafe_Program.HR.Bartender("Gio", "Chanturia", "gio@gmail.com", 23, DateOnly.FromDateTime(new DateTime(2003, 10, 23)), DateOnly.FromDateTime(DateTime.Now), "Address1", "", "4400", "Poti"));
Utilities.waitresses.Add(new Cafe_Program.HR.Waitress("Gio", "Chanturia", "gio@gmail.com", 23, DateOnly.FromDateTime(new DateTime(2003, 10, 23)), DateOnly.FromDateTime(DateTime.Now), "Address1", "", "4400", "Poti"));

StatusEnum loadResult = Processes.LoadUsersFromFile();
if (loadResult == StatusEnum.success)
{
    Messages.DisplaySuccessMessage("Successfully loaded all employees from a file!");
}
else if (loadResult == StatusEnum.error)
{
    Messages.DisplayErrorMessage("Unable to fully load employees from a file!\nUncorrupted employee data was able to load!");
}
else if (loadResult == StatusEnum.fileNotFound)
{
    Messages.DisplayInformationMessage("File was not found!");
}

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
            Menus.EmployeeOperationsMenu();
            Console.Clear();
            break;

        case "3":
            Console.Clear();
            Menus.FinancialReportMenu();
            Console.Clear();
            break;

        case "4":
            Console.Clear();
            Processes.CurrentEmployeesMenuChoiceProcess();
            Console.Clear();
            break;

        case "5":
            Console.Clear();
            Menus.RemoveEmployeeMenu();
            Console.Clear();
            break;

        case "6":
            Console.Clear();
            StatusEnum result = Menus.SaveFileMenu();
            Console.Clear();

            if (result == StatusEnum.success)
            {
                Messages.DisplaySuccessMessage("All employees have been saved to a file!");
            }
            else if (result == StatusEnum.cancel)
            {
                Messages.DisplayInformationMessage("Operation has been cancelled by user!");
            }
            else if (result == StatusEnum.error)
            {
                Messages.DisplayErrorMessage("Unable to save file! Please, try again!");
            }

            break;

        case "7":
            Console.Clear();
            Menus.AboutMenu();
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
