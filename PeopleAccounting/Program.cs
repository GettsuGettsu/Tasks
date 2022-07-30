using PeopleAccounting.People;
using PeopleAccounting.People.Status;
using System.Security.Cryptography;

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
                if (!YesNoQuestion("Add human? y/n"))
                    break;

                Console.WriteLine("\n1 - Add student,\n2 - add teacher,\n3 - add employee.");
                char readChar = Console.ReadKey(true).KeyChar;

                switch (readChar)
                {
                    case '1':
                        Console.WriteLine("\nAdding student...");
                        Students student = new Students();

                        AddHuman(student);
                                                
                        if (YesNoQuestion("\nIs taking optional classes? y/n"))
                            student.OptionalClasses = GetConsoleString("Optional classes: ");
                        else student.OptionalClasses = "None";

                        students.Add(student);
                        Console.WriteLine($"Added human: \n\tFirst name: {student.FirstName}, " +
                            $"last name: {student.LastName}, date of birth: {student.DateOfBirth}, " +
                            $"optional classes: {student.OptionalClasses}");

                        break;

                    case '2':
                        Console.WriteLine("\nAdding teacher...");
                        Teachers teacher = new Teachers();

                        AddHuman(teacher);
                                                
                        if (YesNoQuestion("\nIs taking optional classes? y/n"))
                            teacher.OptionalClasses = GetConsoleString("Optional classes: ");
                        else teacher.OptionalClasses = "None";

                        teachers.Add(teacher);
                        Console.WriteLine($"Added human: \n\tFirst name: {teacher.FirstName}, " +
                            $"last name: {teacher.LastName}, date of birth: {teacher.DateOfBirth}, " +
                            $"optional classes: {teacher.OptionalClasses}");

                        break;

                    case '3':
                        Console.WriteLine("\nAdding employee...");
                        Employees employee = new Employees();

                        AddHuman(employee);

                        employees.Add(employee);
                        Console.WriteLine($"Added human: \n\tFirst name: {employee.FirstName}, " +
                            $"last name: {employee.LastName}, date of birth: {employee.DateOfBirth}");

                        break;

                    default:
                        break;
                }
            }
            Console.Write("Press any key to exit...");
            Console.ReadKey(true);
        }

        public static Humans AddHuman(Humans human)
        {
            human.SetFullName(GetConsoleString("First name: "), GetConsoleString("Last name: "));
            human.DateOfBirth = GetConsoleString("Date of birth: ");            

            return human;
        }

        private static bool YesNoQuestion(string question)
        {
            Console.WriteLine(question);

            char readChar = Console.ReadKey(true).KeyChar;

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

        private static string GetConsoleString(string message)
        {
            Console.Write(message);

            string? inputText = Console.ReadLine();

            if (String.IsNullOrEmpty(inputText))
                inputText = "";
                //GetConsoleString("Empty input! Please, try again!");
            return inputText;
        }
    }
}