using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PeopleAccounting.Staff.Post.EducationalHelper;

namespace PeopleAccounting.Staff.Post
{
    public class Teacher : Employee
    {
        #region Properties
        private ClassTypes optionalClasses = ClassTypes.None;
        public ClassTypes OptionalClasses
        {
            get { return optionalClasses; }
            set { optionalClasses = value; }
        }
        #endregion

        public Teacher() : this("", "", DateTime.MinValue, 0, false, "") { }

        public Teacher(string firstName, string lastName, DateTime dateOfBirth, decimal salary, bool isOnVacation, string optionalClasses)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DateOfBirth = dateOfBirth;
            this.IsOnVacation = isOnVacation;
            this.Salary = salary;
            this.OptionalClasses = EducationalHelper.ToOptionalClasses(optionalClasses);
            this.IsFormalForm = true;
            this.IsTeacher = true;
        }

        public Teacher(string firstName, string lastName, DateTime dateOfBirth, decimal salary, bool isOnVacation, ClassTypes optionalClasses)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DateOfBirth = dateOfBirth;
            this.IsOnVacation = isOnVacation;
            this.Salary = salary;
            this.OptionalClasses = optionalClasses;
            this.IsFormalForm = true;
            this.IsTeacher = true;
        }
    }
}
