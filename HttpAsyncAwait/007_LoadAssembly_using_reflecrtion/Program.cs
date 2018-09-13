using System;
using System.IO;
using System.Reflection;

// Для тестирования данног примера, необходимо
//скопировать библиотеку 005_Assembly_CarLibrary.dll из примера _005_Assembly_CarLibrary в папку с .exe файлом
//иначе прийдется указывать путь

namespace _007_LoadAssembly_using_reflecrtion
{
    class Program
    {
        static void Main(string[] args)
        {
            //При помощи класса Assembly - можно динамически загружать сборки,
            //обращаться к членам класса в процессе выполнения (ПОЗДНЕЕ СВЯЗЫВАНИЕ),
            //а так же получать информацию о самой сборке.

            Assembly assembly = null; //это Бог, а Type - просто волшебник

            try
            {
                // Assembly.Load() - метод для загрузки сборки.
                //"005_Assembly_CarLibrary - это имя dll файла(РАСШИРЕНИЕ НЕ УКАЗЫВАТЬ)
                assembly = Assembly.Load("005_Assembly_CarLibrary"); //LoadFrom(полный путь к сборке) - с помощью этого метода модно загрузить сборку откуда угодно
                Console.WriteLine("Сборка _005_Assembly_CarLibrary успешно загружена.");
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e);
            }

            //Выводим информацию о всех типах сборки
            ListAllTypes(assembly);

            //Выводим информацию о всех членах в классе.
            ListAllMembers(assembly);

            //Выводим информацию о всех параметрах метода Driver.
            GetParams(assembly);

            //Delay
            Console.ReadKey();
        }

        private static void GetParams(Assembly assembly)
        {
            Console.WriteLine(new string('_', 80));

            //А тут уже указываем ПРОСТРАНСТВО ИМЕН - тут есть нижнее подчеркивание
            Type type = assembly.GetType("_005_Assembly_CarLibrary.MiniVan");
            MethodInfo methodInfo = type.GetMethod("Driver"); // Equals, Acceleration, Driver etc

            //Выводим информацию о количестве параметров.
            Console.WriteLine($"\nИнформация о параметрах для метода {methodInfo?.Name}");
            //Каждый ParameterInfo содержит информацию об одном И ТОЛЬКО ОДНОМ параметре
            ParameterInfo[] parameterInfos = methodInfo?.GetParameters();
            Console.WriteLine($"Метод имеет {parameterInfos?.Length} параметров");

            //Выводим некоторы характеристики каждого из параметров.
            foreach (ParameterInfo parameter in parameterInfos)
            {
                Console.WriteLine($"Имя параметра:     {parameter.Name}");
                Console.WriteLine($"Позиция в методе:  {parameter.Position}");
                Console.WriteLine($"Тип параметра:     {parameter.ParameterType}\n");
            }
        }

        //Метод для получения инфрмации о членах класса
        private static void ListAllMembers(Assembly assembly)
        {
            Console.WriteLine(new string('_', 80));

            //Вот и 4й способ получения экземпляра класса Type!!!
            //А тут уже указываем ПРОСТРАНСТВО ИМЕН - тут есть нижнее подчеркивание
            Type type = assembly.GetType("_005_Assembly_CarLibrary.MiniVan");

            Console.WriteLine($"\nЧлены класса: {type} \n");

            MemberInfo[] memberInfos = type.GetMembers();

            foreach (MemberInfo member in memberInfos)
            {
                Console.WriteLine($"{member.MemberType,-15}:  {member}");
            }
        }

        //Метод для получения информации о всех типах в сборке.
        private static void ListAllTypes(Assembly assembly)
        {
            Console.WriteLine(new string('_', 80));
            Console.WriteLine($"\nТипы в: {assembly.FullName} \n");

            //Сколько типов(class, enum etc) в dll`ке, только и 'волшебников' тут будет
            Type[] types = assembly.GetTypes();
            foreach (Type type in types)
            {
                Console.WriteLine($"Тип: {type}");
            }
        }
    }
}
