using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewTask_Char
{
    class Program
    {
        static string GetUniqueCharacters(string word)
        {
            var chars = word.ToCharArray();
            var charsToReturn = new List<char>();
            //foreach (var @char in chars)
            //{
            //    var presentInWordTimes = chars.Count(ch =>
            //        ch.ToString().ToLowerInvariant() == @char.ToString().ToLowerInvariant());
            //    if (presentInWordTimes == 1)
            //    {
            //        charsToReturn.Add(@char);
            //    }
            //}

            Func<char, bool> isUnique = ch =>
                                            chars.Count(c => 
                                                            c.ToString().ToLowerInvariant() == ch.ToString().ToLowerInvariant()) 
                                                        == 1;

            var charsUniq = chars.Where(isUnique);


            return new string(charsUniq.ToArray());
        }

        static void Main(string[] args)
        {
            var a = GetUniqueCharacters("VovA");
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
