using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Logic
{
    class Program
    {
        static void Main(string[] args)
        {

            bool operand1 = false, operand2 = false,result = false;

            #region Коньюнкция
            //Таблица истинности для Конъюнкции (И) - && - [AND]

            //Если хоть 1 из оперантов имеет значение false - вся конструкция имеет значение false. Иначе - true.

            // false & false = false             true & false = false  // Используя эти правила в столбик выполняем
            // false & true = false              true & true = true

            operand1 = true;                      //true
            operand2 = false;                     //false 
            result = operand1 && operand2;        //false  

            Console.WriteLine("{0} AND {1} = {2}", operand1, operand2, result);
            #endregion


            #region Дизъюнкция
            //Таблица истинности для Дизъюнкции (ИЛИ) - || - [OR]

            //Если хоть 1 из оперантов имеет значение true - вся конструкция имеет значение true. Иначе - false.

            // false | false = false               true  | false = true   // Используя эти правила в столбик выполняем
            // false | true  = true                true  | true  = true 

            operand1 = true;                      //true 
            operand2 = false;                     //false  
            result = operand1 || operand2;         //true    

            Console.WriteLine("{0} OR {1} = {2}", operand1, operand2, result);
            #endregion

            #region Исключающее ИЛИ
            //Таблица истинности для Исключающего ИЛИ  - ^ - [XOR]

            //Если операнды имеют одинаковое значение - результат false,
            //Если операнды разные - true

            // false ^ false = false             true ^ false = true  // Используя эти правила в столбик выполняем
            // true ^ true = false               false ^ true = true

            operand1 = true;                     //true
            operand2 = false;                    //false 
            result = operand1 ^ operand2;        //true   

            Console.WriteLine("{0} XOR {1} = {2}", operand1, operand2, result);
            #endregion

            #region Побитовое Отрицание
            //Таблица истинности для Отрацания (НЕТ)  - ! - [NOT]

            // !false = true;    
            // !true = false            

            operand1 = true;
            result = !operand1;

            Console.WriteLine("NOT {0} = {1}", operand1, result);
            #endregion
            
            //Delay
            Console.ReadLine();
        }
    }
}
