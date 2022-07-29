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
        public string FirstName
        {
            get => firstName;
            set => firstName = value;
        }
        public string LastName 
        {
            get => lastName;
            set => lastName = value;
        }
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
