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
        protected double salary = 0.0;
        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        protected bool isTeacher;
        public bool IsTeacher
        {
            get { return isTeacher; }
        }
        #endregion

        #region Methods
        //internal static double GetSalary()
        //{
        //    UniversityHelper.WriteMessage("Salary: ", false);

        //    if (!double.TryParse(UniversityHelper.ReadLine(), out double salary) || salary < 0)
        //    {
        //        UniversityHelper.ErrorMessage();
        //        GetSalary();
        //    }

        //    return salary;
        //}

        //internal static Employee Add(Human human, double salary, bool isOnVacation)
        //{
        //    return Add2(human.FirstName, human.LastName, human.DateOfBirth, salary, isOnVacation);
        //}

        //internal static Employee Add(string firstName, string lastName, string dateOfBirth, double salary, bool isOnVacation)
        //{
        //    return Add2(firstName, lastName, dateOfBirth, salary, isOnVacation);
        //}

        //private static Employee Add2(string firstName, string lastName, string dateOfBirth, double salary, bool isOnVacation)
        //{
        //    Employee employee = new Employee();

        //    employee.FillBaseInfo(firstName, lastName, dateOfBirth);
        //    employee.Salary = salary;
        //    employee.IsOnVacation = isOnVacation;

        //    return employee;
        //}
        #endregion

        public Employee() : this("", "", DateTime.MinValue, false, 0.0) { }

        public Employee(string firstName, string lastName, DateTime dateOfBirth, bool isOnVacation, double salary)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.dateOfBirth = dateOfBirth;
            this.isOnVacation = isOnVacation;
            this.salary = salary;
            this.isFormalForm = true;
            this.isTeacher = false;
        }
    }
}
