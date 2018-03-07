using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _002_Task2
{
    public class Employee
    {
        public Employee(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        private readonly string firstName;
        private readonly string lastName;
        public int Rang { get; set; } = 2;
        public int WorkTime { get; set; } = 30;

        public string FirstName => firstName;

        public string LastName => lastName;

        public List<double> CountEverithing()
        { //https://docs.microsoft.com/ru-ru/dotnet/csharp/programming-guide/classes-and-structs/how-to-initialize-objects-by-using-an-object-initializer
            var info = new List<double>();
            var salary = Rang * (WorkTime / 5) * 1000;
            var paymentForNothing = salary * 0.22;
            info.Add(salary);
            info.Add(paymentForNothing);
            
            return info;
        }
    }
}
