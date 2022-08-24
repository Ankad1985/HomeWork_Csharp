using System;

class Program
{
    public static void Main(string[] args)
    {

        //Найдите произведение пар чисел в одномерном массиве. 
        //Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
        //Результат запишите в новом массиве.[1 2 3 4 5] -> 5 8 3 ; [6 7 3 6] -> 36 21

        //Блок ввода количества чисел
        Console.Write("Введите количество элементов массива: ");
        int elementCounts = Convert.ToInt32(Console.ReadLine());
        int[] numbers = new int[elementCounts];
        //-----------------------------------------------

        //Блок ввода чисел
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"\nВведите элемент массива с индексом {i}: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }
        //-----------------------------------------------

        //Блок вывода чисел
        Console.Write("\nПолученный массив: ");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"{numbers[i]} ");
        }
        Console.WriteLine("\n");
        //-----------------------------------------------

        //Произведение крайних пар числе в массиве первый и последний элемент, второй и предпоследний и т.д
        //-----------------------------------------------
        Console.Write("Произведение пар чисел в массиве: ");
        int multi = 0;
        
        for (int i = 0; i < numbers.Length - 1 - i; i++)
        {
            multi = numbers[i] * numbers[numbers.Length - 1 - i];
            Console.Write($"{multi} ");
        }
        //-----------------------------------------------

        //Добавление среднего числа без пары, в массиве с нечётным количеством элементов
        //-----------------------------------------------
        if (numbers.Length % 2 == 1)
        {
            int oddArrayLength(int[] numbers)
            {
                int middleElement = 0;
                for (int i = 0; i < numbers.Length - 1 - i; i++)
                {
                    middleElement = numbers[numbers.Length - 2 - i];
                }
                return middleElement;
            }

            int middleElement = oddArrayLength(numbers);
            Console.Write($"{middleElement}");
            
        }
    }
}