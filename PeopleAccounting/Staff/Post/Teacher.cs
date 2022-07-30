using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleAccounting.Staff.Post
{
    public class Teacher : Employee
    {
        #region Properties
        public new bool IsFormalForm { get; } = false;


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

        public Teacher() { }
    }
}
