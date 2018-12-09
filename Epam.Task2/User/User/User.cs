using System;
using System.Collections.Generic;
using System.Text;

namespace User
{
    class User
    {
        private string fName;
        private string lName;
        private string mName;
        private DateTime dateOfBirth;
        

        public string FName { get => fName; set => fName = value; }
        public string LName { get => lName; set => lName = value; }
        public string MName { get => mName; set => mName = value; }
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth =DateTime.Parse(value.ToString()); }
        
         
        public User() { }

        public User(string fName, string lName, string mName, string dateOfBirth)
        {
            this.FName = fName;
            this.LName = lName;
            this.MName = mName;
            this.DateOfBirth = DateTime.Parse(dateOfBirth);
        }

        public string getInfo()
        {
            return "First Name: "+ this.fName + " Middle Name: " + this.mName + " Last Name: "+ this.lName
                +" Date of birth: "+this.dateOfBirth.Date.ToString()+" Age: " + getAge(this.dateOfBirth) ;
        }
        static protected int getAge(DateTime dateOfBirth)
        {
            DateTime g = new DateTime((DateTime.Now.Date - dateOfBirth.Date).Ticks);
            int x = (g.Year-1);
            return x;

        }

    }
}
