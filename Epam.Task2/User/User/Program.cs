using System;

namespace User
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first name");
            string fName  = Console.ReadLine();
            Console.WriteLine("Enter middle name");
            string mName = Console.ReadLine();
            Console.WriteLine("Enter last name");
            string lName = Console.ReadLine();
            Console.WriteLine("Enter date of birth in format year-month-day");
            string birthDate = Console.ReadLine();

            User u = new User(fName, lName, mName, birthDate);

            Console.WriteLine(u.getInfo());
           
        }
    }
}
