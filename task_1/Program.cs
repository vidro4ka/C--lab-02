using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    class Pupil
    {
        public virtual void Study() { }
        public virtual void Read() { }
        public virtual void Write() { }
        public virtual void Relax() { }
    }
    class ExcelentPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("I can study exelent!");
        }
        public override void Read()
        {
            Console.WriteLine("I can read exelent");
        }
        public override void Write()
        {
            Console.WriteLine("I can write exelent");
        }
        public override void Relax()
        {
            Console.WriteLine("I relax bad");
        }
    }
    class GoodPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("I can study well!");
        }
        public override void Read()
        {
            Console.WriteLine("I can read well");
        }
        public override void Write()
        {
            Console.WriteLine("I can write well");
        }
        public override void Relax()
        {
            Console.WriteLine("I relax well");
        }
    }
    class BadPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("I study bad!");
        }
        public override void Read()
        {
            Console.WriteLine("I read bad");
        }
        public override void Write()
        {
            Console.WriteLine("I can write bad");
        }
        public override void Relax()
        {
            Console.WriteLine("I relax exelent");
        }
    }
    class ClassRoom
    {
        private Pupil[] p = new Pupil[4];
        
        public ClassRoom(params Pupil[] _pupils)
        {
            for(int i=0;i<_pupils.Length;++i)
            {
                if(_pupils!=null)
                {
                    p[i] = _pupils[i];
                }
            }
        }

        public void InfoClassRoom()
        {
            for(int i=0;i<4;++i)
            {
                if (p[i] != null)
                {
                    Console.WriteLine("\n" + p[i].GetType() + ":\n");
                    p[i].Study();
                    p[i].Read();
                    p[i].Write();
                    p[i].Relax();
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ClassRoom cRoom_1 = new ClassRoom(new ExcelentPupil(), new GoodPupil(), new BadPupil(), new BadPupil());
            cRoom_1.InfoClassRoom();
            Console.WriteLine("\n\n\n");
            ClassRoom cRoom_2 = new ClassRoom(new ExcelentPupil(), new GoodPupil(), new BadPupil());
            cRoom_2.InfoClassRoom();
            Console.WriteLine("\n\n\n");
            ClassRoom cRoom_3 = new ClassRoom(new ExcelentPupil(), new GoodPupil());
            cRoom_3.InfoClassRoom();
            Console.ReadLine();
        }
    }
}
