using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class Calc
    {
        static public void Calculator()
        {
            double firstnumber, secondnumber;
            Console.WriteLine("Введите первое число");
            firstnumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число");
            secondnumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите действие: '+', '-', '*', '/'");
            string act = Console.ReadLine();

            switch (act)
            {
                case "+":
                    Console.WriteLine("Результат вычислений: {0}", firstnumber + secondnumber);
                    break;
                case "-":
                    Console.WriteLine("Результат вычислений: {0}", firstnumber - secondnumber);
                    break;
                case "*":
                    Console.WriteLine("Результат вычислений: {0}", firstnumber * secondnumber);
                    break;
                case "/":
                    if (secondnumber == 0)
                        Console.WriteLine("На ноль делить нельзя");
                    else
                        Console.WriteLine("Результат вычислений: {0}", firstnumber / secondnumber);
                    break;
                default:
                    Console.WriteLine("Данное действие не поддерживается калькулятором");
                break;
            }
        }
    }
}
