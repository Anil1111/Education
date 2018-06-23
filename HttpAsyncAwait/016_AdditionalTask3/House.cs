using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _016_AdditionalTask3
{
    class House
    {
        private string city;
        private Street street;

        public House(Street street, string city)
        {
            this.city = city;
            this.street = street;
        }

        public House Clone() => this; //поверхностное копирование

        public House DeepClone()
        {
            return new House(this.street.Clone() as Street, this.city);
        }

        public Street Street
        {
            get => street;
            set => street = value;
        }

        public string City
        {
            get => city;
            set => city = value;
        }
    }

    class Street:ICloneable
    {
        private string str;

        public Street(string s)
        {
            this.str = s;
        }

        public string Str => str;
        public object Clone()
        {
            return new Street(this.str);
        }
    }

}
