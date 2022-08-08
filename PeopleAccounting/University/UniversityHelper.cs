using PeopleAccounting.Staff.Post;
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
        
        internal static string ReadLine()
        {
            return Console.ReadLine() + "";
        }

        internal static string GetConsoleString()
        {
            string? inputText = Console.ReadLine();

            if (String.IsNullOrEmpty(inputText) || String.IsNullOrWhiteSpace(inputText))
            {
                ErrorMessage();
                GetConsoleString();
            }

            return inputText;
        }

        internal static void ErrorMessage()
        {
            Console.WriteLine("\nWrong input!");
        }

        internal static bool YesNoQuestion(string question)
        {
            Console.WriteLine(question);

            char readChar = UniversityHelper.ReadChar();

            if (readChar == 'n' || readChar == 'N')
            {
                return false;
            }
            else if (readChar != 'y' && readChar != 'Y')
            {
                Console.WriteLine("\nWrong character!");
                bool answer = YesNoQuestion(question);
                if (!answer)
                    return false;
            }

            return true;
        }

        internal static void WriteAllProp<T>(T human)
        {
            Console.WriteLine("\nAdded:");
            foreach (var prop in typeof(T).GetProperties())
            {
                Console.WriteLine($"\t{prop.Name}: {prop.GetValue(human)}");
            }
            Console.WriteLine();
        }

        internal static void WriteMessage(string message, bool isLine = true)
        {
            if (isLine)
                Console.WriteLine(message);
            else 
                Console.Write(message);
        }
    }
}
