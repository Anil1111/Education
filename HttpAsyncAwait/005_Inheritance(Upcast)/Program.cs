using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_Inheritance_Upcast_
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass instance = new DerivedClass();
            instance.field1 = 1;
            instance.field2 = 2;
            instance.field3 = 3;

            instance.field4 = 4;
            instance.field5 = 5;

            //Приведение экземпляра instance класса DerivedClass к базовому типу BaseClass.
            BaseClass newInstance = (BaseClass)instance; //UpCast  - не создает нового обьекта newInstance!
            //а создает специальную ссылку newInstance на все тот же обьект!
            //UpCast/DownCast - играют роль в полиморфизме(вторая форма классического полиморфизма) т.е
            // меняет форму существующего обьекта и в инкапсуляции т.к части програмных систем - скрываются!.

            Console.WriteLine(newInstance.field1);
            Console.WriteLine(newInstance.field2);
            Console.WriteLine(newInstance.field3);

            //Console.WriteLine(newInstance.field4);
            //Console.WriteLine(newInstance.field5);

            //Проверка - instance и newInstance - указывают не на разные обьекты, а на один и то же обьект
            Console.WriteLine($"instance iD       {instance.GetHashCode()}");
            Console.WriteLine($"newInstance iD    {newInstance.GetHashCode()}");

            //-------------------------------------------------------------------
            BaseClass instanceOfBase = new DerivedClass(); // Это как бы сразу апкаст идет!
            instanceOfBase.field1 = 1;
            instanceOfBase.field2 = 2;
            instanceOfBase.field3 = 3;

            //instanceOfBase.field4 = 4;
            // instanceOfBase.field5 = 5;

            DerivedClass instanceDown = (DerivedClass)instanceOfBase; // - а это DownCast


            //Delay
            Console.ReadKey();
        }
    }
}
