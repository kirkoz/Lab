using System;
using System.Collections.Generic;
using System.Text;

namespace LabOOP
{
    class Petrol : Internal_contribution
    {
        public string Petrol_fuel { get; set; } //Выбрать вид бензина: АИ-92, АИ-95, АИ-98
        public Petrol(int power, int torque, bool isfuel, string petrol) : base(power, torque, isfuel)
        {
            this.Petrol_fuel = petrol;
        }
        public override void Refueling()
        {
            Console.WriteLine("Заправка бензином");
        }

        public override string ToString()
        {
            return String.Format("Бензиновый двигатель с параметрами: мощность - {0}, крутяший момент - {1}, " +
                "заправка топливом - {2}, вид топлива - {3}", Power, Torque, Isfuel, Petrol_fuel);
        }
    }
}
