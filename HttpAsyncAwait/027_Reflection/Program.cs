using System;
using System.Reflection;

//Рефлексия - это подход, который позволяет работать с типами данных, которые мы успользуем в наших программах.
namespace _027_Reflection
{
    //Нарушаем инкапсуляцию с помощью рефлексии!
    class MyClass
    {
        private string field = "123456";
        public string Field => field;
    }
    class Program
    {
        static void Main(string[] args)
        {
            var instance = new MyClass();
            Console.WriteLine($"Старая запись: {instance.Field}");

            Type type = instance.GetType();

            //instance.Field = "Hello";

            FieldInfo fieldInfo = type.GetField("field", BindingFlags.Instance | BindingFlags.NonPublic); //указываем, что это экземплярное поле и оно не открытое
            fieldInfo?.SetValue(instance, "Hello, Vasya");

            Console.WriteLine($"Новая запись: {instance.Field}");

            //------------------------------------------
            //Ситуация: я сделал класс модель и мне нужно вывести имена свойств на экран и мне впадлу их писать руками - я могу сделать так:

            var now = DateTime.Now;

            type = now.GetType();
            PropertyInfo[] propertyInfos = type.GetProperties();

            foreach (PropertyInfo propertyInfo in propertyInfos)
            {
                Console.WriteLine(propertyInfo.Name + "-" + propertyInfo.GetValue(now));
            }

            //Или же:
            //Я пишу запрос к базе данных и мне нужно в запросе указать имя поля в табличке. Чтобы не писать его руками,
            //я могу через рефлексию достучаться с имена поля в классе и вставить его в запрос к БД.

            //Рефлексия немного замедляет производительность, так что если она используется во многих местах, то это
            //может замедлить работу приложения.

            //Delay
            Console.ReadKey();
        }
    }
}
