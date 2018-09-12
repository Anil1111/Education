using System;
using System.Collections;
using System.Collections.Specialized;
using System.Configuration;

namespace _002_Configuration
{
    class Program
    {
        static void Main(string[] args)
        {
            NameValueCollection allAppSettings = ConfigurationManager.AppSettings;
            int counter = 0;
            IEnumerator settingsEnumerator = allAppSettings.Keys.GetEnumerator();

            while (settingsEnumerator.MoveNext())
            {
                Console.WriteLine($"Key: {allAppSettings.Keys[counter]} Value: {allAppSettings[counter]}");
                counter++;
            }

            //Delay
            Console.ReadKey();
        }
    }
}
