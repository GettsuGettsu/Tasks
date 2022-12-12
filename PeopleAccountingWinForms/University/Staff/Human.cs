using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleAccounting.Staff
{
    public class Human
    {
        #region Properties
        public Dictionary<int, string> properties = new Dictionary<int, string>();

        private string firstName;
        public string FirstName 
        { 
            get { return firstName; }
            set { firstName = value; }
        }

        private string lastName;
        public string LastName 
        { 
            get { return lastName; }
            set { lastName = value; }
        }
        
        private DateTime dateOfBirth;
        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }

        private bool isOnVacation;
        public bool IsOnVacation
        {
            get { return isOnVacation; }
            set { isOnVacation = value; }
        }
        
        private bool isFormalForm = true;
        public bool IsFormalForm 
        {
            get { return isFormalForm; }
            protected set { isFormalForm = value; }
        }

        private Guid id;
        public Guid Id
        {
            get { return id; }
        }
        #endregion

        #region Methods
        public void FillBaseInfo(string firstName, string lastName, DateTime dateOfBirth)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.dateOfBirth = dateOfBirth;
        }
        #endregion

        public Human() : this("", "", DateTime.MinValue, false) { }
        
        public Human(string firstName, string lastName, DateTime dateOfBirth, bool isOnVacation) 
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.dateOfBirth = dateOfBirth;
            this.isOnVacation = isOnVacation;
            this.id = Guid.NewGuid();
        }
    }
}
