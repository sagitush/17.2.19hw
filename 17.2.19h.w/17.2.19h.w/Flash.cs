using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17._2._19h.w
{
    class Flash:Human,IFlash
    {
        public int Voltage { get;private set; }

        public Flash(int voltage,int age,string name):base(name,age)
        {
            Voltage = voltage;
        }
       public void FireLightnings()
        {
            Console.WriteLine("fire,fire");
        }
        public override string Name
        {
            get
            {
                return this.Name;
            }
            set
            {
                if (Name != null)
                {
                    this.Name = Name;

                }

            }

        }       
    }
}
