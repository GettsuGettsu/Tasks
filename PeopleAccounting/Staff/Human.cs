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


        protected string firstName = "Not set";
        public string FirstName 
        { 
            get { return firstName; }
        }

        
        protected string lastName = "Not set";
        public string LastName 
        { 
            get { return lastName; }
        }

        
        protected string dateOfBirth = "Not set";
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

            Console.Write("\nEnter first name: ");
            baseInfo[0] = UniversityHelper.GetConsoleString();

            Console.Write("Enter last name: ");
            baseInfo[1] = UniversityHelper.GetConsoleString();

            Console.Write("Enter date of birth: ");
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
