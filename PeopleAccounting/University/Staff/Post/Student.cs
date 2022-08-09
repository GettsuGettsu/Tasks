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
        //internal static Student Add(Human human, bool isOnVacation, string optionalClasses)
        //{
        //    return Add2(human.FirstName, human.LastName, human.DateOfBirth, isOnVacation, EducationalHelper.ToOptionalClasses(optionalClasses));
        //}
        
        internal static Student Add(Human human, bool isOnVacation, ClassTypes optionalClasses)
        {
            return Add2(human.FirstName, human.LastName, human.DateOfBirth, isOnVacation, optionalClasses);
        }

        //internal static Student Add(string firstName, string lastName, string dateOfBirth, bool isOnVacation, string optionalClasses)
        //{
        //    return Add2(firstName, lastName, dateOfBirth, isOnVacation, EducationalHelper.ToOptionalClasses(optionalClasses));
        //}

        internal static Student Add(string firstName, string lastName, string dateOfBirth, bool isOnVacation, ClassTypes optionalClasses)
        {
            return Add2(firstName, lastName, dateOfBirth, isOnVacation, optionalClasses);
        }

        internal static Student Add2(string firstName, string lastName, string dateOfBirth, bool isOnVacation, ClassTypes optionalClasses)
        {
            Student student = new Student();

            student.FillBaseInfo(firstName, lastName, dateOfBirth);
            student.IsOnVacation = isOnVacation;
            student.OptionalClasses = optionalClasses;

            return student;
        }

        public void DropOut(University university)
        {
            university.RemoveStudent(this);
        }
        #endregion

        public Student() { }
    }
}
