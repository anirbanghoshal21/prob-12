﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 10, 30, 40, 100, 170,78 };
            int max = array[0];
            int min = array[0];
            for (int i = 0; i <= array.Length - 1; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            Console.WriteLine(max);
            Console.WriteLine(min);
            Console.ReadKey();
        }
    }
}
