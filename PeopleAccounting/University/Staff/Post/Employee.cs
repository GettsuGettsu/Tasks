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
        internal static double GetSalary()
        {
            UniversityHelper.WriteMessage("Salary: ", false);

            if (!double.TryParse(UniversityHelper.ReadLine(), out double salary) || salary < 0)
            {
                UniversityHelper.ErrorMessage();
                GetSalary();
            }

            return salary;
        }

        internal static Employee AddEmployee(Human human, double salary, bool isOnVacation)
        {
            Employee employee = new Employee();
            employee.FillBaseInfo(human.FirstName, human.LastName, human.DateOfBirth);
            employee.Salary = salary;
            employee.IsOnVacation = isOnVacation;
            
            return employee;
        }

        internal static Employee AddEmployee(string firstName, string lastName, string dateOfBirth, double salary, bool isOnVacation)
        {
            Employee employee = new Employee();

            employee.FillBaseInfo(firstName, lastName, dateOfBirth);
            employee.Salary = salary;
            employee.IsOnVacation = isOnVacation;

            return employee;
        }
        #endregion

        public Employee() { }
    }
}
