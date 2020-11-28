using System;
using System.Collections.Generic;
using System.Text;

namespace LabOOP
{
    abstract class Engine
    {
        public int Power { get; set; } //мощность (л. с.)
        public int Torque { get; set; } //крутящий момент (Н*м)
        public Engine(int power, int torque)
        {
            this.Power = power;
            this.Torque = torque;
        }

        abstract public void Enginework();
    }
}
