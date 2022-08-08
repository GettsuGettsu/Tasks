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
        public List<Human> staff = new List<Human>();        
        public List<Student> students = new List<Student>();
        //public List<Teacher> teachers = new List<Teacher>();
        //public List<Employee> employees = new List<Employee>();

        #region Methods
        public void Start() 
        {
            while (true)
            {
                if (!UniversityHelper.YesNoQuestion("Add human? y/n"))
                    break;

                UniversityHelper.WriteMessage("\n1 - Add student,\n2 - add teacher,\n3 - add employee.");

                switch (UniversityHelper.ReadChar())
                {
                    case '1':
                        {
                            UniversityHelper.WriteMessage("\nStudent...");
                            AddingEducationalHuman(false);

                            Student student = students.Last();

                            UniversityHelper.WriteAllProp(student);
                            break;
                        }
                    case '2':
                        {
                            UniversityHelper.WriteMessage("\nTeacher...");
                            AddingEducationalHuman(true);

                            Teacher teacher = (Teacher)staff.Last();

                            UniversityHelper.WriteAllProp(teacher);
                            break;
                        }
                    case '3':
                        {
                            UniversityHelper.WriteMessage("\nEmployee...");
                            AddingEmployee();

                            Employee employee = (Employee)staff.Last();

                            UniversityHelper.WriteAllProp(employee);
                            break;
                        }
                    default: break;
                }
            }
            UniversityHelper.WriteMessage("Press any key to exit...", false);
            UniversityHelper.ReadChar();
        }

        public void AddingEducationalHuman(bool isTeacher)
        {
            string[] baseInfo = Human.GetBaseInfo();
            string optionalClasses = "None";

            if (UniversityHelper.YesNoQuestion("Is taking optional classes? y/n"))
            {
                UniversityHelper.WriteMessage("Optional classes: ");
                optionalClasses = UniversityHelper.GetConsoleString();
            }

            if (isTeacher)
            {
                double salary = Employee.GetSalary();
                AddEmployee(baseInfo[0], baseInfo[1], baseInfo[2], salary, true, false, optionalClasses);
            }
            else AddStudent(baseInfo[0], baseInfo[1], baseInfo[2], optionalClasses, false);
        }

        internal void AddingEmployee()
        {
            string[] baseInfo = Human.GetBaseInfo();
            double salary = Employee.GetSalary();

            AddEmployee(baseInfo[0], baseInfo[1], baseInfo[2], salary, false, false);
        }

        public void AddEmployee(Employee employee)
        {
            staff.Add(employee);
        }

        public void AddEmployee(Human human, double salary, bool isTeacher, string optionalClasses = "None")
        {
            staff.Add(Employee.AddEmployee(human, salary, isTeacher, optionalClasses));
        }

        public void AddEmployee(string firstName, string lastName, string dateOfBirth, double salary, bool isTeacher, bool isOnVacation = false, string optionalClasses = "None")
        {
            staff.Add(Employee.AddEmployee(firstName, lastName, dateOfBirth, salary, isOnVacation, isTeacher, optionalClasses));
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
            students.Add(EducationalHelper.AddStudent(firstName, lastName, dateOfBirth, isOnVacation, optionalClasses));
        }

        public void RemoveStudent(Student student)
        {
            students.Remove(student);
        }
        #endregion

        public University() { }
    }
}
