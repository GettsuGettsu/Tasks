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
        public double Salary { get; set; }

        protected bool isTeacher = false;
        public bool IsTeacher { get; }
        #endregion

        #region Methods

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
                Teacher teacher = (Teacher)employee;                
                teacher.OptionalClasses = Teacher.HaveOptionalClasses(optionalClasses);
                return teacher;
            }

            return employee;
        }
        #endregion

        public Employee() { }
    }
}
