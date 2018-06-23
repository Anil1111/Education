using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _016_AdditionalTask4
{
    class MyDate
    {
        private readonly DateTime date;

        public MyDate(DateTime date)
        {
            this.date = date;
        }

        public static MyDate operator -(MyDate date1, MyDate date2)
        {
            var timeSpan = date1.date - date2.date;
            var newDate = date1.date.AddDays(timeSpan.Days);
            return  new MyDate(newDate);
        }

        public static MyDate operator +(MyDate date1, MyDate date2)
        {
            var timeSpan = date1.date - date2.date;
            var newDate = date2.date.AddDays(-timeSpan.Days);
            return new MyDate(newDate);
        }

        public static MyDate Add(MyDate date1, MyDate date2) => date1 + date2;
        public static MyDate Sub(MyDate date1, MyDate date2) => date1 - date2;
        public override string ToString()
        {
            return $"Date {date}";
        }
    }
}
