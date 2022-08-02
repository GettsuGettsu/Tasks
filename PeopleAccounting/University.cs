using PeopleAccounting.Staff;
using PeopleAccounting.Staff.Post;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleAccounting
{
    public class University
    {
        private static List<Human> staff = new List<Human>();        
        private static List<Student> students = new List<Student>();
        //public List<Teacher> teachers = new List<Teacher>();
        //public List<Employee> employees = new List<Employee>();

        #region Methods
        public void Start() 
        {
            while (true)
            {
                if (!UniversityHelper.YesNoQuestion("Add human? y/n"))
                    break;

                Console.WriteLine("\n1 - Add student,\n2 - add teacher,\n3 - add employee.");
                char readChar = UniversityHelper.ReadChar();

                switch (readChar)
                {
                    case '1':
                        {
                            Console.WriteLine("\nStudent...");
                            this.AddingEducationalHuman(false);

                            Student student = students.Last();

                            UniversityHelper.WriteAllProp(student);

                            break;
                        }
                    case '2':
                        {
                            Console.WriteLine("\nTeacher...");
                            this.AddingEducationalHuman(true);

                            Teacher teacher = (Teacher)staff.Last();

                            UniversityHelper.WriteAllProp(teacher);

                            break;
                        }
                    case '3':
                        {
                            Console.WriteLine("\nEmployee...");
                            this.AddingEmployee();

                            Employee employee = (Employee)staff.Last();

                            UniversityHelper.WriteAllProp(employee);

                            break;
                        }
                    default: break;
                }
            }
            Console.Write("Press any key to exit...");
            Console.ReadKey(true);
        }

        private void AddingEducationalHuman(bool isTeacher)
        {
            string[] baseInfo = Human.GetBaseInfo();
            string optionalClasses = "None";

            if (UniversityHelper.YesNoQuestion("Is taking optional classes? y/n"))
            {
                Console.Write("Optional classes: ");
                optionalClasses = UniversityHelper.GetConsoleString();
            }

            if (isTeacher)
            {
                double salary = Employee.GetSalary();
                AddEmployee(baseInfo[0], baseInfo[1], baseInfo[2], salary, true, false, optionalClasses);
            }
            else AddStudent(baseInfo[0], baseInfo[1], baseInfo[2], optionalClasses, false);
        }

        private void AddingEmployee()
        {
            string[] baseInfo = Human.GetBaseInfo();
            double salary = Employee.GetSalary();

            AddEmployee(baseInfo[0], baseInfo[1], baseInfo[2], salary, false, false);
        }

        public static void AddEmployee(Employee employee)
        {
            staff.Add(employee);
        }

        public static void AddEmployee(Human human, double salary, bool isTeacher, string optionalClasses = "None")
        {
            staff.Add(Employee.CreateEmployee(human, salary, isTeacher, optionalClasses));
        }

        public static void AddEmployee(string firstName, string lastName, string dateOfBirth, double salary, bool isTeacher, bool isOnVacation = false, string optionalClasses = "None")
        {
            staff.Add(Employee.CreateEmployee(firstName, lastName, dateOfBirth, salary, isOnVacation, isTeacher, optionalClasses));
        }

        public static void RemoveEmployee(Employee employee)
        {
            staff.Remove(employee);
        }

        public static void AddStudent(Student student)
        {
            students.Add(student);
        }

        public static void AddStudent(string firstName, string lastName, string dateOfBirth, string optionalClasses = "None", bool isOnVacation = false)
        {
            students.Add(Student.CreateStudent(firstName, lastName, dateOfBirth, optionalClasses, isOnVacation));
        }

        public static void RemoveStudent(Student student)
        {
            students.Remove(student);
        }
        #endregion

        public University() { }
    }
}
