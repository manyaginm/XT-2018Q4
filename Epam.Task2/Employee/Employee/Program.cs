using System;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first name");
            string fName = Console.ReadLine();
            Console.WriteLine("Enter middle name");
            string mName = Console.ReadLine();
            Console.WriteLine("Enter last name");
            string lName = Console.ReadLine();
            Console.WriteLine("Enter date of birth in format year-month-day");
            string birthDate = Console.ReadLine();
            Console.WriteLine("Enter position");
            string position = Console.ReadLine();
            Console.WriteLine("Enter Years in company");
            int yearsInComp = int.Parse(Console.ReadLine());
            Employee e = new Employee(fName, lName, mName, birthDate, yearsInComp, position);
            Console.WriteLine("As employee");
            Console.WriteLine(e.getInfo());

           
        }
    }
}
