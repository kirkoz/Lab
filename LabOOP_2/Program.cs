using System;

namespace LabOOP
{
    class Program
    {

        static void Main(string[] args)
        {
            Engine Electric1 = new Electric(100, 250);
            Engine Electric2 = new Electric(100, 250);
            Petrol DVS1_AI98 = new Petrol (78, 134, true, "AI98");
            Petrol DVS2_AI98 = new Petrol (78, 134, true, "AI98");
            Diesel<string> DT1 = new Diesel<string>(80, 135, true, "14.2"); // Обобщенный класс с параметром P. Тип string
            Diesel<double> DT2 = new Diesel<double>(80, 135, true, 14.2); // Обобщенный класс с параметром P. Тип double
            Console.WriteLine(DVS1_AI98.ToString()); // Метод ToString не переопределен для класса бензиновых двигателей
            Console.WriteLine(DT1.ToString()); // Переопределение метода ToString для класса дизельных двигателей
            Console.WriteLine(DT2.ToString()); // Вывод объекта DT2 с такими же параметрами как и у DT1. При этом испольльзовались разные типы: для DT1 - string, для DT2 - double  
            Console.WriteLine(Electric1.Equals(Electric2)); // Метод Equals не переопределен для класса электрических двигателей
            Console.WriteLine(DVS1_AI98.Equals(DVS2_AI98)); // Переопределение метода Equals для класса бензиновых двигателей
        }
    }
}
