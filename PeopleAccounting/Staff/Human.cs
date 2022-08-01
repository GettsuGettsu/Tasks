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
        public bool IsFormalForm { get; }


        protected string firstName = "Not set";
        public string FirstName { get; }

        
        protected string lastName = "Not set";
        public string LastName { get; }

        
        protected string dateOfBirth = "Not set";
        public string DateOfBirth { get; set; }


        protected bool isOnVacation = false;
        public bool IsOnVacation { get; set; }
        #endregion

        #region Methods
        public static string[] GetBaseInfo()
        {
            string[] baseInfo = new string[3];

            Console.WriteLine("\nEnter first name: ");
            baseInfo[0] = University.GetConsoleString();

            Console.WriteLine("\nEnter last name: ");
            baseInfo[1] = University.GetConsoleString();

            Console.WriteLine("\nEnter date of birth: ");
            baseInfo[2] = University.GetConsoleString();

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
