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
        public static string mainMenuTitle = "***********************************\n**         HR Management         **\n***********************************";
        public static string newEmployeeMenuTitle = "***********************************\n**       Add New Employee        **\n***********************************";

        public static List<Manager> managers = new List<Manager>();
        public static List<Accountant> accoutants = new List<Accountant>();
        public static List<Chef> chefs = new List<Chef>();
        public static List<Bartender> bartenders = new List<Bartender>();
        public static List<Waitress> waitresses = new List<Waitress>();
    }
}
