using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class param
    {
        public static void example(int[] array0, char c, params int[] p)
        {
            array.sort(p, c);
            for (int k = 0; k < p.Length; ++k) array0[k] = p[k];
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            int[] source = { -4, 25, 22, 7, -25, 49, 100 };
            Console.WriteLine("\n ИСХОДНЫЕ ДАННЫЕ");
            foreach (int k in source) Console.Write(k + " ");
            Console.WriteLine("\n\n ПОСЛЕ СОРТИРОВКИ 4 ЧИСЕЛ");
            int[] array1 = new int[source.Length];
            param.example(array1, 'u', source[0], source[5], source[2], source[4]);
            foreach (int k in array1) Console.Write(k + " ");
            Console.WriteLine("\n\n ПОСЛЕ СОРТИРОВКИ 3 ЧИСЕЛ");
            int[] array2 = new int[3];
            param.example(array2, 'd', source[1], source[6], source[2]);
            foreach (int k in array2) Console.Write(k + " ");
            Console.WriteLine("\n\n");
            foreach (int k in source) Console.Write(k + " ");
            Console.WriteLine("\n\n ПОСЛЕ СОРТИРОВКИ МАССИВА");
            param.example(source, 'u', source);
            foreach (int k in source) Console.Write(k + " ");
            Console.Read();
        }
    }
}
