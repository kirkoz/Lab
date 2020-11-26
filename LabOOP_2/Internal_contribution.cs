using System;
using System.Collections.Generic;
using System.Text;

namespace LabOOP
{
    class Internal_contribution : Engine
    {
        public bool Isfuel; // Истинно, так как для работы ДВС необходимо топливо

        public Internal_contribution(int power, int torque, bool isfuel) : base(power, torque)
        {
            this.Isfuel = isfuel;
        }

        public override void Enginework()
        {
           Console.WriteLine("ДВС работает");
        }

        public virtual void Refueling()
        {
            Console.WriteLine("Заправка топливом");
        }
    
    }
}
