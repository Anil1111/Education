using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional_Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            var userInstance = new User();

            Console.WriteLine(userInstance.Login);
            Console.WriteLine(userInstance.FirstName);
            Console.WriteLine(userInstance.LastName);
            Console.WriteLine(userInstance.Age);
            Console.WriteLine(userInstance.DateOfFillingTheAncet);

            Console.WriteLine(new string('-', 50));

            Console.WriteLine("Enter login");
            var login = Console.ReadLine();
            Console.WriteLine("Enter firstName");
            var firstName = Console.ReadLine();
            Console.WriteLine("Enter lastName");
            var lastName = Console.ReadLine();
            Console.WriteLine("Enter age");
            var age = Convert.ToInt32(Console.ReadLine());

            var newInstance = new User(login, firstName, lastName, age);

            Console.WriteLine(newInstance.Login);
            Console.WriteLine(newInstance.FirstName);
            Console.WriteLine(newInstance.LastName);
            Console.WriteLine(newInstance.Age);
            Console.WriteLine(newInstance.DateOfFillingTheAncet);

            //Delay
            Console.ReadKey();
        }
    }
}
