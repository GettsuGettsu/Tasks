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
        internal static Teacher AddTeacher(Human human, double salary, bool isOnVacation, string optionalClasses)
        {
            Teacher teacher = new Teacher();

            teacher.FillBaseInfo(human.FirstName, human.LastName, human.DateOfBirth);
            teacher.Salary = salary;
            teacher.IsOnVacation = isOnVacation;
            
            teacher.OptionalClasses = EducationalHelper.ToOptionalClasses(optionalClasses);

            return teacher;
        }

        internal static Teacher AddTeacher(string firstName, string lastName, string dateOfBirth, double salary, bool isOnVacation)
        {
            Teacher teacher = new Teacher();

            teacher.FillBaseInfo(firstName, lastName, dateOfBirth);
            teacher.Salary = salary;
            teacher.IsOnVacation = isOnVacation;

            return teacher;
        }

        private static Teacher AddTeacher2(Human human, double salary, bool isOnVacation)
        {
            Teacher teacher = new Teacher();

            teacher.FillBaseInfo(human.FirstName, human.LastName, human.DateOfBirth);
            teacher.Salary = salary;
            teacher.IsOnVacation = isOnVacation;

            return teacher;
        }
        #endregion

        public Teacher() 
        {            
            isFormalForm = false;
            isTeacher = true;
        }
    }
}
