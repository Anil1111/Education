using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_Anonymous_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            //Anonymous types were introduced in .NET 3.0 to accompany LINQ.
            //They provide a syntactical short cut so that a type can be both be declared and 
            //initialized in a single step.With anonymous types, the following is possible:

            var myAnonymousType = new { Id = 1, Name = "Me" };
            Console.WriteLine(myAnonymousType.Name);

            //Prior to .NET 3.0, to achieve this same goal we would first need to define the type:

            //private class NotSoAnonymousName
            //{
            //    private string name;
            //    private int id;

            //    public int Id { get { return id; } set { id = value; } }
            //    public string Name { get { return name; } set { name = value; } }

            //    public override string ToString()
            //    {
            //        return string.Format("{{ Id = {0}, Name = {1} }}", Id, Name);
            //    }
            //}

            //And then reference the type by name:

            //NotSoAnonymousName notSoAnonymousType = new NotSoAnonymousName { Id = 1, Name = "Me" };
            //Console.WriteLine(myNotSoAnonymousType);

            //The class declaration is especially verbose, because auto-implemented properties, 
            //expression bodied members, and string interpolation were also unavailable at that time.
            //For reference, had they been available, the class declaration could have at least been shortened to:

            //private class NotSoAnonymousName
            //{
            //    public int Id { get; set; }
            //    public string Name { get; set; }
            //    public override string ToString() =>
            //        $"{{ Id = {Id}, Name = {Name} }}";
            //}
        }
    }
}
