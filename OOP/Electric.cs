using System;
using System.Collections.Generic;
using System.Text;

namespace LabOOP
{
    class Electric : Engine 
    {
        public bool iselectric { get; set; } // Истинно, так как для работы необходима электрическая энергия
        public Electric(int power, int torque, bool iselectric) : base(power, torque)
        {
            this.iselectric = iselectric;
        }
        public override void Enginework()
        {
            Console.WriteLine("Электродвигатель работает");
        }
    }


}
