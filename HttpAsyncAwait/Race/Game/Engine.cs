using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Race.Game
{
    class Engine
    {
        private bool engineIsDeal = false;
        private int currentSpeed = 0;
        private const int maxSpeed = 200;

        public int Accelerate(int delta = 10)
        {
            if (delta < 0)
            {
                throw new ArgumentOutOfRangeException("Для разгона, ускорение должно быть больше нуля!");
            }

            if (engineIsDeal)
            {
                return 0;
            }
            else
            {
                currentSpeed += delta;
                //если текущая скорость превышает максимально допустимую.
                if (currentSpeed > maxSpeed)
                {
                    engineIsDeal = true;
                    currentSpeed = 0;
                    Console.Title = "Текущая скорость" + currentSpeed;

                    EngineIsDeadException ex = new EngineIsDeadException("Двигатель перегрелся.");

                    //Устанавливает гиперссылку связываемую с исключением:
                }
            }
        }
    }
}
