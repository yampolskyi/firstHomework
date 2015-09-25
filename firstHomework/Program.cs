using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            string strx;
            int[] arr = new int[0];
            int x  = 0;
            
            for (int i = 0; i < 1; i++)
            {
                try 
                {
                    Console.Write("Введите значение, равное размерности массива: ");
                    strx = Console.ReadLine();
                    x = Convert.ToInt32(strx);
                    arr = new int[x];
                }
                catch (Exception)
                {
                    i--;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Вы ввели недопустимое значение");
                    Console.ResetColor();
                }


            }


             for (int i = 0; i < x; i++)
             {
                 try
                 {
                     int subI = i + 1;
                     Console.Write("Введите элемент №" + subI + ": ");
                     arr[i] = Convert.ToInt32(Console.ReadLine());
                 }
                 catch (Exception)
                 {
                     Console.ForegroundColor = ConsoleColor.Red;
                     Console.WriteLine("Вы ввели недопустимое значение");
                     Console.ResetColor();
                     i--;                     
                 }

             }


            sort(arr, 0, x - 1);
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.Read();


        }
        static void sort(int[] arr, int first, int last)
        {
            int leftValue = first;
            int rightValue = last;


            int subValue;

            int midValue = arr[(leftValue + rightValue) / 2];
            // 1.Разбиение массива относительно опорного элемента
            while (leftValue <= rightValue)
            {
                while (arr[leftValue] < midValue)
                {
                    leftValue++;
                }
                while (arr[rightValue] > midValue)
                {
                    rightValue--;
                }
                if (leftValue <= rightValue)
                {
                    subValue = arr[leftValue];
                    arr[leftValue] = arr[rightValue];
                    arr[rightValue] = subValue;
                    leftValue++;
                    rightValue--;
                }


                //2. Рекурсивная сортировка каждой части массива
                if (leftValue < last)
                {
                    sort(arr, leftValue, last);
                }
                if (rightValue > first)
                {
                    sort(arr, first, rightValue);
                }
            }
        }
    }
}
