﻿namespace _000_About_Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            //Механизмы, которые позволяют извлекать информацию о себе, или о ком-то другом - называются РЕФЛЕКСИЕЙ.

            //Пример: нам дали dll библиотеку, исходных кодов у нас нету, но мы хотим посмотреть какие члены есть в
            //классе(ах , в одной dll может быть много классов - в конце этого урока будет пример)

            //В делагат мы не можем заглягуть т.к он нативен.

            //dotPeek использует механизмы рефлексии и показует коды из .exe файлов.

            //Рефлексия (отражение) - это процесс, во время которого программа может отслеживать и 
            //модифицировать собственную структуру и поводение во время выполнение.

            //Парадигма программирования, положенная в основу отражения, называется рефлексивным программированием.
            //Это один из видов МЕТАпрограммирования.
            //При помощи рефлексии мы можем писать САМОМОДИФИЦИРУЮЩИЕСЯ ПРОГРАММЫ(которые меняют содержимое своего тела)
            
            //МЕТАкод, МЕТАкласс, МЕТАфайл, МЕТАинструмент -> слово МЕТА говорит, что программист работает с КОДОМ КАК С ДАННЫМИ.
            //dotPeek - МЕТА инструмент.
            //dotPeek и Visual Studio - это мета инструменты!

            //System.Reflection - пространство имен, которое содержит классы для применения рефлексии
        }
    }
}
