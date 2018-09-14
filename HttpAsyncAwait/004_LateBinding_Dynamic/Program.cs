using System;
using System.IO;
using System.Reflection;

//Скопировал dll`ку 001_CarLibrary в bin => Debug И МАЛО ТОГО, нужно было скопировать ещё 000_ICarr ПОТОМУ, ЧТО НИХРЕНА НЕ РАБОТАЛО!
//И ТЕПЕРЬ у меня получилоась МНОГОФАЙЛОВАЯ СБОРКА

namespace _004_LateBinding_Dynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly assembly = null;

            try
            {
                assembly = Assembly.Load("001_CarLibrary");
                Type type = assembly.GetType("_001_CarLibrary.MiniVan");

                //Т.е можно через dynamic вызвать методы, а можно через MethodInfo как в примере 002_LateBuildingObject
                dynamic miniVanInstance = Activator.CreateInstance(type);
                miniVanInstance.Acceleration();
                miniVanInstance.Driver("Vasya", 55);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }

            //Delay
            Console.ReadKey();
        }
    }
}
