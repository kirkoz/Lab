using System;
using System.Collections.Generic;
using System.Text;

namespace LabOOP
{
    class Diesel : Internal_contribution
    {
        public bool isdiesel { get; set; } // Истинно, так как для работы дизельного двигателя нужно ДТ топливо
        public Diesel(int power, int torque, bool isfuel, bool isdiesel) : base(power, torque, isfuel)
        {
            this.isdiesel = isdiesel;
        }
        public override void Refueling()
        {
            Console.WriteLine("Заправка ДТ");
        }
    }
}