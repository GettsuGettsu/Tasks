using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleAccounting.Staff.Post
{
    public class Teacher : Employee
    {
        #region Fields
        #endregion

        #region Properties
        //private string optionalClasses = "None";
        //public string OptionalClasses
        //{
        //    get { return optionalClasses; }
        //    set { optionalClasses = value; }
        //}

        [Flags]
        public enum OptionalClasses
        {
            None = 0,
            Math = 1,
            Physics = 2,
            PhysicalEducation = 4,
            Language = 8,
            All = ~None
        }
        #endregion

        #region Methods
        public static string OptionalClassesValidator(string optionalClasses)
        {
            if (!String.IsNullOrEmpty(optionalClasses))
                return optionalClasses;

            return "None";
        }
        #endregion

        public Teacher() 
        {            
            isFormalForm = false;
            isTeacher = true;
        }
    }
}
