using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleAccounting.People
{
    public class Humans
    {
        #region Fields
        protected string firstName = "Undefined";
        protected string lastName = "Undefined";
        protected string dateOfBirth = "Undefined";
        protected bool isStudent;
        protected bool isFormalForm;
        protected bool isOnVacation = false;
        #endregion

        #region Properties
        public string FirstName => firstName;
        public string LastName => lastName;
        public string DateOfBirth 
        {
            get => dateOfBirth;
            set => dateOfBirth = value;
        }
        public bool IsOnVacation
        {
            get => isOnVacation;
            set => isOnVacation = value;
        }
        #endregion

        #region Methods
        public void SetFullName(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
        #endregion

        public Humans() { }

        public Humans(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public Humans(string firstName, string lastName, string dateOfBirth)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.dateOfBirth = dateOfBirth;
        }
    }
}
