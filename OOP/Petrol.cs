using System;
using System.Collections.Generic;
using System.Text;

namespace LabOOP
{
    class Petrol : Internal_contribution
    {
        public string petrol { get; set; } //Выбрать вид бензина: АИ-92, АИ-95, АИ-98
        public Petrol(int power, int torque, bool isfuel, string petrol) : base(power, torque, isfuel)
        {
            this.petrol = petrol;
        }
        public override void Refueling()
        {
            Console.WriteLine("Заправка бензином");
        }
    }
}
