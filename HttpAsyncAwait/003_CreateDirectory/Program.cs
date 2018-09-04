using System;
using System.Collections.Generic;
using System.IO;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_CreateDirectory
{
    //Создание папки для хранения файла изолированного хранилища.

    //C:\Users\Пользователь\AppData\Local\IsolatedStorage\ibcp0myb.wxf\m331usgi.3pr\Url.lnbqogk0vraogxtxtmglvg11memawghl\AssemFiles\SomeDir
    class Program
    {
        static void Main(string[] args)
        {
            //Создание изолированного хранилища уровня .Net сборки.
            IsolatedStorageFile userStorage = IsolatedStorageFile.GetUserStoreForAssembly();

            //Проверить существование директории
            string[] directories = userStorage.GetDirectoryNames("SomeDir");

            if (directories.Length == 0)
            {
                userStorage.CreateDirectory("SomeDir"); // Создаем папку
            }

            //Создание файлового потока с указанием: Директории и Имена файлу, FileMode, объекта хранилища.
            IsolatedStorageFileStream userStream = new IsolatedStorageFileStream(@"SomeDir\UserSettings.set", FileMode.Create, userStorage);

            //StreamWriter - запись данных в поток userStream.
            StreamWriter userWriter = new StreamWriter(userStream);
            userWriter.WriteLine("User Prefs....");
            userWriter.Close();

            //Проверить существование файла.
            string[] files = userStorage.GetFileNames(@"SomeDir\UserSettings.set");

            if (files.Length == 0)
            {
                Console.WriteLine("No data saved for this user");
            }
            else
            {
                //Прочитать данные из потока. Для этого може
                userStream = new IsolatedStorageFileStream(@"SomeDir\UserSettings.set", FileMode.Open, userStorage);

                StreamReader userReader = new StreamReader(userStream);
                string contents = userReader.ReadToEnd();
                Console.WriteLine(contents);
            }

            //Delay
            Console.ReadKey();

            //Привел хороший пример про большую компанию Adobe и про пакеты машинной графики.
            //Людей, кто пишет эти пакеты много - вдруг кто-то напишет что-то плохое а ругать будут  Adobe.
            //Так может случится ЭТИ ПЛАГИНЫ БУДУТ ИМЕТЬ ДОСТУП К ДИСКУ. А если к ПЕСОЧНИЦЕ - то никаких проблем нету.

            //Пользу изолированного хранилища сложно переоценить!
        }
    }
}
