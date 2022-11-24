using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 1. Даны положительные числа A и B (A > B). На отрезке 
    длины A размещено максимально возможное количество 
    отрезков длины B (без наложений). Не используя операции 
    умножения и деления, найти длину незанятой части отрезка A.*/

namespace Lab_3_1_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A = 11;
            int B = 3;

            int remainder = A; // Остаток
            while (remainder >= B)
                remainder -= B;

            Console.WriteLine(remainder);
            Console.ReadKey();
        }
    }
}
