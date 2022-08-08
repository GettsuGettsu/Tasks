using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleAccounting.Staff.Post
{
    public class EducationalHelper
    {
        private static readonly char[] chars = 
        {
            (char)31, (char)32, (char)33, (char)34, (char)35, (char)36, (char)37, (char)38, 
            (char)39, (char)40, (char)41, (char)42, (char)43, (char)44, (char)45, (char)46, 
            (char)47, (char)58, (char)59, (char)60, (char)61, (char)62, (char)63, (char)64,
            (char)91, (char)92, (char)93, (char)94, (char)95, (char)96, (char)123, (char)124,
            (char)125, (char)126
        };

        [Flags]
        public enum ClassTypes
        {
            None = 0,
            Math = 1,
            Physics = 2,
            PhysicalEducation = 4,
            Language = 8,
            All = ~None
        }

        internal static ClassTypes ToOptionalClasses(string optionalClasses)
        {
            ClassTypes types = ClassTypes.None;
            optionalClasses = optionalClasses.ToLower(); //.Trim(chars);

            if (String.IsNullOrEmpty(optionalClasses))
                return types;

            if (optionalClasses.Contains("math"))
                types |= ClassTypes.Math;

            if (optionalClasses.Contains("physics"))
                types |= ClassTypes.Physics;

            if (optionalClasses.Contains("language"))
                types |= ClassTypes.Language;

            if (optionalClasses.Contains("pe")
                || optionalClasses.Contains("physicaleducation")
                || optionalClasses.Contains("physical education"))
                types |= ClassTypes.PhysicalEducation;

            return types;
        }

        internal static Student AddStudent(Human human, bool isOnVacation, string optionalClasses)
        {
            ((Student)human).OptionalClasses = EducationalHelper.ToOptionalClasses(optionalClasses);
            ((Student)human).IsOnVacation = isOnVacation;

            return (Student)human;
        }

        internal static Student AddStudent(string firstName, string lastName, string dateOfBirth, bool isOnVacation, string optionalClasses)
        {
            Student student = new Student();

            student.FillBaseInfo(firstName, lastName, dateOfBirth);
            student.IsOnVacation = isOnVacation;
            student.OptionalClasses = EducationalHelper.ToOptionalClasses(optionalClasses);

            return student;
        }

        internal static Teacher AddTeacher(Human human, double salary, bool isOnVacation, string optionalClasses)
        {
            human = AddTeacher2(human, salary, isOnVacation);
            ((Teacher)human).OptionalClasses = EducationalHelper.ToOptionalClasses(optionalClasses);

            return (Teacher)human;
        }

        internal static Teacher AddTeacher(Human human, double salary, bool isOnVacation, ClassTypes optionalClasses)
        {
            human = AddTeacher2(human, salary, isOnVacation);
            ((Teacher)human).OptionalClasses = optionalClasses;

            return (Teacher)human;
        }

        internal static Teacher AddTeacher(string firstName, string lastName, string dateOfBirth, double salary, bool isOnVacation, string optionalClasses)
        {
            Teacher teacher = AddTeacher2(firstName, lastName, dateOfBirth, salary, isOnVacation);
            teacher.OptionalClasses = EducationalHelper.ToOptionalClasses(optionalClasses);

            return teacher;
        }

        internal static Teacher AddTeacher(string firstName, string lastName, string dateOfBirth, double salary, bool isOnVacation, ClassTypes optionalClasses)
        {
            Teacher teacher = AddTeacher2(firstName, lastName, dateOfBirth, salary, isOnVacation);
            teacher.OptionalClasses = optionalClasses;

            return teacher;
        }

        private static Teacher AddTeacher2(string firstName, string lastName, string dateOfBirth, double salary, bool isOnVacation)
        {
            Teacher teacher = new Teacher();
            teacher.FillBaseInfo(firstName, lastName, dateOfBirth);
            teacher.Salary = salary;
            teacher.IsOnVacation = isOnVacation;

            return teacher;
        }

        private static Teacher AddTeacher2(Human human, double salary, bool isOnVacation)
        {           
            ((Teacher)human).Salary = salary;
            ((Teacher)human).IsOnVacation = isOnVacation;

            return (Teacher)human;
        }        

        internal static string ToString(ClassTypes classTypes)
        {
            return "";
        }
    }
}
