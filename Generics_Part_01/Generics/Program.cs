using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintServiceGeneric<string> printService = new PrintServiceGeneric<string>();

            Console.Write("How many values? ");
            int n = int.Parse(Console.ReadLine());

            for(int i=0; i<n; i++)
            {
                string x = Console.ReadLine();
                printService.AddValue(x);
            }

            printService.Print();
            Console.WriteLine("First: "+ printService.First());
        }
    }
}
