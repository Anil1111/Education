using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Task1
{
    public class ClassRoom
    {
        Pupil[] pupils = new Pupil[4];
        Random rnd = new Random();

        //у нас экземпляры автоматически приводятся к типу Pupil, но методы
        //которые мы переопределили уже не поменяются!!
        //т.е я написал (Pupil p1, Pupil p2) т.к у Exelent,Good,Bad pulils наследуются от Pupil
        // и мне реально удобно так писать, я же не знаю какой именно (Exelent,Good или Bad) я буду передавать
        //в конструктор. Дак пусть он в конструкторе приводится к базовому классу, а методы то я уже переопределил!
        public ClassRoom(Pupil p1, Pupil p2) 
        {
            pupils[0] = p1;
            pupils[1] = p2;
            pupils[2] = GeneratePupil();
            pupils[3] = GeneratePupil();
        }
        public ClassRoom(Pupil p1, Pupil p2, Pupil p3)
        {
            pupils[0] = p1;
            pupils[1] = p2;
            pupils[2] = p3;
            pupils[3] = GeneratePupil();
        }
        public ClassRoom(Pupil p1, Pupil p2, Pupil p3, Pupil p4)
        {
            pupils[0] = p1;
            pupils[1] = p2;
            pupils[2] = p3;
            pupils[3] = p4;
        }

        private Pupil GeneratePupil()
        {
            var amountOfpupils = rnd.Next(1, 3);
            switch (amountOfpupils)
            {
                case 1: return new ExelentPupil();
                case 2: return new GoodPupil();
                case 3: return new BadPupil();
            }
            return new BadPupil();
        }

        public void Study()
        {
            foreach (var pupil in pupils)
            {
                pupil.Study();
            }
        }
        public void Read()
        {
            foreach (var pupil in pupils)
            {
                pupil.Read();
            }
        }
        public void Relax()
        {
            foreach (var pupil in pupils)
            {
                pupil.Relax();
            }
        }
        public void Write()
        {
            foreach (var pupil in pupils)
            {
                pupil.Write();
            }
        }
    }
}
