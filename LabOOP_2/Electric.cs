using System;
using System.Collections.Generic;
using System.Text;

namespace LabOOP
{
    class Electric : Engine 
    {
        public const bool Iselectric = true; // Истинно, так как для работы необходима электрическая энергия
        public Electric(int power, int torque) : base(power, torque)
        {
        }

        public override void Enginework()
        {
            Console.WriteLine("Электродвигатель работает");
        }
    }


}
