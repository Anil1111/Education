using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _015_AdditionalTask2
{
    class Company
    {
        private Worker[] staff;

        public Company()
        {
            string name;
            string post;
            int year;
            string tmp;

            staff = new Worker[1];
            for (int i = 0; i < staff.Length; i++)
            {
                Console.WriteLine("Введите имя сотрудника");
                name = Console.ReadLine();

                Console.WriteLine("Введите должность");
                post = Console.ReadLine();

                Console.WriteLine("Введите год начала работы");
                tmp = Console.ReadLine();

                try
                {
                    year = Convert.ToInt32(tmp);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Вы ввели недопустимое значение года.");
                    Console.WriteLine(e.Message);
                    year = DateTime.Now.Year;
                }

                staff[i] = new Worker(name,post,year);
                Console.Clear();
            }

            staff = staff.OrderBy(x => x.Name).ToArray();
        }

        public string this[int index]
        {
            get
            {
                string answer = "";
                foreach (var t in staff)
                {
                    if (t.Experience > index)
                    {
                        answer += t.Name + $" имеет {t.Experience} стажа.\n";
                    }
                }

                if (answer != string.Empty)
                {
                    return answer;
                }

                return "Нет сотрудников с таким стажем работы.";
            }
        }
    }
}
