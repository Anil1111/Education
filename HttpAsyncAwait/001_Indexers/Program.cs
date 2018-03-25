using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Indexers
{
    //Свойства бывыют:
    //  - обычные
    //  - автоматически реализуемые
    //  - индексируемые свойства
    //Любая из разновидностей свойств может быть и полным, так и не полным(только для записи или только для чтения)
    class MyClass
    {
        private int [] array = new int[5];
        
        //Индексатор (индексируемое свойство)
        public int this[int index] // Когда мы создаем индексатор, мы ему НЕ ДАЕМ НИКАКОГО ИМЕНИ! Имя заменяется ключевым словом this,
        {                          // после которого идет сразу же ТИП ИСПОЛЬЗУЕМОГО ИДЕКСА.В данном случае [int index]
                                   // а перед this мы указываем тип элементов массива
            get //Аксессор
            {
                return array[index];
            }
            set //Мутатор
            {
                if(value!=3) //Тройка в массив не записалась, мы поставили защиту)
                array[index] = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            MyClass my = new MyClass();

            my[0] = 1;   // мы к экземпляру обращаемся как буд-то он 
            my[1] = 2;   // является массивом, НО НЕ НУЖНО СМУЩАТЬСЯ.
            my[2] = 3;   // В ЭТОМ ОБЬЕКТЕ ЖИВЕТ ИНДЕКСАТОР
            my[3] = 4;   // У Индексатора нету имени.
            my[4] = 5;

            Console.WriteLine(my[0]);
            Console.WriteLine(my[1]);
            Console.WriteLine(my[2]);
            Console.WriteLine(my[3]);
            Console.WriteLine(my[4]);

            //Delay
            Console.ReadKey();
        }
    }
}
