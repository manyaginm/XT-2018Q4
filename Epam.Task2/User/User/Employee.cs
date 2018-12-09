using System;
using System.Collections.Generic;
using System.Text;

namespace User
{
    class Employee : User
    {
        private int yearInCompany;
        private string position;

        public Employee() { }

        public Employee (string fName, string lName, string mName, string dateOfBirth, int yearInCompany, string position) 
            : base(fName, lName, mName, dateOfBirth)
        {
            this.position = position;
            this.yearInCompany = yearInCompany;
        }

        public int YearInCompany { get => yearInCompany; set => yearInCompany = value; }
        public string Position { get => position; set => position = value; }

        public new string getInfo()
        {
            return "First Name: " + this.FName + " Middle Name: " + this.MName + " Last Name: " + this.LName
                + " Date of birth: " + this.DateOfBirth.Date.ToString() + " Age: " + User.getAge(this.DateOfBirth)
                + " Position " + this.Position + " Year in company: "+this.YearInCompany;
        }
    }
}
