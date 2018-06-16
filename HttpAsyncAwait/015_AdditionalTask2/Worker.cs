using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace _015_AdditionalTask2
{
    struct Worker
    {
        public Worker(string name, string post, int year)
        {
            this.year = DateTime.Now.Year;
            this.name = name;
            this.post = post;
            this.Year = year;
        }
        private int year;
        private string name;
        private string post;

        public string Name => name;
        public string Post => post;
        public int Experience => DateTime.Now.Year - Year;

        public int Year
        {
            get => year;
            set
            {
                if (value <= DateTime.Now.Year && DateTime.Now.Year - value <= 50)
                {
                    this.year = value;
                }
                else
                {
                    Console.WriteLine("Вы ввели неправильную дату");
                    year = DateTime.Now.Year;
                }
            }
        }
    }
}
