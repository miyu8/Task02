using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Массивы;

namespace Массивы
{
    class Program
    {
        static int size;
        static int Max(int[,] mas)
        {
            int max = mas[0, 0];
            foreach (int i in mas)
                if (max < i) max = i;
            return max;
        }
        static int Min(int[,] mas)
        {
            int min = mas[0, 0]; ;
            foreach (int i in mas)
                if (min > i) min = i;
            return min;
        }
        static int[,] MinMax(int[,] mas)
        {
            int max, min;
            min = max = mas[0, 0];
            int minsize, minsize2, maxsize, maxsize2;
            minsize = minsize2 = maxsize = maxsize2 = 0;
            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)

                {
                    if (max < mas[i, j])
                    {
                        max = mas[i, j];
                        minsize = i;
                        minsize2 = j;
                    }
                    if (min > mas[i, j])
                    {
                        min = mas[i, j];
                        maxsize = i;
                        maxsize2 = j;
                    }
                }
            mas[minsize, minsize2] = min;
            mas[maxsize, maxsize2] = max;
            return mas;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность массива");
            while (!int.TryParse(Console.ReadLine(), out size))
                Console.WriteLine("Введите число");
                int[,] mas = new int[size, size];
                for (int i = 0; i < size; i++)
                    for (int j = 0; j < size; j++)
                    {
                        Console.Write("a[" + i + "," + j + "]=");
                        while (!int.TryParse(Console.ReadLine(), out mas[i, j]))
                                Console.Write("Введите число\na[" + i + "," + j + "]=");
                    }
                Console.WriteLine("Максимум=" + Max(mas));
                Console.WriteLine("Минимум=" + Min(mas));
                mas = MinMax(mas);
                for (int i = 0; i < size; i++)
                    for (int j = 0; j < size; j++)
                    {
                        Console.Write("a[" + i + "," + j + "]={0}\n", mas[i, j]);
                    }
            Console.ReadKey();
        }
    }
}
