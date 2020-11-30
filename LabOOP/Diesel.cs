using System;
using System.Collections.Generic;
using System.Text;

namespace LabOOP
{
    class Diesel : Internal_contribution
    {
        public const bool Isdiesel = true; // Истинно, так как для работы дизельного двигателя нужно ДТ топливо
        private int _compr_ratio;
        public int Compr_ratio
        {
            get => _compr_ratio;
            set
            {
                if (value > 0)
                    _compr_ratio = value;
                else
                    throw
                        new ArgumentOutOfRangeException("compr_ratio", "Степень сжатия не может быть меньше или равна 0");
            }
        } //Степень сжатия топлива 
        public Diesel(int power, int torque, bool isfuel, int compr_ratio) : base(power, torque, isfuel)
        {
            this.Compr_ratio = compr_ratio;
        }

        public override void Refueling()
        {
            Console.WriteLine("Заправка ДТ");
        }
    }
}