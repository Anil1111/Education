using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Sequence_in_New_Order
{
    class Program
    {
        private static string GetLastWord(string words) => words.Substring(words.LastIndexOf(' ') + 1);
        private static string GetFirstWord(string words) => words.Substring(0, words.IndexOf(' '));
        static void Main(string[] args)
        {
            //Sequence in New Order
            //Some methods return a new sequence where all or a portion of the original sequence is included, but in a different order.
            //These methods include: Distinct, Except, GroupBy, GroupJoin, Intersect, Join, OrderBy, OrderByDescending, Reverse, ThenBy, ThenByDescending, and Union.

            //Distinct
            //The Distinct method selects unique items from a sequence. When the same item occurs multiple in a sequence,
            //only ine instance of the item is included.
            string[] stooges = { "Moe Howard", "Larry Fine", "Curly Howard", "Moe Howard" };
            var a = stooges.Distinct(); //returns: Moe Howard, Larry Fine, Curly Howard

            //Except
            //The Except method gets the unique items from a sequence that are not present in another sequence.
            string[] citrus = { "grapefruit", "lemon", "lime", "orange" };
            string[] fruits = { "banana", "banana", "lemon", "lime", "lime" };
            var b = fruits.Except(citrus); //returns: banana

            //GroupBy
            //The GroupBy method groups items in a sequence by a unique trait(or key). It Produces a sequence of groopings,
            //where each is itself a sequence, with associated key value.
            string[] stoogess = { "Moe Howard", "Larry Fine", "Curly Howard", "Moe Howard" };
            var c = stoogess.GroupBy(name => GetLastWord(name));
            // GroupBy: [Key=Howard, Items=Moe Howard, Curly Howard, Moe Howard], [Key=Fine, Items=Larry Fine]

            //GroupJoin !!!
            //The GroupJoin method os similar to SQL LEFT OUTER JOIN.
            //var courseFaculty = courses.GroupJoin(faculty, course => course.Id, teacher => teacher.CourseId,
            //(course, teachers) => new { Course = course.Name, Teachers = teachers });

            //Intersect
            //The Intersect method gets the distinct items common to two sequences.
            string[] citrus1 = { "grapefruit", "lemon", "lime", "orange" };
            string[] fruits1 = { "banana", "banana", "lemon", "lime", "lime" };
            var d = fruits1.Intersect(citrus1); //returns lemon, lime

            //Join !!!!
            //The Join method is similar to SQL LEFT INNER JOIN.
            //var courseTeacher = courses.Join(faculty, course => course.Id, teacher => teacher.CourseId,
            //(course, teacher) => new { Course = course.Name, Teacher = teacher.Name });

            //OrderBy
            //The OrderBy method sorts the sequence, in ASCENDING order by a key value obtained from each item in the sequence.
            string[] stooges3 = { "Moe Howard", "Larry Fine", "Curly Howard", "Moe Howard" };
            //все равно, что  var e = stooges3.OrderBy(GetFirstWord);
            //here is a key which helps to order GetFirstWord(name)
            var e = stooges3.OrderBy(name => GetFirstWord(name)); //returns: Curly Howard, Larry Fine, Moe Howard, Moe Howard

            //OrderByDescending
            //The OrderBy method sorts the sequence, in ASCENDING order by a key value obtained from each item in the sequence.
            string[] stooges4 = { "Moe Howard", "Larry Fine", "Curly Howard", "Moe Howard" };
            //все равно, что  var e = stooges3.OrderByDescending(GetFirstWord);
            //here is a key which helps to order GetFirstWord(name)
            var f = stooges3.OrderByDescending(name => GetFirstWord(name)); //returns: Moe Howard, Moe Howard, Larry Fine, Curly Howard

            //Reverse
            //The Reverce method reverses the order of the sequence
            string[] stooges5 = { "Moe Howard", "Larry Fine", "Curly Howard", "Moz Howard", "Moa Howard" };
            var g = stooges5.Reverse(); //returns "Moe Howard", "Curly Howard", "Larry Fine", "Moe Howard"

            //ThenBy
            //The ThenBy method is somewhat unique in that it can only be applied to an IOrderedEnumerable<T>,
            //generally returned from one of the following methods: OrderBy, OrderByDescending, ThenBy, or ThenByDescending. 
            //This method provides the capability to sort a sequence, in ASCENDING order, by an additional key value, also obtained from each item in the sequence.
            //Т.е если у меня есть одинаковые списки(допустим из 2х слов), то можно сначала по одному слову отсортировать с помощью OrderBy, а потом подругому с помощью ThenBy
            var z = stooges5.OrderBy(name => GetLastWord(name))
                .ThenBy(name => GetFirstWord(name)); //ThenBy: Larry Fine, Curly Howard, Moa Howard, Moe Howard,  Moz Howard

            //ThenByDescending
            //The ThenByDescending method is somewhat unique in that it can only be applied to an IOrderedEnumerable<T>,
            //generally returned from one of the following methods: OrderBy, OrderByDescending, ThenBy, or ThenByDescending. 
            //This method provides the capability to sort a sequence, in DESCENDING order, by an additional key value, also obtained from each item in the sequence.
            //Т.е если у меня есть одинаковые списки(допустим из 2х слов), то можно сначала по одному слову отсортировать с помощью OrderBy, а потом подругому с помощью ThenByDescending
            var z1 = stooges5.OrderBy(name => GetLastWord(name))
                .ThenByDescending(name => GetFirstWord(name)); // ThenByDescending: Larry Fine, Moz Howard, Moe Howard, Moa Howard, Curly Howard

            //Union
            //The Union method gets the distinct items resulting from the combination of two sequences.
            string[] citrus8 = { "grapefruit", "lemon", "lime", "orange" };
            string[] fruits8 = { "banana", "banana", "lemon", "lime", "lime" };
            var t = citrus8.Union(fruits8); //returns grapefruit, lemon, lime, orange, banana
        }
    }
}
