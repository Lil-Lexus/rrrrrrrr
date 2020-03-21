using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во строк");
            int stroka = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите кол-во столбцов");
            int stolbec = int.Parse(Console.ReadLine());
            Console.WriteLine("Заполните массив");
            int summa = 0, proiz = 1;
            int[,] mtx = new int[stroka, stolbec];

            for (int i = 0; i < stroka; i++)
            {
                for (int j = 0; j < stolbec; j++)
                {
                    mtx[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < stroka; i++)
            {
                for (int j = 0; j < stolbec; j++)
                {
                    summa += mtx[i, j];
                    
                    Console.Write($" {mtx[i, j]} ");
                }
                Console.WriteLine($" {summa}");
                summa = 0;
                Console.WriteLine();

            }

            for (int j = 0; j < stolbec; j++)
            {
                proiz = 1;
                for (int i = 0; i < stroka; i++)
                {
                    proiz = proiz * mtx[i, j];

                }
                Console.Write($" {proiz} ");




            }
            Console.Write("x");
            Console.ReadKey();
        }
    }
}