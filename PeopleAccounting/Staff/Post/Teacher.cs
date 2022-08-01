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
        public static string HaveOptionalClasses(string optionalClasses)
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
