using PeopleAccounting.People.Status;

namespace PeopleAccounting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Students> students = new List<Students>();
            List<Teachers> teachers = new List<Teachers>();
            List<Employees> employees = new List<Employees>();

            while (true)
            {
                Console.WriteLine("Add human? y/n");

                char readChar = Console.ReadKey(true).KeyChar;

                if (readChar == 'n')
                    break;
                else if (readChar != 'y')
                {
                    Console.WriteLine("Wrong character!");
                    continue;
                }

                Console.WriteLine("1 - add student\n2 - add teacher\n3 - add employee");
                readChar = Console.ReadKey(true).KeyChar;

                switch (readChar)
                {
                    case '1':
                        break;

                    case '2':
                        break;

                    case '3':
                        break;

                    default:
                        break;
                }
            }
        }
    }
}