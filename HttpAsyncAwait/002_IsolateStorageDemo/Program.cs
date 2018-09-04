using System;
using System.Collections.Generic;
using System.IO;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_IsolateStorageDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Создание изолированного хранилища уровня .Net сборки.
            IsolatedStorageFile userStorage = IsolatedStorageFile.GetUserStoreForAssembly();

            //Создание файлового потока с уазанием: Имена файла, FileMode, объекта хранилища.  "UserSettings.set" - путь к файлу, который
            //мы создаем в хранилище и куда мы будем собственно писать.
            IsolatedStorageFileStream userStream = new IsolatedStorageFileStream("UserSettings.set", FileMode.Create, userStorage);

            //StreamWriter - запись данных в поток userStream.
            StreamWriter userWriter = new StreamWriter(userStream);
            userWriter.WriteLine("User Prefs...testtesttest");
            userWriter.Close();

            //Проверить, если файл существует
            string[] files = userStorage.GetFileNames("UserSettings.set");

            if (files.Length == 0)
            {
                Console.WriteLine("No data saved for this user");
            }
            else
            {
                //Прочитать данные из потока. Для этого може
                userStream = new IsolatedStorageFileStream("UserSettings.set", FileMode.Open, userStorage);

                StreamReader userReader = new StreamReader(userStream);
                string contents = userReader.ReadToEnd();
                Console.WriteLine(contents);
            }

            //Delay
            Console.ReadKey();
        }
    }
}
