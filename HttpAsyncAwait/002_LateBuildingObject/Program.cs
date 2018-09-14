using System;
using System.IO;
using System.Reflection;

namespace _002_LateBuildingObject
{
    //Скопировал dll`ку 001_CarLibrary в bin => Debug И МАЛО ТОГО, нужно было скопировать ещё 000_ICarr ПОТОМУ, ЧТО НИХРЕНА НЕ РАБОТАЛО!
    //И ТЕПЕРЬ у меня получилоась МНОГОФАЙЛОВАЯ СБОРКА

    //если бы я добавил References, и заимпортил пространство имен - у меня бы автоматом подтянулись в bin => Debug dll`ки, а так я сделал это руками
    class Program
    {
        static void Main(string[] args)
        {
            Assembly assembly = null;

            try
            {
                assembly = Assembly.Load("001_CarLibrary");
            }
            catch (FieldAccessException e)
            {
                Console.WriteLine(e.Message);
            }


            //Создание экземпляра класса MiniVan "на лету"
            // При помощи класса Activator производится связывание.
            // Метод CreateInstance() - предназначен для создания экземпляра типа во время выполнения.
            Type type = assembly.GetType("_001_CarLibrary.MiniVan");

            //Создание экземпляра класса MiniVan. Эта техника называается ПОЗДНИМ СВЯЗЫВАНИЕМ. А ранее связываение это Class1 class1 = new Class();
            //А Позднее потому, что мы можем поменять название класса (например ввести его в консоли) экземпляр которого мы создаем.
            object instance = Activator.CreateInstance(type);

            //Получаем экземпляра класса MethodInfo для метода Acceleration()
            //MethodInfo - объектно-ориентированное представление метода
            MethodInfo accMethodInfo = type.GetMethod("Acceleration");

            //Вызов метода Acceleration().
            // Первый параметр - ссылка на экземпляр для которого будет вызван метод Acceleration()
            // Второй параметр - массив аргументов метода Acceleration() - в данном случае null, потому, что параметров нету/ я не хочу их передавать
            accMethodInfo.Invoke(instance, null);

            //Получаем экземпляр класса MethodInfo для метода Driver
            MethodInfo driverMethodInfo = type.GetMethod("Driver");

            object[] parameters = { "Shumaher", 36 };

            //Вызов метода Driver()
            //Первый параметер - ссылка на экземпляр для которого будет вызван данный метод
            // Второй параметр - массив аргументов метода Driver() - в данном случае - parameters
            driverMethodInfo.Invoke(instance, parameters);

            //Delay
            Console.ReadKey();
        }
    }
}
