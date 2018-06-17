using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExmpleFromMSDN
{
    //не копировать все сразу, а по-немногу, чтобы успевать читать и понимать код.
    public class IdInfo
    {
        public int IdNumber;

        public IdInfo(int IdNumber)
        {
            this.IdNumber = IdNumber;
        }
    }

    public class Person
    {
        public int Age;
        public string Name;
        public IdInfo IdInfo;

        public Person ShallowCopy()//Почему ShallowCopy? Потому, что  public IdInfo IdInfo как ассоциация, будет скопирована ПОВЕРХНОСТНО!
        {
            return (Person)this.MemberwiseClone();
        }

        public Person DeepCopy() //ассоциации 
        {
            Person other = (Person)this.MemberwiseClone(); //поверхностная ассициация(из-за поля IdInfo)
            other.IdInfo = new IdInfo(IdInfo.IdNumber); // а теперь присваиваем полю IdInfo СВОЕ НОВОЕ ЗНАЧЕНИЕ. Раньше там была ссылка на поля оригинала, а теперь уже на свое поле.
            other.Name = String.Copy(Name); //хз зачем это...
            return other;
            //теперь такое копирование можно назвать полным.
        }
    }
    class Program
    {
        public static void DisplayValues(Person p)
        {
            Console.WriteLine("      Name: {0:s}, Age: {1:d}", p.Name, p.Age);
            Console.WriteLine("      Value: {0:d}", p.IdInfo.IdNumber);
        }
        static void Main(string[] args)
        {
            // Create an instance of Person and assign values to its fields.
            Person p1 = new Person();
            p1.Age = 42;
            p1.Name = "Sam";
            p1.IdInfo = new IdInfo(6565);

            // Perform a shallow copy of p1 and assign it to p2.
            Person p2 = p1.ShallowCopy();

            // Display values of p1, p2
            Console.WriteLine("Original values of p1 and p2:");
            Console.WriteLine("   p1 instance values: ");
            DisplayValues(p1);
            Console.WriteLine("   p2 instance values:");
            DisplayValues(p2);

            // Change the value of p1 properties and display the values of p1 and p2.
            p1.Age = 32;
            p1.Name = "Frank";
            p1.IdInfo.IdNumber = 7878;
            Console.WriteLine("\nValues of p1 and p2 after changes to p1:");
            Console.WriteLine("   p1 instance values: ");
            DisplayValues(p1);
            Console.WriteLine("   p2 instance values:");
            DisplayValues(p2);

            // Make a deep copy of p1 and assign it to p3.
            Person p3 = p1.DeepCopy();
            // Change the members of the p1 class to new values to show the deep copy.
            p1.Name = "George";
            p1.Age = 39;
            p1.IdInfo.IdNumber = 8641;
            Console.WriteLine("\nValues of p1 and p3 after changes to p1:");
            Console.WriteLine("   p1 instance values: ");
            DisplayValues(p1);
            Console.WriteLine("   p3 instance values:");
            DisplayValues(p3);

            //Delay
            Console.ReadKey();
        }
    }
}

