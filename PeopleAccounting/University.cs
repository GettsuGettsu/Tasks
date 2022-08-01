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
        private List<Human> staff = new List<Human>();        
        private List<Student> students = new List<Student>();
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

                string optionalClasses = "None";

                switch (readChar)
                {
                    case '1':
                        {
                            this.AddingEducationalHuman(false);

                            Student student = students.LastOrDefault();

                            Console.WriteLine($"Succsess!\n\tFirst name: {student.FirstName}, " +
                                $"last name: {student.LastName}, date of birth: {student.DateOfBirth}, " +
                                $"optional classes: {student.OptionalClasses}");

                            break;
                        }

                    case '2':
                        {
                            this.AddingEducationalHuman(true);

                            Teacher teacher = (Teacher)staff.LastOrDefault();

                            Console.WriteLine($"Added human: \n\tFirst name: {teacher.FirstName}, " +
                                $"last name: {teacher.LastName}, date of birth: {teacher.DateOfBirth}, " +
                                $"optional classes: {teacher.OptionalClasses}");

                            break;
                        }
                    case '3':
                        {
                            Console.WriteLine("\nAdding employee...");
                            Employee employee = new Employee();

                            employee.FillBaseInfo(employee);

                            staff.Add(employee);
                            Console.WriteLine($"Added human: \n\tFirst name: {employee.FirstName}, " +
                                $"last name: {employee.LastName}, date of birth: {employee.DateOfBirth}");

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
            Console.WriteLine("\nAdding student...");

            string[] baseInfo = Human.GetBaseInfo();
            string optionalClasses = "None";

            if (UniversityHelper.YesNoQuestion("\nIs taking optional classes? y/n"))
            {
                Console.WriteLine("Optional classes: ");
                optionalClasses = UniversityHelper.GetConsoleString();
            }

            if (isTeacher)
            {
                Console.WriteLine("\nSalary: ");
                double.TryParse(Console.ReadLine(), out double salary);
                AddEmployee(baseInfo[0], baseInfo[1], baseInfo[2], salary, true, false, optionalClasses);
            }
            else AddStudent(baseInfo[0], baseInfo[1], baseInfo[2], optionalClasses, false);
        }

        private void AddingEmployee()
        {
            Console.WriteLine("\nAdding teacher...");

            string[] baseInfo = Human.GetBaseInfo();
                        

            AddEmployee();
        }

        public void AddEmployee(Employee employee)
        {
            staff.Add(employee);
        }

        public void AddEmployee(Human human, double salary, bool isTeacher, string optionalClasses = "None")
        {
            staff.Add(Employee.CreateEmployee(human, salary, isTeacher, optionalClasses));
        }

        public void AddEmployee(string firstName, string lastName, string dateOfBirth, double salary, bool isTeacher, bool isOnVacation = false, string optionalClasses = "None")
        {
            staff.Add(Employee.CreateEmployee(firstName, lastName, dateOfBirth, salary, isOnVacation, isTeacher, optionalClasses));
        }

        public void RemoveEmployee(Employee employee)
        {
            staff.Remove(employee);
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public void AddStudent(string firstName, string lastName, string dateOfBirth, string optionalClasses = "None", bool isOnVacation = false)
        {
            students.Add(Student.CreateStudent(firstName, lastName, dateOfBirth, optionalClasses, isOnVacation));
        }

        public void RemoveStudent(Student student)
        {
            students.Remove(student);
        }      
        #endregion

        public University() { }
    }
}
