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
        public bool IsFormalForm => isFormalForm = true;


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
        #endregion

        public Student() { }
    }
}
