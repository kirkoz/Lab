using System;
using System.Linq;
using System.Collections.Generic;

namespace LabOOP
{
    class Program
    {
        static void Result(List<Petrol> y)
        {
            y.ForEach(delegate (Petrol b)
            {
                Console.WriteLine(b);
            });
            Console.WriteLine("-----------------");
        }
        static void Main(string[] args)
        {
            try
            {
                Diesel DT = new Diesel(85, 200, true, -14); //Создание объекта DT, в котором параметр "Степень сжатия" <=0.
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Petrol DVS1 = new Petrol(78, 134, true, "AI90");
                Petrol DVS2 = new Petrol(80, 150, true, "AI90");
                Petrol DVS3 = new Petrol(78, 130, true, "AI92");
                Petrol DVS4 = new Petrol(80, 134, true, "AI95");
                Petrol DVS5 = new Petrol(85, 150, true, "AI92");
                Petrol DVS6 = new Petrol(90, 130, true, "AI98");
                List<Petrol> DVS = new List<Petrol>() { DVS1, DVS2, DVS3, DVS4, DVS5, DVS6 };
                List<Petrol> DVS_sort = (from x in DVS
                                         where x.Power >= 80
                                         orderby x.Petrol_fuel
                                         select x).ToList(); 
                Result(DVS);
                Result(DVS_sort); //Вывод отсортированного списка DVS_sort, где мощность >= 80, при этом результат отсортирован по параметру Petrol_fuel
            }


        }
    }
}
