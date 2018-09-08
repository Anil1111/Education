using System;
using System.Collections.Generic;
using System.IO;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_IsolateStorageDemo
{
    //Click Once - тип приложений, которые могут установиться и запуститься после того, как пользователь кликнет по ссылке на веб странице.
    //Это хороший пример, когда нам нужна песочница!

    //Песочница - это механизм, для езопасного исполнения программ. Как правило, песочницы использут
    //ждя запуска НЕПРОВЕРЕННОГО КОДА из НЕИЗВЕСТНЫХ источников или для тестиования кода программ, которые потенциально 
    //могут повредить всю систему или конфигурацию.
    //А вот например у Google приложений, Oracle, Java etc, есть сертификаты безопасности.
    //Эти копании дружат с Microsoft и если у процграммы есть сертификат безопасности, то песчница не используется.

    //Что такое песочница - это ситуация, когда на жестком диске выделяется место.
    //И это место строится по такому образу, что оно имитирует целу полную файловую систему(просто маленькую).
    //И вирус подумает, что он добрался до места назначения и начнет твоить свои грязные дела и не пойдет дальше.
    //И в конечнос итоге - настоящие файлы останутся живы и незашифрованы.
    class Program
    {
        //Работа с изолированным хранилищем.

        //Путь к хранилищу
        //C:\Users\Пользователь\AppData\Local\IsolatedStorage  - сначала папки IsolatedStorage не было.
        //Появилась после того, как я выполнился. Это системная папка.

        static void Main(string[] args)
        {
            //Создание изолированного хранилища уровня приложения. [В данном примере не используется]
            IsolatedStorageFile machineStorage = IsolatedStorageFile.GetMachineStoreForAssembly();//для всего компьютера(следственно для всех пользователей)

            //Создание изолированного хранилища уровня .Net сборки.
            IsolatedStorageFile userStorage = IsolatedStorageFile.GetUserStoreForAssembly();//для этого конкретного пользователя

            //Создание файлового потока Для доступа к изолорованному хранилищу(чтобы работать с ним).
            //с указанием: Имена файла, FileMode, объекта хранилища.  "UserSettings.set" - путь к файлу относительно песочницы(в 3м примере будет немного другой путь)
            //КОРОЧЕ: мы описываем все как обычно, создаем файлик, он на возвращает объект чтобы работать с этим файлом,
            //мы можем сделать StreamWriter из этого объекта. И плюсь ко всему ЭТО ВСЕ ПРОИСХОДИТ В ИЗОЛИРОВАННОМ ХРАНИЛИЩЕ. И так, все как с обычными файлами.
            IsolatedStorageFileStream userStream = new IsolatedStorageFileStream("UserSettings.set", FileMode.Create, userStorage);
            //после выполнения в хранилищ будет файл UserSettings.Set. 
            //Пример адресагде находится файл UserSettings.Set. :
            //C:\Users\Пользователь\AppData\Local\IsolatedStorage\q015f2zo.sqa\yk2iqdiy.qtw\Url.lugllgruzqfkqwrz4pybh3nauqbmkqi5\AssemFiles


            //StreamWriter - запись данных в поток userStream. Можно было бы использовать и IsolatedStorageFileStream, но StreamWriter удобнее.
            StreamWriter userWriter = new StreamWriter(userStream);
            userWriter.WriteLine("User Prefs...testtesttest");
            userWriter.Close();
        }
    }
}
