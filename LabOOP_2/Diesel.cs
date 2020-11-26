using System;
using System.Collections.Generic;
using System.Text;

namespace LabOOP
{
    class Diesel <P> : Internal_contribution
    {
        public const bool Isdiesel = true; // Истинно, так как для работы дизельного двигателя нужно ДТ топливо
        public P Compr_ratio { get; set; } // Степень сжатия топлива
        public Diesel(int power, int torque, bool isfuel, P compr_ratio) : base(power, torque, isfuel)
        {
            this.Compr_ratio = compr_ratio;
        }

        public override void Refueling()
        {
            Console.WriteLine("Заправка ДТ");
        }

        public override string ToString()
        {
            return String.Format("Дизельный двигатель с параметрами: мощность - {0}, крутяший момент - {1}, " +
                "заправка топливом - {2}, ДТ-топливо - {3}, Степень сжатия - {4}", Power, Torque, Isfuel, Isdiesel, Compr_ratio);
        }
    }
}