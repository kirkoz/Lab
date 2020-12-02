using System;

namespace Calc
{
    public static class Calc
    {
        static public int Plus(int a, int b)
        {
            return a + b;
        }

        static public int Diffrence(int a, int b)
        {
            return a - b;
        }

        static public int Мultiplication(int a, int b)
        {
            return a * b;
        }

        static public int Division(int a, int b)
        {
            if (b == 0)
                throw new System.DivideByZeroException();
            return a / b;
        }
    }
}
