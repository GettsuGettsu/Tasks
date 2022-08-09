using PeopleAccounting.Staff;
using PeopleAccounting.Staff.Post;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PeopleAccounting.Staff.Post.EducationalHelper;

namespace PeopleAccounting
{
    public class University
    {
        public List<Human> staff = new List<Human>();        
        public List<Student> students = new List<Student>();
        //public List<Teacher> teachers = new List<Teacher>();
        //public List<Employee> employees = new List<Employee>();

        #region Methods
        private void Start() 
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

        private void AddingEducationalHuman(bool isTeacher)
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
                AddTeacher(baseInfo[0], baseInfo[1], baseInfo[2], salary, false, optionalClasses);
            }
            else AddStudent(baseInfo[0], baseInfo[1], baseInfo[2], false, optionalClasses);
        }

        private void AddingEmployee()
        {
            string[] baseInfo = Human.GetBaseInfo();
            double salary = Employee.GetSalary();

            AddEmployee(baseInfo[0], baseInfo[1], baseInfo[2], salary, false);
        }

        public void AddEmployee(Employee employee)
        {
            staff.Add(employee);
        }

        /*public void AddEmployee(Human human, double salary, bool isOnVacation)
        {
            staff.Add(Employee.Add(human, salary, isOnVacation));
        }

        public void AddEmployee(string firstName, string lastName, string dateOfBirth, double salary, bool isOnVacation)
        {
            staff.Add(Employee.Add(firstName, lastName, dateOfBirth, salary, isOnVacation));
        }*/

        public void RemoveEmployee(Employee employee)
        {
            staff.Remove(employee);
        }

        public void AddTeacher(Teacher teacher)
        {
            staff.Add(teacher);
        }

        /*public void AddTeacher(Human human, double salary, bool isOnVacation, string optionalClasses)
        {
            staff.Add(Teacher.Add(human, salary, isOnVacation, EducationalHelper.ToOptionalClasses(optionalClasses)));
        }

        public void AddTeacher(Human human, double salary, bool isOnVacation, ClassTypes optionalClasses)
        {
            staff.Add(Teacher.Add(human, salary, isOnVacation, optionalClasses));
        }

        public void AddTeacher(string firstName, string lastName, string dateOfBirth, double salary, bool isOnVacation, string optionalClasses)
        {
            staff.Add(Teacher.Add(firstName, lastName, dateOfBirth, salary, isOnVacation, EducationalHelper.ToOptionalClasses(optionalClasses)));
        }

        public void AddTeacher(string firstName, string lastName, string dateOfBirth, double salary, bool isOnVacation, ClassTypes optionalClasses)
        {
            staff.Add(Teacher.Add(firstName, lastName, dateOfBirth, salary, isOnVacation, optionalClasses));
        }*/

        public void RemoveTeacher(Teacher teacher)
        {
            staff.Remove(teacher);
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        /*public void AddStudent(Human human, bool isOnVacation, string optionalClasses)
        {
            students.Add(Student.Add(human, isOnVacation, EducationalHelper.ToOptionalClasses(optionalClasses)));
        }

        public void AddStudent(Human human, bool isOnVacation, ClassTypes optionalClasses)
        {
            students.Add(Student.Add(human, isOnVacation, optionalClasses));
        }

        public void AddStudent(string firstName, string lastName, string dateOfBirth, bool isOnVacation, string optionalClasses)
        {
            students.Add(Student.Add(firstName, lastName, dateOfBirth, isOnVacation, EducationalHelper.ToOptionalClasses(optionalClasses)));
        }

        public void AddStudent(string firstName, string lastName, string dateOfBirth, bool isOnVacation, ClassTypes optionalClasses)
        {
            students.Add(Student.Add(firstName, lastName, dateOfBirth, isOnVacation, optionalClasses));
        }*/

        public void RemoveStudent(Student student)
        {
            students.Remove(student);
        }

        public (List<Student>, List<Teacher>) GetListOfParticipants(ClassTypes classTypes)
        {
            List<Student> students = new List<Student>();
            List<Teacher> teachers = new List<Teacher>();

            foreach (Student student in this.students)
            {
                if (student.OptionalClasses.HasFlag(classTypes))
                    students.Add(student);
            }

            foreach (Human human in this.staff)
            {
                if (human.GetType() == typeof(Teacher) && ((Teacher)human).OptionalClasses.HasFlag(classTypes))
                    teachers.Add((Teacher)human);
            }

            return (students, teachers);
        }
        #endregion

        public University() { }
    }
}
