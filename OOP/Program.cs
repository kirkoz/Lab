using System;

namespace LabOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Engine DVS1 = new Internal_contribution(50, 150, true);
            Engine Electric1 = new Electric(100, 250, true);
            Internal_contribution DVS2 = new Internal_contribution(70, 120, true);
            Petrol DVS_AI98 = new Petrol(78, 134, true, "AI98");
            Diesel DT = new Diesel(80, 135, true, true);
            DVS1.Enginework();
            Electric1.Enginework();
            DVS2.Refueling();
            DVS_AI98.Refueling();
            DT.Refueling();
        }
    }
}
