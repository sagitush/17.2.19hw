using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17._2._19h.w
{
    interface ISuperHero
    {
        void ActiveSuperPowers();
    }
    interface IFlash:ISuperHero
    {
        void FireLightnings();
    }
    interface IClimb:ISuperHero
    {
        void Climb();
    }
    interface IFly:ISuperHero
    {
        void Fly();
    }
    abstract class Human
    {
        public abstract string Name { get; set; }
        private int age;

        public int Age { get;  }
        public Human(string name,int age)
        {
            this.age = age;
            this.Name = name;
        }
    }
    
}
