using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix m = new Matrix(4, 5);
            m.Show();

            Console.WriteLine(new string('-', 50));
            Console.WriteLine($"[1][2] = {m[1, 2]}");
            Console.WriteLine($"[6][2] = {m[6, 2]}");
            m[0, 0] = 11;

            Console.WriteLine(new string('-', 50));
            m.ChangeSize(7,6);
            m.Show();

            Console.WriteLine(new string('-', 50));
            m.ShowPartly(1,0,4,4);

            //Delay
            Console.ReadKey();
        }
    }
}
