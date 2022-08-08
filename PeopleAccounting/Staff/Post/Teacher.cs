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
        #endregion

        public Teacher() 
        {            
            isFormalForm = false;
            isTeacher = true;
        }
    }
}
