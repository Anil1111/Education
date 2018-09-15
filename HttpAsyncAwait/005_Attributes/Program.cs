using System;
using System.Reflection;

namespace _005_Attributes
{
    //Аттрибуты сборки - добавляются в файл AssemblyInfo.cs - посмотри туда!
    class Program
    {
        static void Main(string[] args)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            object[] attributes = assembly.GetCustomAttributes(false);

            foreach (Attribute attribute in attributes)
            {
                Console.WriteLine($"Attribute: {attribute.GetType()} - {attribute.TypeId}");
            }

            //Delay
            Console.ReadKey();

            //ИТОГИ урока:
            //Атрибут нужно создать(отнаследоваться от класса Attribute, объявить все поля и т.д)
            //Атрибут нужно применить: продекорировать этим атрибутом член - класс, метод, свойство и т.д
            //Нужно создать механизм рефлексии, который будет использовать этот атрибут!
        }
    }
}
