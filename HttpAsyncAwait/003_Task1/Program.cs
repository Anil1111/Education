using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            var classRoom = new ClassRoom(new BadPupil(), new ExelentPupil());

            classRoom.Write();
            Console.WriteLine(new string('-',50));
            classRoom.Read();
            Console.WriteLine(new string('-', 50));
            classRoom.Relax();
            Console.WriteLine(new string('-', 50));
            classRoom.Study();
            Console.WriteLine(new string('-', 50));

            //Delay
            Console.ReadKey();

        }
    }
}
