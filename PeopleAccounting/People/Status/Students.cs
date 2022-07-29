using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleAccounting.People.Status
{
    public class Students : Humans
    {
        #region Fields
        private string optionalClasses = "None";
        #endregion

        #region Properties
        public bool IsStudent => isStudent = true;
        public bool IsFormalForm => isFormalForm = true;
        public string OptionalClasses
        {
            get => optionalClasses;
            set => optionalClasses = value;
        }
        #endregion

        #region Methods
        #endregion

        public Students() { }

        public Students(string firstName, string lastName, string dateOfBirth)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.dateOfBirth = dateOfBirth;
        }
        
        public Students(string firstName, string lastName, string dateOfBirth, string optionalClasses)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.dateOfBirth = dateOfBirth;
            this.optionalClasses = optionalClasses;
        }
        
        public Students(string firstName, string lastName, string dateOfBirth, string optionalClasses, bool isOnVacation)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.dateOfBirth = dateOfBirth;
            this.optionalClasses = optionalClasses;
            this.isOnVacation = isOnVacation;
        }
    }
}
