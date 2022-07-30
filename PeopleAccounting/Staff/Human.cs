using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleAccounting.Staff
{
    public class Human
    {
        #region Fields
        protected bool isFormalForm;
        #endregion

        #region Properties
        protected string firstName = "Undefined";
        public string FirstName { get; }

        
        protected string lastName = "Undefined";
        public string LastName { get; }

        
        protected string dateOfBirth = "Undefined";
        public string DateOfBirth { get; set; }


        protected bool isOnVacation = false;
        public bool IsOnVacation { get; set; }
        #endregion

        #region Methods
        public void SetFullName(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
        #endregion

        public Human() { }
    }
}
