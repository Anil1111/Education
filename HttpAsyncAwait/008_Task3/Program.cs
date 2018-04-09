using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_Task3
{
    class Accountant
    {
        public enum Post
        {
            Director = 160,
            Programmer = 180,
            Cleaner = 200
        }

        public bool AskForBonus(Post worker, int hours)
        {
            return (int)worker < hours;
        }

        public void ShowTheResult(bool yesOnNo, Post worker, int hours)
        {
            if (yesOnNo)
            {
                Console.WriteLine($"The bonus has to be given because worker " +
                                  $"{worker} has worked more than {(int)worker} hours to be specific {hours} hours.");
                return;
            }
            Console.WriteLine($"The bonus doesn't have to be given because worker " +
                              $"{worker} has worked less than {(int)worker} hours to be specific {hours} hours.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var worker = Accountant.Post.Programmer;
            Console.Write("Enter the amount of hours: ");
            var hours = Convert.ToInt32(Console.ReadLine());

            Accountant instance = new Accountant();
            var yesOrNo = instance.AskForBonus(worker, hours);
            instance.ShowTheResult(yesOrNo, worker, hours);

            //Delay
            Console.ReadKey();
        }
    }
}
