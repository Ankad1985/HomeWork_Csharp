using System;

class Program {
  public static void Main (string[] args) {
    //Задайте одномерный массив, заполненный случайными числами.
    // Найдите сумму элементов, стоящих на нечётных позициях.
    //[3, 7, 23, 12] -> 19
    //[-4, -6, 89, 6] -> 0
    Console.Clear();
    
    //Функция заполнение массива случайными числами

    void FillArrayRandomNumbers(int[] numbers)
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

    //Функция подсчёта сумммы элементов на нечетных позициях
    int sumOddPosition(int[] numbers)
    {
        int sum = 0;
        for(int i = 0; i < numbers.Length; i++)
        {
            if(i % 2 == 1)
            {
                sum = sum + numbers[i];
            }
        }
        return sum;
    }

    Console.Write("Введите количество элементов массива: ");
    int countElements = Convert.ToInt32(Console.ReadLine());
    int[] numbers = new int[countElements];

    Console.Write("\nПолученный массив трёхзначных чисел: ");
    FillArrayRandomNumbers(numbers);
    PrintArray(numbers);

    int sum = sumOddPosition(numbers);
    Console.Write($"\nСумма элементов на нечётных позициях: {sum}");
   
   
  }
}     
