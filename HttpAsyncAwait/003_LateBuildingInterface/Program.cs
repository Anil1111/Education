using System;
using System.IO;
using System.Reflection;
using _000_ICarr;
using _001_CarLibrary; //вот когда я добавил в References, и заимпортил пространство имен - у меня автоматом подтянулись в bin => Debug dll`ки!
//даже не смотря на то, что _001_CarLibrary вроде как не используется - я использую dll`ку через рефлексию, которая скопировалась когда я сделал using _001_CarLibrary;

namespace _003_LateBuildingInterface
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

                //сначала ICar светился красным, потому, интерфейс _000_ICarr находится в другом namespace
                ICar carInstance = Activator.CreateInstance(type) as ICar; //сделал using _000_ICarr; и все заработало

                if (carInstance != null)
                {
                    carInstance.Acceleration();
                    carInstance.Driver("Shumaher", 26);
                }
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
