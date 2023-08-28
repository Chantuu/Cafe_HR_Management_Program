using Cafe_Program.HR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Program.Misc
{
    internal class Utilites
    {
        public const string mainMenuTitle = "***********************************\n**         HR Management         **\n***********************************";
        public const string newEmployeeMenuTitle = "***********************************\n**       Add New Employee        **\n***********************************";
        public const string employeeOperationsMenuTitle = "***********************************\n**      Employee Opeartions      **\n***********************************";
        public const string currentEmployeesMenuTitle = "***********************************\n**       Current Employees       **\n***********************************";
        public const string removeEmployeesMenuTitle = "***********************************\n**        Remove Employees       **\n***********************************";

        public static List<Manager> managers = new List<Manager>();
        public static List<Accountant> accoutants = new List<Accountant>();
        public static List<Chef> chefs = new List<Chef>();
        public static List<Bartender> bartenders = new List<Bartender>();
        public static List<Waitress> waitresses = new List<Waitress>();
    }
}
