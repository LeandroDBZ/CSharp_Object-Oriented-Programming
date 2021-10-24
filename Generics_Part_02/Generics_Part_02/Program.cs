﻿using Generics_Part_02.Services;
using System;
using System.Collections.Generic;

namespace Generics_Part_02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();

            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                list.Add(x);
            }
            CalculationService calculationService = new CalculationService();

            int max = calculationService.Max(list);

            Console.WriteLine("Max: ");
            Console.WriteLine(max);
        }
    }
}