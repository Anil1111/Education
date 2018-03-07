using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Partial_Classes.PartialClasses
{//Вторая часть класса
   public  partial class PartialClass
    {
        //Реализация partial метода
        partial void PartialMethod()
        {
            Console.WriteLine("Реализация partial метода");
        }

        //так как, partial методы всегда private, то если я захочу вызвать этот метод
        //на экземпляре partial класса, то прийдется этот метод ОБВЕРНУТЬ
        public void CallPartialMethod()
        {
            PartialMethod();

            //при вызове НЕ РЕАЛИЗОВАНОГО частичного метода компялитор его проигнорирует и 
            //ошибки компиляции не будет!
            MyMethod();
        }


        #region реализация частичных методов в других частях необязательна!

        //Изначально было закоментировано все и ошибки не было
        //partial void MyMethod()
        //{
        //    Console.WriteLine("Реализация partial методов в других частях " +
        //                      "partial класса PartialClass необязательна!!!");
        //}

        #endregion
    }
}
