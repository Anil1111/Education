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
            // ���������
            person.name = "Alice";
            // ��������� ������ � ������ ������� ������
            person = new Person { name = "Bill", age = 45 };
            Console.WriteLine(person.name); // Bill
        }

        static void ChangePerson(ref Person person)
        {
            // ���������
            person.name = "Alice";
            // ��������� ������ � ������ ������� ������
            person = new Person { name = "Bill", age = 45 };
            Console.WriteLine(person.name); // Bill
        }

        static void Main(string[] args)
        {

            //��� �������� ������� ������ �� �������� � ����� ���������� ����� ������ �� ������.
            //��� ����� ��������� �� ��� �� ������, ��� � �������� ������, ������ ��
            //����� �������� ��������� ���� � �������� �������, �� �� ����� �������� ��� ������.
            //������� � ������� ���� ��������� ������ ������ person.name = "Alice".

            //� ������ ������ person = new Person { name = "Bill", age = 45 } 
            //������� ����� ������ � ������, � person ������ ����� ��������� �� ����� ������ � ������. 
            //���� ���� ����� ����� �� ��� �������, �� ��� ����� �� �������� �� ������ p � ������ Main,
            //��������� ������ p ��� ��� ��������� �� ������ ������ � ������.
            Person p = new Person { name = "Tom", age = 23 };
            ChangePerson(p);

            Console.WriteLine(p.name); // Alice
            Console.WriteLine(p.age); // 23

            Console.WriteLine("----------------------------------------");

            //�� ��� �������� ��������� �� ������(� ������� ��������� ����� ref) � ����� � �������� ��������� 
            //���������� ���� ������ �� ������ � ������. ������� ����� �������� ��� ���� � �������� �������, ��� � ��� ������:

            Person p1 = new Person { name = "Tom", age = 23 };
            ChangePerson(ref p1);

            Console.WriteLine(p1.name); // Bill
            Console.WriteLine(p1.age); // 45

            Console.Read();
        }
    }
}
