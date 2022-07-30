using PeopleAccounting.Staff;
using PeopleAccounting.Staff.Status;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleAccounting
{
    public class University
    {
        public List<Student> students = new List<Student>();
        public List<Teacher> teachers = new List<Teacher>();
        public List<Employee> employees = new List<Employee>();

        #region Methods
        public void Start()
        {
            while (true)
            {
                if (!YesNoQuestion("Add human? y/n"))
                    break;

                Console.WriteLine("\n1 - Add student,\n2 - add teacher,\n3 - add employee.");
                char readChar = ReadChar();

                switch (readChar)
                {
                    case '1':
                        Console.WriteLine("\nAdding student...");
                        Student student = new Student();

                        FillHuman(student);

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
                        Teacher teacher = new Teacher();

                        FillHuman(teacher);

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
                        Employee employee = new Employee();

                        FillHuman(employee);

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

        public static Human FillHuman(Human human)
        {
            human.SetFullName(GetConsoleString("First name: "), GetConsoleString("Last name: "));
            human.DateOfBirth = GetConsoleString("Date of birth: ");

            return human;
        }

        private static bool YesNoQuestion(string question)
        {
            Console.WriteLine(question);

            char readChar = ReadChar();

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

        private static char ReadChar()
        {
            return Console.ReadKey(true).KeyChar;
        }

        private static string GetConsoleString(string message)
        {
            Console.Write(message);

            string? inputText = Console.ReadLine();

            if (string.IsNullOrEmpty(inputText))
                inputText = "";
            //GetConsoleString("Empty input! Please, try again!");
            return inputText;
        }
        #endregion

        public University() { }
    }
}
