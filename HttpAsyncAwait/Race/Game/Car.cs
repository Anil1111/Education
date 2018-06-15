using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Race.Game
{
    class Car
    {
        private Engine engine;
        private CarBody carBody;

        public Car(Engine engine, CarBody carBody)
        {
            this.engine = engine;
            this.carBody = carBody;
        }

        public void Show()
        {
            carBody.Draw();
        }

        //Ускорение
        public int Accelerate(int delta = 1)
        {
            return engine.Accelerate(delta);
        }

        //Торможение
        public void Braking() { }
    }
}
