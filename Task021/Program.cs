/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

using System;

class Program
{
    public static void Main(string[] args)
    {

        int[,] numbers = {{1,4,7,2},
                          {5,9,2,3},
                          {8,4,2,4}};
        Console.WriteLine($"\nСреднее арифметическое каждого столбца: ");

        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            double sumColumn = 0;
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                sumColumn = sumColumn + numbers[i, j];
            }
            double averageColumn = Math.Round(sumColumn / numbers.GetLength(0), 2);
            Console.WriteLine($"\nСтолбец №{j + 1} = {averageColumn}");
        }

    }
}