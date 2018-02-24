using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_Properties
{//Классы.Свойства с одним методом доступа.

    class Constants
    {
        private double pi = 3.14D;
        private double e = 2.71D;

        //Свойство только для записи.  - WriteOnly Property
        public double Pi
        {
            set { pi = value; }
        }

        //Свойство только для чтения. - ReadOnly Property
        public double E
        {
            get { return e; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Constants constants = new Constants();

            constants.Pi = 3.141456780;
            //Console.WriteLine(constants.Pi); //Недопустимо

            //constants.E = 3.71D;             //Недопустимо
            Console.WriteLine(constants.E);
             
            //Delay
            Console.ReadKey();
        }
    }
}
