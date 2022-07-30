using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleAccounting.Staff.Post
{
    public class Employee : Human
    {
        #region Fields
        #endregion

        #region Properties
        protected double salary;
        public double Salary { get; set; }


        public bool IsFormalForm { get; } = true;
        #endregion

        #region Methods
        #endregion

        public Employee() { }
    }
}
