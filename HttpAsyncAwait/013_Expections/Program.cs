using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _013_Expections
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                try
                {
                    try
                    {
                        throw new Exception("Exception");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Catch 1: " + e.Message);
                        throw; //thow; - пробрасывает пойманное исключение дальше.
                    }
                    finally // отработает, даже не смотря на то, что в catch было проброшенно ещё одно исключение.
                    {
                        Console.WriteLine("Finally 1: ");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Catch 2: " + e.Message);
                    throw; //это исключание "перезатирается" исключением ниже:  throw new Exception("New Exception");
                }
                finally // отработает, даже не смотря на то, что в catch было проброшенно ещё одно исключение.
                {
                    Console.WriteLine("Finally 2:");
                    throw new Exception("New Exception"); //создаем новое исключение. 
                }
            }
            catch (Exception e)// в блок catch попадет исключение throw new Exception("New Exception"); т.к оно брошено последним.
            { //throw; - не попадет
                Console.WriteLine("Catch 3: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Finally 3: ");
            }

            //Delay
            Console.ReadKey();
        }
    }
}
