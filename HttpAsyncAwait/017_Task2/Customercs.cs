using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _017_Task2
{
    class Customercs
    {
        private readonly string name;
        private readonly string model;
        private readonly string tel;

        public Customercs(string name, string model, string tel)
        {
            this.tel = tel;
            this.model = model;
            this.name = name;
        }

        public string Name => name;
        public string Model => model;
        public string Tel => tel;

        public override string ToString()
        {
            return $"Покупатель: {Name} Модель: {Model} Телефон: {Tel}";
        }
    }
}
