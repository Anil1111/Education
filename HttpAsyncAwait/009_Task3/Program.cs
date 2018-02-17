using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_Task3
{
    class Program
    {
        private static readonly Random rnd;

        static Program()
        {
            rnd = new Random();
        }
        private static int[] CreateMassive()
        {
            int[] array = new int[rnd.Next(5, 10)];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-10, 10);
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine("\n" + new string('-', 30));
            return array;
        }
        private static int[] MakeThisMassiveLongerByValue(int value, int[] massive)
        {
            int[] newMassive = new int[massive.Length + value];
            for (int i = 0; i < newMassive.Length; i++)
            {
                if (i + 1 <= massive.Length)
                    newMassive[i] = massive[i];
            }

            for (int i = 0; i < newMassive.Length; i++)
            {
                Console.Write($"{newMassive[i]} ");
            }
            Console.WriteLine();
            return newMassive;
        }
        static void Main(string[] args)
        {
            int[] massive = CreateMassive();
            int value = 2;
            int[] massiveAfterEdition = MakeThisMassiveLongerByValue(value, massive);
            int[] valueForInsertion = { 20, 10 };
            PutValueIntoMassive(massiveAfterEdition, valueForInsertion);

            //Delay
            Console.ReadKey();
        }

        private static void PutValueIntoMassive(int[] massiveAfterEdition, int[] valueIntoInsertion)
        {
            int[] massiveConsistionOfTwoMassives = new int[massiveAfterEdition.Length + valueIntoInsertion.Length];
            for (int i = 0; i < massiveConsistionOfTwoMassives.Length; i++)
            {
                if (i + 1 <= valueIntoInsertion.Length)
                    massiveConsistionOfTwoMassives[i] = valueIntoInsertion[i];
                else
                    massiveConsistionOfTwoMassives[i] = massiveAfterEdition[i - valueIntoInsertion.Length];
                Console.Write($"{massiveConsistionOfTwoMassives[i]} ");
            }
        }
    }
}
 