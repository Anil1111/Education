using System;

namespace Interview_task
{
    // https://metanit.com/sharp/tutorial/2.16.php
    class Person
    {
        public string name;
        public int age;
    }

    class Program
    {
        static void ChangePerson(Person person)
        {
            // сработает
            person.name = "Alice";
            // сработает только в рамках данного метода
            person = new Person { name = "Bill", age = 45 };
            Console.WriteLine(person.name); // Bill
        }

        static void ChangePerson(ref Person person)
        {
            // сработает
            person.name = "Alice";
            // сработает только в рамках данного метода
            person = new Person { name = "Bill", age = 45 };
            Console.WriteLine(person.name); // Bill
        }

        static void Main(string[] args)
        {

            //При передаче объекта класса по значению в метод передается копия ссылки на объект.
            //Это копия указывает на тот же объект, что и исходная ссылка, потому мы
            //можем изменить отдельные поля и свойства объекта, но не можем изменить сам объект.
            //Поэтому в примере выше сработает только строка person.name = "Alice".

            //А другая строка person = new Person { name = "Bill", age = 45 } 
            //создаст новый объект в памяти, и person теперь будет указывать на новый объект в памяти. 
            //Даже если после этого мы его изменим, то это никак не повлияет на ссылку p в методе Main,
            //поскольку ссылка p все еще указывает на старый объект в памяти.
            Person p = new Person { name = "Tom", age = 23 };
            ChangePerson(p);

            Console.WriteLine(p.name); // Alice
            Console.WriteLine(p.age); // 23

            Console.WriteLine("----------------------------------------");

            //Но при передаче параметра по ссылке(с помощью ключевого слова ref) в метод в качестве аргумента 
            //передается сама ссылка на объект в памяти. Поэтому можно изменить как поля и свойства объекта, так и сам объект:

            Person p1 = new Person { name = "Tom", age = 23 };
            ChangePerson(ref p1);

            Console.WriteLine(p1.name); // Bill
            Console.WriteLine(p1.age); // 45

            Console.Read();
        }
    }
}
