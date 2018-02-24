using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace _001_AdditionalTask1
{
    class Address
    {
        private string index="";

        public string Index
        {
            set => index = value;
            get => index;
        }
        private string country;

        public string Country
        {
            set { country = value; }
            get { return country; }
        }
        private string city;

        //only get
        //public string City => city;

        //only set
        //public string City
        //{
        //    set => city = value;
        //}
        public string City
        {
            set { city = value; } //set=>city= value
            get => city;
        }
        private string street;

        public string Street
        {
            set => street = value;
            get => street;
        }

        private string house;

        public string House
        {
            set => house = value;
            get => house;
        }
        private string _apartment;

        public string Apartment
        {
            set { _apartment = value; }
            get { return _apartment; }
        }
    }
}
