using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XML_serializer
{
    class Program
    {
        public static List<List<string>> GetExpectedRows(int x, int y)
        {
            var list = new List<List<string>>();
            for (int i = 1; i < x + 1; i++)
            {
                list.Add(new List<string>());
                for (var j = 1; j < y + 1; j++)
                {
                    list[i - 1].Add((i * j).ToString());
                }
            }

            return list;
        }

        private static void SerializeCollection(string filename)
        {
            var list = GetExpectedRows(20, 20);
            // Note that only the collection is serialized -- not the   
            // CollectionName or any other public property of the class.  
            XmlSerializer x = new XmlSerializer(typeof(List<List<string>>));
            TextWriter writer = new StreamWriter(filename);
            x.Serialize(writer, list);
        }
        static void Main(string[] args)
        {
            SerializeCollection("coll.xml");
        }
    }
}
