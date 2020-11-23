using System;
using System.Collections.Generic;
using System.Text;

namespace LabOOP
{
    abstract class Engine
    {
        public int power { get; set; } //мощность (л. с.)
        public int torque { get; set; } //крутящий момент (Н*м)
        public Engine(int power, int torque)
        {
            this.power = power;
            this.torque = torque;
        }

        abstract public void Enginework();
    }
}
