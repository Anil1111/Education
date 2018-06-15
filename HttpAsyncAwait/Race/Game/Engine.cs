using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Race.Game
{
    class Engine
    {
        private bool engineIsDead = false;
        private int currentSpeed = 0;
        private const int maxSpeed = 200;

        public int Accelerate(int delta = 10)
        {
            if (delta < 0)
            {
                throw new ArgumentOutOfRangeException("Для разгона, ускорение должно быть больше нуля!");
            }

            if (engineIsDead)
            {
                return 0;
            }
            else
            {
                currentSpeed += delta;
                //если текущая скорость превышает максимально допустимую.
                if (currentSpeed > maxSpeed)
                {
                    engineIsDead = true;
                    currentSpeed = 0;
                    Console.Title = "Текущая скорость" + currentSpeed;

                    var ex = new EngineIsDeadException("Двигатель перегрелся.");

                    //Устанавливает гиперссылку связываемую с исключением:
                    ex.HelpLink = "http://CarsRace.com/errorService";
                    //добавляем дополнительную информацию о ошибке
                    ex.Data.Add("Время поломки   :", $"Двигательно вышел из строя {DateTime.Now}");
                    ex.Data.Add("Причина поломки :", $"Вы перевысили допустимую скорость - {maxSpeed}. Двигатель сгорел");

                    throw ex;
                }
                else
                {
                    Console.Title = "Текущая скорость = " + currentSpeed;
                    return currentSpeed;
                }
            }
        }
    }
}
