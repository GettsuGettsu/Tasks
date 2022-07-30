using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleAccounting.People.Status
{
    public class Employees : Humans
    {
        #region Properties
        public bool IsStudent => isStudent = false;
        public bool IsFormalForm => isFormalForm = true;
        #endregion

        #region Methods
        #endregion

        public Employees() { }

        public Employees(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public Employees(string firstName, string lastName, string dateOfBirth)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.dateOfBirth = dateOfBirth;
        }
    }
}
