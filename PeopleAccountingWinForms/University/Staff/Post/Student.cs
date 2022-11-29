using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PeopleAccounting.Staff.Post.EducationalHelper;

namespace PeopleAccounting.Staff.Post
{
    public class Student : Human
    {
        #region Properties
        private ClassTypes optionalClasses = ClassTypes.None;
        public ClassTypes OptionalClasses
        {
            get { return optionalClasses; }
            set { optionalClasses = value; }
        }
        #endregion

        public Student() : this("", "", DateTime.MinValue, false, "") { }

        public Student(string firstName, string lastName, DateTime dateOfBirth, bool isOnVacation, string optionalClasses)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DateOfBirth = dateOfBirth;
            this.IsOnVacation = isOnVacation;
            this.OptionalClasses = EducationalHelper.ToOptionalClasses(optionalClasses);
            this.IsFormalForm = true;
        }

        public Student(string firstName, string lastName, DateTime dateOfBirth, bool isOnVacation, ClassTypes optionalClasses)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DateOfBirth = dateOfBirth;
            this.IsOnVacation = isOnVacation;
            this.OptionalClasses = optionalClasses;
            this.IsFormalForm = true;
        }
    }
}
