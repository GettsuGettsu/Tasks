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
        #region Properties
        private decimal salary = 0;
        public decimal Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        private bool isTeacher;
        public bool IsTeacher
        {
            get { return isTeacher; }
            protected set { isTeacher = value; }
        }
        #endregion       

        public Employee() : this("", "", DateTime.MinValue, 0, false) { }

        public Employee(string firstName, string lastName, DateTime dateOfBirth, decimal salary, bool isOnVacation)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DateOfBirth = dateOfBirth;
            this.IsOnVacation = isOnVacation;
            this.Salary = salary;
            this.IsFormalForm = true;
            this.IsTeacher = false;
        }
    }
}
