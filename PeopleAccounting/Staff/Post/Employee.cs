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
            UniversityHelper.WriteMessage("Salary: ", false);

            if (!double.TryParse(UniversityHelper.ReadLine(), out double salary) || salary < 0)
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
                    ((Teacher)human).OptionalClasses = EducationalHelper.ToOptionalClasses(optionalClasses);
                    return (Teacher)human;
                }
            }
            catch
            {
                UniversityHelper.WriteMessage("Not an employee!\n");
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
                Teacher teacher = EducationalHelper.CreateTeacher(firstName, lastName, dateOfBirth, salary, isOnVacation, optionalClasses);
                return teacher;
            }

            return employee;
        }

        
        #endregion

        public Employee() { }
    }
}
