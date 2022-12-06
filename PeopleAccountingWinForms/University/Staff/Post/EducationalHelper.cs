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
            
            if (String.IsNullOrEmpty(optionalClasses))
                return types;

            optionalClasses = optionalClasses.ToLower(); //.Trim(chars);

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

        internal static string ToString(ClassTypes classTypes)
        {
            throw new NotImplementedException("Method is not implemented yet!");
        }

        public static Teacher AddOptionalClass(Teacher teacher, ClassTypes classType)
        {
            teacher.OptionalClasses |= classType;
            return teacher;
        }

        public static Student AddOptionalClass(Student student, ClassTypes classType)
        {
            student.OptionalClasses |= classType;
            return student;
        }

        public static Teacher RemoveOptionalClass(Teacher teacher, ClassTypes classType)
        {
            //if (IsClassTypeExist(teacher.OptionalClasses, classType))
            //    teacher.OptionalClasses ^= classType;
            teacher.OptionalClasses &= ~classType;

            return teacher;
        }

        public static Student RemoveOptionalClass(Student student, ClassTypes classType)
        {
            //if (IsClassTypeExist(student.OptionalClasses, classType))
            //    student.OptionalClasses ^= classType;
            student.OptionalClasses &= ~classType;

            return student;
        }

        /// <summary>
        /// Method check if type2 exist in the type1 enumeration.
        /// </summary>
        /// <param name="type1"></param>
        /// <param name="type2"></param>
        /// <returns></returns>
        private static bool IsClassTypeExist(ClassTypes type1, ClassTypes type2)
        {
            if ((type1 & type2) != ClassTypes.None)
                return true;

            return false;
        }
    }
}
