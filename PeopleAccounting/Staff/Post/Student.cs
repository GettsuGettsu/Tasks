using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleAccounting.Staff.Post
{
    public class Student : Human
    {
        #region Fields
        #endregion

        #region Properties
        private string optionalClasses = "None";
        public string OptionalClasses
        {
            get
            {
                return optionalClasses;
            }
            set
            {
                optionalClasses = value;
            }
        }
        #endregion

        #region Methods
        public static Student CreateStudent(string firstName, string lastName, string dateOfBirth, string optionalClasses, bool isOnVacation)
        {
            Student student = new Student();

            student.FillBaseInfo(firstName, lastName, dateOfBirth);
            student.OptionalClasses = Student.HaveOptionalClasses(optionalClasses);

            return student;
        }

        public static string HaveOptionalClasses(string optionalClasses)
        {
            if (!String.IsNullOrEmpty(optionalClasses))
                return optionalClasses;

            return "None";
        }
        #endregion

        public Student() { }
    }
}
