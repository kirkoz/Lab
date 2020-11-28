using System;
using System.Collections.Generic;
using System.Text;

namespace LabOOP
{
    class Petrol : Internal_contribution
    {
        public string Petrol_fuel { get; set; }  //Выбрать вид бензина: АИ-92, АИ-95, АИ-98
        public Petrol(int power, int torque, bool isfuel, string petrol) : base(power, torque, isfuel)
        {
            this.Petrol_fuel = petrol;
        }
        public override void Refueling()
        {
            Console.WriteLine("Заправка бензином");
        }

        public override bool Equals(object obj)
        {
            return obj is Petrol temp &&
                   Power == temp.Power &&
                   Torque == temp.Torque &&
                   Isfuel == temp.Isfuel &&
                   Petrol_fuel == temp.Petrol_fuel;
        }
    }
}
