/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/

using System;

class Program
{
    public static void Main(string[] args)
    {

        int[,] numbers = {{29,17,18,37,55},
                      {14,13,92,81,60},
                      {9,-18,72,-6,-5},
                      {42,5,-15,24,63}};
        Console.Write($"Введите номер строки от 0 до 3: ");
        int row = int.Parse(Console.ReadLine());
        Console.Write($"\nВведите номер столбца от 0 до 4: ");
        int column = int.Parse(Console.ReadLine());
        Console.Write("\n");


        if (row < 0 || row >= numbers.GetLength(0) || column < 0 || column >= numbers.GetLength(1))

        {
            Console.Write($"Такого элемента в массиве нет");
        }
        else
        {
            Console.Write($"Искомый элемент массива: {numbers[row, column]}");
        }

    }
}

