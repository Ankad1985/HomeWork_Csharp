using System;

class Program
{
    public static void Main(string[] args)
    {
        //Задайте массив вещественных чисел. 
        //Найдите разницу между максимальным и минимальным элементов массива.
        //[3 7 22 2 78] -> 76

        double[] arrayRealNumbers = new double[20];
        for (int i = 0; i < arrayRealNumbers.Length; i++)
        {
            arrayRealNumbers[i] = new Random().Next(1, 21);
            Console.Write($"{arrayRealNumbers[i]} ");
        }

        double maxElementArray = arrayRealNumbers[0];
        double minElementArray = arrayRealNumbers[0];

        for (int i = 0; i < arrayRealNumbers.Length; i++)
        {
            if (maxElementArray < arrayRealNumbers[i])
            {
                maxElementArray = arrayRealNumbers[i];
            }
            if (minElementArray > arrayRealNumbers[i])
            {
                minElementArray = arrayRealNumbers[i];
            }
        }

        double result = maxElementArray - minElementArray;
        Console.WriteLine($"\nРазница между {maxElementArray} и {minElementArray} равна: {result}");



        //Функция заполнение массива случайными числами

        /*void FillArrayRandomNumbers(int[] numbers)
        {
            for(int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = new Random().Next(1,10);
            }
        }
        //--------------------------------------------------

        //Функция вывода массива на экран

        void PrintArray(int[] numbers)
        {
            for(int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[i]} ");
            }
        }
        //--------------------------------------------------

        //Функция поиска максимального элемента массива
        int maxElementArray(int[] numbers)
        {
          int max = numbers[0];
          for(int i = 0; i < numbers.Length; i++)
          {
            if(max < numbers[i])
            {
                max = numbers[i];
            }
          }  
          return max;
        }
        //Функция поиска минимального элемента массива
        int minElementArray(int[] numbers)
        {
          int min = numbers[0];
          for(int i = 0; i < numbers.Length; i++)
          {
            if(min > numbers[i])
            {
                min = numbers[i];
            }
          }  
          return min;
        }
        //--------------------------------------------------

        Console.Write("Введите количество элементов массива: ");
        int countElements = Convert.ToInt32(Console.ReadLine());
        int[] numbers = new int[countElements];

        Console.Write("\nПолученный массив: ");
        FillArrayRandomNumbers(numbers);
        PrintArray(numbers);

        int max = maxElementArray(numbers);
        int min = minElementArray(numbers);
        int result = max - min;
        Console.Write($"\nРазница между {max} и {min} равна: {result}"); */

    }
}
