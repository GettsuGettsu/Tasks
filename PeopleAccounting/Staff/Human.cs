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
        #endregion

        #region Properties
        protected bool isFormalForm = true;
        public bool IsFormalForm 
        {
            get { return isFormalForm; }
        }


        protected string firstName = "";
        public string FirstName 
        { 
            get { return firstName; }
        }

        
        protected string lastName = "";
        public string LastName 
        { 
            get { return lastName; }
        }

        
        protected string dateOfBirth = "";
        public string DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }

        protected bool isOnVacation = false;
        public bool IsOnVacation
        {
            get { return isOnVacation; }
            set { isOnVacation = value; }
        }
        #endregion

        #region Methods
        public static string[] GetBaseInfo()
        {
            string[] baseInfo = new string[3];

            UniversityHelper.WriteMessage("\nEnter first name: ", false);
            baseInfo[0] = UniversityHelper.GetConsoleString();

            UniversityHelper.WriteMessage("Enter last name: ", false);
            baseInfo[1] = UniversityHelper.GetConsoleString();

            UniversityHelper.WriteMessage("Enter date of birth: ", false);
            baseInfo[2] = UniversityHelper.GetConsoleString();

            return baseInfo;
        }

        public void FillBaseInfo(string firstName, string lastName, string dateOfBirth)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.dateOfBirth = dateOfBirth;
        }
        #endregion

        public Human() { }
    }
}
