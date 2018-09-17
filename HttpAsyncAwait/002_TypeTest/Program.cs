using System;
using System.Reflection;

namespace _002_TypeTest
{
    class Program
    {
        //Рефлексия - процесс обнаружения типов по время работы программы
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 45);

            Class1 instance = new Class1();
            Class1 instance2 = new Class1();

            #region Вывод информации о типе

            ListVariousStats(instance); //Получаем  разную информацию о Class1
            ListMethods(instance);      //Получаем информацию об Именах всех методов Class1
            ListFields(instance);       //Получаем информацию об Именах полей Class1
            ListProps(instance);        //Получаем информацию об Именах свойств Class1
            ListInterface(instance);    //Получаем список всех Интерфейсов, поддерживаемых Class1
            ListConstructors(instance); //Получаем информацию об именах всех конструкторах Class1

            #endregion

            #region Обращение к закрытым членам

            Console.WriteLine(new string('-', 60));

            Type type = instance.GetType();

            //Вызов private метода 
            MethodInfo methodInfo = type.GetMethod("MethodC", BindingFlags.Instance | BindingFlags.NonPublic);
            //главное - не путать с Invoke в делегатах
            //нужно передать instance - чтобы ЗНАТЬ ДЛЯ КАКОГО ЭКЗЕМПЛЯРА ВЫЗВАТЬ МЕТОД. Методы могут взаимодействовать с нестатическими полями , КОТОРЫЕ У КАЖДОГО ЭКЗЕМПЛЯРА - СВОИ!
            methodInfo?.Invoke(instance, new object[] {"Hello, ", "World!"});

            //Запись значение в private поле
            FieldInfo myString = type.GetField("myString", BindingFlags.Instance | BindingFlags.NonPublic);
            myString?.SetValue(instance2, "Hello, Vasya!");
            var fieldValue = myString?.GetValue(instance2);

            Console.WriteLine(instance2.MyString);

            #endregion

            //Delay
            Console.ReadKey();
        }

        //Получаем информацию об именах всех конструкторах Class1
        private static void ListConstructors(Class1 instance)
        {
            Console.WriteLine(new string('-', 30) + " Интерфейсы класса Class1" + "\n");
            Type type = instance.GetType();

            //Каждый ConstructorInfo знает все только об одном конструкторе
            ConstructorInfo[] constructorInfos = type.GetConstructors();

            foreach (ConstructorInfo constructorInfo in constructorInfos)
            {
                Console.WriteLine($"Constructor: {constructorInfo.Name}");
            }
        }

        //Получаем список всех Интерфейсов, поддерживаемых Class1
        private static void ListInterface(Class1 instance)
        {
            Console.WriteLine(new string('-', 30) + " Интерфейсы класса Class1" + "\n");
            Type type = instance.GetType();

            //с помощью type создаем массив "РАВНЫХ СЕБЕ волшебников" КАЖДЫЙ из которых ЗНАЕТ ТОЛЬКО ОБ ОДНОМ ИНТЕРФЕЙСЕ, ДОСТУПНОМ В КЛАССЕ Class1
            //Возврашает Type[] потому, что нам нужно знать инфо о Интерфейсах, а Интерфейс - это ТИП, а НЕ ЧЛЕН!
            Type[] interfaceTypes = type.GetInterfaces();
            foreach (Type interfaceType in interfaceTypes)
            {
                Console.WriteLine($"Интерфейс: {interfaceType.Name}"); 
            }
        }

        //Получаем информацию об Именах свойств Class1
        private static void ListProps(Class1 instance)
        {
            Console.WriteLine(new string('-', 30) + " Свойства класса Class1" + "\n");
            Type type = instance.GetType();

            //Каждый экземпляр класса PropertyInfo содержит информацию ТОЛЬКО ОБ ОДНОМ НАЙДЕННОМ СВОЙСТВЕ!
            PropertyInfo[] propertyInfos = type.GetProperties(); //Эта перегрузка возвращает все приватные property

            foreach (PropertyInfo propertyInfo in propertyInfos)
            {
                Console.WriteLine($"Свойство: {propertyInfo.Name}");
            }
        }

        //Получаем информацию об Именах полей Class1
        private static void ListFields(Class1 instance)
        {
            Console.WriteLine(new string('-', 30) + " Поля класса Class1" + "\n");
            Type type = instance.GetType();

            //Каждый экземпляр класса FieldInfo содержит информацию ТОЛЬКО ОБ ОДНОМ НАЙДЕННОМ ПОЛЕ!
            FieldInfo[] fieldInfos = type.GetFields(BindingFlags.Instance 
                                                    | BindingFlags.Static
                                                    | BindingFlags.Public
                                                    | BindingFlags.NonPublic);
            foreach (FieldInfo fieldInfo in fieldInfos)
            {
                Console.WriteLine($"Field: {fieldInfo.Name}");
            }
        }

        //Получаем информацию об Именах всех методов Class1
        private static void ListMethods(Class1 instance)
        {
            Console.WriteLine(new string('-', 30) + " Методы класса Class1" + "\n");
            Type type = instance.GetType();

            MethodInfo[] methodInfos = type.GetMethods(BindingFlags.Instance
                                                       | BindingFlags.Static
                                                       | BindingFlags.Public
                                                       | BindingFlags.NonPublic
                                                       | BindingFlags.DeclaredOnly);

            //Каждый MethodInfo модержит в себе информацию ТОЛЬКО ОБ ОДНОМ найденом методе
            foreach (MethodInfo methodInfo in methodInfos)
            {
                Console.WriteLine($"Method: {methodInfo.Name}");
            }
        }

        //Получаем  разную информацию о Class1
        private static void ListVariousStats(Class1 instance)
        {
            Console.WriteLine(new string('-', 30) + " Информация о Class1" + "\n");
            Type type = instance.GetType();

            Console.WriteLine($"Полное Имя:                    {type.FullName}");
            Console.WriteLine($"Базовый класс:                 {type.BaseType}");
            Console.WriteLine($"Абстрактный:                   {type.IsAbstract}");
            Console.WriteLine($"Это COM объект:                {type.IsCOMObject}");
            Console.WriteLine($"Запрещено наследование:        {type.IsSealed}");
            Console.WriteLine($"Это класс:                     {type.IsClass}");
        }
    }
}
