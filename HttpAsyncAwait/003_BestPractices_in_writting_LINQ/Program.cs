﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _003_BestPractices_in_writting_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. 
            //Нужно стараться использовать фильтруюущие операторы ДО того, как я произвожу группировку или сортировку.
            //т.е Where и другие ЛУЧШЕ использовать СНАЧАЛА., а потому уже применять GroupBy, OrderBy и т.к
            // Where Select -> GroupBy OrderBy
            //Почему? Когда я буду зывывать опператоры, которые изменяют последовательность они будут обращаться к предидущим
            //и будут работать с ТЕМ РЕЗУЛЬТАТОМ(с тем набором данных), что вернут предидущием операторы.
            //Т.е если в нашем запросе есть операция фильтрации - то пусть она сразу отфильрует, ЧТОБЫ ДРУГИМ ОПЕРАТОРАМ БЫЛО 'легче.'
            //Т.е - если нет необходимости ставить GroupBy/OrderBy сразу - то лучше ставить фильрующие операторы, а потом группирующие.

            //2.
            //Т.к технология LINQ имеет отложенное выполнение - можно лучайно в переменную сохранить ЗАПРОС, а не САМО ЗНАЧЕНИЕ ЗАПРОСА.
            //Нужно понимать, что если больше запрос не нужен, то его лучше сразу переконвертировать в 
            //First/FirstOrDefault/Last/LastOrDefault/ToArray/ToList(кешировать данные) и потом со спокойной душой его использовать.

            //3.
            //LINQ хорошо оптимизирован и может хорошо транслироваться с SQL запросы и нужно больше думать не о том, 
            //как строит запросы,а а том как сделать доступ к данным боллее удобным.

            //4.
            //Иногда есть смысл делать Snapshot`ы данных(т.е не кешировать запрос, а делать его Snapshot`ы)

            //5.
            //Стоит избегать сложных запросов, когда я пишу запросы к удаленному источнику данных.
            //Нужно понимать, что все то долго время, когда будет выполняться сложный расчет запроса - СОЕДИНЕНИЕ К БАЗЕ БУДЕТ ОТКРЫТО.
            //Т.е нужно постараться выносить все сложные операции из LINQ - SQL запроса во внешнюю часть и чтобы запросы содержали
            //как можно меньше логики, не относящиеся к логике получиния доступа.

            //LINQ отностится не только к объектам и к SQL, но ещё и к XML, Entity Framework и т.е.
            //Технология большая.
            //Баги бывают даже в ПО сделанным Microsoft
        }
    }
}
