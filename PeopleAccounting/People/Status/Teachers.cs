using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleAccounting.People.Status
{
    public class Teachers : Humans
    {
        #region Fields
        private string optionalClasses = "None";
        #endregion

        #region Properties
        public bool IsStudent => isStudent = false;
        public bool IsFormalForm => isFormalForm = false;
        public string OptionalClasses
        {
            get => optionalClasses;
            set => optionalClasses = value;
        }
        #endregion

        #region Methods
        #endregion

        public Teachers() { }

        public Teachers(string firstName, string lastName, string dateOfBirth)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.dateOfBirth = dateOfBirth;
        }

        public Teachers(string firstName, string lastName, string dateOfBirth, string optionalClasses)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.dateOfBirth = dateOfBirth;
            this.optionalClasses = optionalClasses;
        }

        public Teachers(string firstName, string lastName, string dateOfBirth, string optionalClasses, bool isOnVacation)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.dateOfBirth = dateOfBirth;
            this.optionalClasses = optionalClasses;
            this.isOnVacation = isOnVacation;
        }
    }
}
