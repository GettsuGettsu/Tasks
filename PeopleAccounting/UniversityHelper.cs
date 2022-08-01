using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleAccounting
{
    internal class UniversityHelper
    {
        internal static char ReadChar()
        {
            return Console.ReadKey(true).KeyChar;
        }

        internal static string GetConsoleString()
        {
            string? inputText = Console.ReadLine();

            if (String.IsNullOrEmpty(inputText) || String.IsNullOrWhiteSpace(inputText))
            {
                Console.WriteLine("\nWrong input!");
                GetConsoleString();
            }

            return inputText;
        }

        internal static bool YesNoQuestion(string question)
        {
            Console.WriteLine(question);

            char readChar = UniversityHelper.ReadChar();

            if (readChar == 'n')
            {
                return false;
            }
            else if (readChar != 'y')
            {
                Console.WriteLine("\nWrong character!");
                YesNoQuestion(question);
            }

            return true;
        }
    }
}
