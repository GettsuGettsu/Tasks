using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleAccounting.Staff.Post
{
    public class Employee : Human
    {
        #region Fields        
        #endregion

        #region Properties
        private double salary = 0.0;
        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        protected bool isTeacher = false;
        public bool IsTeacher
        {
            get { return isTeacher; }
        }
        #endregion

        #region Methods
        public static double GetSalary()
        {
            Console.Write("Salary: ");

            if (!double.TryParse(Console.ReadLine(), out double salary) || salary < 0)
            {
                UniversityHelper.ErrorMessage();
                GetSalary();
            }

            return salary;
        }

        public static Employee CreateEmployee(Human human, double salary, bool isTeacher, string optionalClasses)
        {
            try
            {
                ((Employee)human).Salary = salary;

                if (isTeacher)
                {
                    ((Teacher)human).OptionalClasses = optionalClasses;
                    return (Teacher)human;
                }
            }
            catch
            {
                Console.WriteLine("Not an employee!\n");
                return new Employee();
            }

            return (Employee)human;
        }

        public static Employee CreateEmployee(string firstName, string lastName, string dateOfBirth, double salary, bool isOnVacation, bool isTeacher, string optionalClasses)
        {
            Employee employee = new Employee();

            employee.FillBaseInfo(firstName, lastName, dateOfBirth);
            employee.Salary = salary;
            employee.IsOnVacation = isOnVacation;

            if (isTeacher)
            {                       
                Teacher teacher = CreateTeacher(firstName, lastName, dateOfBirth, salary, isOnVacation, Teacher.OptionalClassesValidator(optionalClasses));
                return teacher;
            }

            return employee;
        }

        private static Teacher CreateTeacher(string firstName, string lastName, string dateOfBirth, double salary, bool isOnVacation, string optionalClasses)
        {
            Teacher teacher = new Teacher();
            teacher.FillBaseInfo(firstName, lastName, dateOfBirth);
            teacher.Salary = salary;
            teacher.IsOnVacation = isOnVacation;
            teacher.OptionalClasses = optionalClasses;

            return teacher;
        }
        #endregion

        public Employee() { }
    }
}
