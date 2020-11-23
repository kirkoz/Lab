using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class Array
    {
        static public void GetArray()
        {
            int n;
            Console.Write("Введите число элементов массива: ");
            n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Введите arr[{0}] ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Элементы массива:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("arr[{0}] = {1}", i, arr[i]);
            }
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Сортировка массива по возрастанию");
            int buff;
            for (int i = 0; i < n-1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        buff = arr[i];
                        arr [i] = arr [j];
                        arr[j] = buff;
                    }
                }
            }
            Console.WriteLine("Отсортированный массив:");
            for (int i = 0; i < n; i++)
            {
              Console.WriteLine("arr[{0}] = {1}", i, arr[i]);
            }
        }
    }
}
