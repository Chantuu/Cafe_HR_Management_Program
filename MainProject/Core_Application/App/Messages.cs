using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Program.App
{
    internal class Messages
    {
        public static void DisplayErrorMessage(string message)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.WriteLine();
            Console.ResetColor();
        }

        public static void DisplaySuccessMessage(string message)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(message);
            Console.WriteLine();
            Console.ResetColor();
        }

        public static void DisplayBackMessage()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Type menu to go back to Main Menu");
            Console.ResetColor();
        }

        public static void DisplayTitle(string title)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(title);
            Console.ResetColor();
            Console.WriteLine();
        }
    }
}
