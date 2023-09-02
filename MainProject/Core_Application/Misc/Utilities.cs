using Cafe_Program.HR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Program.Misc
{
    internal class Utilities
    {
        public const string mainMenuTitle = "***********************************\n**         HR Management         **\n***********************************";
        public const string newEmployeeMenuTitle = "***********************************\n**       Add New Employee        **\n***********************************";
        public const string financialReportMenuTitle = "***********************************\n**        Financial Report       **\n***********************************";
        public const string employeeOperationsMenuTitle = "***********************************\n**      Employee Opeartions      **\n***********************************";
        public const string currentEmployeesMenuTitle = "***********************************\n**       Current Employees       **\n***********************************";
        public const string removeEmployeesMenuTitle = "***********************************\n**        Remove Employees       **\n***********************************";
        public const string saveFileMenuTitle = "***********************************\n**       Save Information        **\n***********************************";
        public const string aboutMenuTitle = "***********************************\n**         About Program         **\n***********************************";

        public static string programPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
        public static string filepath = Path.Combine(programPath, "employees.txt");

        public static List<Manager> managers = new List<Manager>();
        public static List<Accountant> accoutants = new List<Accountant>();
        public static List<Chef> chefs = new List<Chef>();
        public static List<Bartender> bartenders = new List<Bartender>();
        public static List<Waitress> waitresses = new List<Waitress>();

        public const string incorrectInputMessage = "Incorrect Input! Please try again!";
        public const string incorrectChoiceMessage = "Incorrect choice! Please try again!";
        public const string operationCancelledUserMessage = "Operation has been cancelled by user!";
        public const string employeeRemovalSuccessMessage = "Successfully removed employee!";
        public const string employeeAdditionSuccessMessage = "New employee has been successfully added to application!";

        public const string noManagerInListMessage = "There aren't any manager employees!";
        public const string noAccountantInListMessage = "There aren't any accountant employees!";
        public const string noChefInListMessage = "There aren't any chef employees!";
        public const string noBartenderInListMessage = "There aren't any bartender employees!";
        public const string noWaitressInListMessage = "There aren't any waitress employees!";
        public const string noCurrentEmployeesInListMessage = "There aren't any current employees!";

        public const string navigationToMenuMessage = "Type menu to go back to Main Menu";
        public const string navigationToPreviousMessage = "Type back to go back";
        public const string navigationPressEnterMessage = "Press enter to go back";
        public const string navigationConfirmationMessage = "Type yes to continue, no to cancel";
        public const string navigationExitMessage = "Type exit to quit application";
    }
}
