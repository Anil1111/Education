using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_IEqualityComparer
{
    public class InsensitiveComparer : IEqualityComparer
    {
        //идея IEqualityComparer - это снять ответственность по сравнению с других классов(пример с Fish - плохой)
        //потому, что у нас в классе Fish была логика проедения сравнения.
        //Пусть для этого служит IEqualityComparer
        readonly CaseInsensitiveComparer comparer = new CaseInsensitiveComparer();
        public int GetHashCode(object obj)
        {
            return obj.ToString().ToLowerInvariant().GetHashCode();
        }

        public new bool Equals(object x, object y)
        {
            var result = comparer.Compare(x, y) == 0;  //true потому что CaseInsensitiveComparer

            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Создаем коллекцию не чувствительную к регистру символов
            //Как это мы так делали? Мы используем перегрузку конструктора Hashtable, который принимает
            //экземпляр класса, который можно привести к IEqualityComparer и в этом классе
            //и заложили логику про нечуствительность к регистру -> obj.ToString().ToLowerInvariant().GetHashCode(); и CaseInsensitiveComparer

            //var dehash = new Hashtable(); //обычная коллекция
            var dehash = new Hashtable(new InsensitiveComparer()); //коллекция, не чуствительна к регистру

            dehash["First"] = "1st";
            dehash["Second"] = "2nd";
            dehash["Third"] = "3rd";
            dehash["Fourth"] = "4th";
            dehash["fourth"] = "4TH!!!"; //заменит потому, что мы же сделали Hashtable который не чувствителен к регистру
            dehash["foUrth"] = "4TH!!!++++++"; //то же самое

            Console.WriteLine(dehash.Count);

            //Delay
            Console.ReadKey();
        }
    }
}
