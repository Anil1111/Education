﻿namespace _004_AboutAssembly
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Класс Assembly представляет сборку, которая является модулем
             с возможностью многократного использования, поддержкой версий 
             и встроенным механизмом описания общеязыковой исполняющей среды.

            Сборки бывают ОДНОФАЙЛОВЫЕ и МНОГОФАЙЛОВЫЕ. 
            Однофайловая - моя первая программа Hello World - тот .exe`шник - это и есть ОДНОФАЙЛОВАЯ СБОРКА!
            Там просто содержится байт код который получился после того, как компилятор(csc.exe CSharp compiler) переделал мой код в байт код.
            А CLR(она же виртуальная машина) уже преобразовывает байт код в машинный код, который понимаем центральный процессор x86 + x87(устройство с плавающей точкой)
            А Это делается для того, чтобы УПРОСТИТЬ ПОДХОДЫ В ПРОГРАМИРОВАНИИ и чтобы не создавать ОБЪЕКТНО-ОРИЕНТИРОВАННЫЕ процессоры, которые будут стоить как дорогая машина.

            Многофайловая сборка - это .exe`шник, возле которого лежат dll, могут лежать картинки, аудиофайлы, видео и т.д.

            Type - описывает класс или структуру, а Assembly - описывает целую сборку.

            ОДНОФАЙЛОВАЯ СБОРКА - SomeAssemble.exe СОДЕРЖИТ:
             - Метаданные сборки (Манифест) - манифест содержит описание тех библиотек, которые использутся в сборке (НАПРИМЕР пространство имен System)
             - Метаданные типов - в exe`шинке содержится информация о методах, свойствах, событиях, которые я создал и т.д НАПРИМЕР - я ж храню информации о себе - свое имя и т.д
             - Байт код
             - Ресурсы - например - картинки, музыка и т.д - они могут быть вбилджены прямо в exe файл, НО ОН ТОГДА БУДЕТ ТЯЖЕЛЫЙ, А ЭТО ПЛОХО.

            МНОГОФАЙЛОВАЯ СБОРКА - SomeAssemble.exe СОДЕРЖИТ:
             - Метаданные сборки (Манифест) -ссылки на dll`ки, которые лежат рядом, и описание тех библиотек, которые использутся в сборке (НАПРИМЕР пространство имен System)
             - Метаданные типов - в exe`шинке содержится информация о методах, свойствах, событиях, которые я создал и т.д НАПРИМЕР - я ж храню информации о себе - свое имя и т.д
             - Байт код
             - Ресурсы - например - картинки, музыка и т.д - они могут быть вбилджены прямо в exe файл, НО ОН ТОГДА БУДЕТ ТЯЖЕЛЫЙ, А ЭТО ПЛОХО.
             Foo.netmode содержит:
              - МОДУЛИ - используются тогда, когда идут разноязыковые проекты. Модули невозможно использовать в Visual Studio - нужно самому писать файлы,
             где будут команды разным компиляторам, вспомагательным программам и т.д.
             Graph.bmp содержит
             - Ресурсы

            Метаданные сборки(манифест) состоят из описания сборки: имя, версия, строгое имя, информация о культуре.

            Метаданные типов включают пространство имен и имя типа, члены типа и переметры, если имеются.
            Байт код (псевдокод) - машинно-независимый код низкого уровня, генерируемый транслятором и исполняемый интерпретатором. 
            Большинство инструкций байт-кода эквиваленты одной или нескольким командам ассемблера. Трансляция в байт-код занимает
            промежуточное положение между компиляцией в машинный код код и интерпретацией.

            Байт-код называется так, потому что длина каждого кода ОПЕРАЦИИ - один байт, но длина кода КОМАНДЫ
            различна. Каждая инстррукция представляет собой однобайтовый код операции от - до 255, за которым 
            следуют такие перементы как регистры или адреса памяти.

            Ресурсы - это объекты, которые используются кодом: строки, изображения, различные файлы.
             */
        }
    }
}
