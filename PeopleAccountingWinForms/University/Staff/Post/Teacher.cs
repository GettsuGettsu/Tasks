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
        #region Fields
        #endregion

        #region Properties
        private ClassTypes optionalClasses = ClassTypes.None;
        public ClassTypes OptionalClasses
        {
            get { return optionalClasses; }
            set { optionalClasses = value; }
        }
        #endregion

        #region Methods
        //internal static Teacher AddTeacher(Human human, double salary, bool isOnVacation, string optionalClasses)
        //{
        //    Teacher teacher = AddTeacher2(human.FirstName, human.LastName, human.DateOfBirth, salary, isOnVacation);            
        //    teacher.OptionalClasses = EducationalHelper.ToOptionalClasses(optionalClasses);

        //    return teacher;
        //}

        //internal static Teacher Add(Human human, double salary, bool isOnVacation, ClassTypes optionalClasses)
        //{
        //    Teacher teacher = Add2(human.FirstName, human.LastName, human.DateOfBirth, salary, isOnVacation);
        //    teacher.OptionalClasses = optionalClasses;

        //    return teacher;
        //}

        ////internal static Teacher AddTeacher(string firstName, string lastName, string dateOfBirth, double salary, bool isOnVacation, string optionalClasses)
        ////{
        ////    Teacher teacher = AddTeacher2(firstName, lastName, dateOfBirth, salary, isOnVacation);
        ////    teacher.OptionalClasses = EducationalHelper.ToOptionalClasses(optionalClasses);

        ////    return teacher;
        ////}

        //internal static Teacher Add(string firstName, string lastName, string dateOfBirth, double salary, bool isOnVacation, ClassTypes optionalClasses)
        //{
        //    Teacher teacher = Add2(firstName, lastName, dateOfBirth, salary, isOnVacation);
        //    teacher.OptionalClasses = optionalClasses;

        //    return teacher;
        //}

        //private static Teacher Add2(string firstName, string lastName, string dateOfBirth, double salary, bool isOnVacation)
        //{
        //    Teacher teacher = new Teacher();
        //    teacher.FillBaseInfo(firstName, lastName, dateOfBirth);
        //    teacher.Salary = salary;
        //    teacher.IsOnVacation = isOnVacation;

        //    return teacher;
        //}
        #endregion

        public Teacher() : this("", "", DateTime.MinValue, false, 0.0, "") { }

        public Teacher(string firstName, string lastName, DateTime dateOfBirth, bool isOnVacation, double salary, string optionalClasses)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.dateOfBirth = dateOfBirth;
            this.isOnVacation = isOnVacation;
            this.salary = salary;
            this.optionalClasses = EducationalHelper.ToOptionalClasses(optionalClasses);
            this.isFormalForm = true;
            this.isTeacher = true;
        }

        public Teacher(string firstName, string lastName, DateTime dateOfBirth, bool isOnVacation, double salary, ClassTypes optionalClasses)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.dateOfBirth = dateOfBirth;
            this.isOnVacation = isOnVacation;
            this.salary = salary;
            this.optionalClasses = optionalClasses;
            this.isFormalForm = true;
            this.isTeacher = true;
        }
    }
}
