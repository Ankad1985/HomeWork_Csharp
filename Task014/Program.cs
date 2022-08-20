using System;

class Program {
  public static void Main (string[] args) {

//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

    Console.Clear();
    
    //Функция заполнение массива случайными числами

    void FillArrayRandomNumbers(int[] numbers)
    {
        for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = new Random().Next(100,1000);
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

    //Функция счёта количества чётных чисел в массиве

    int countEven(int[] numbers)
    {
        int Even = 0;
        for(int i = 0; i < numbers.Length; i++)
        {
            if(numbers[i] % 2 == 0)
            {
                Even++;
            }
        }
        return Even;
    } 
    //--------------------------------------------------

    Console.Write("Введите количество элементов массива: ");
    int countElements = Convert.ToInt32(Console.ReadLine());
    int[] numbers = new int[countElements];

    Console.Write("\nПолученный массив трёхзначных чисел: ");
    FillArrayRandomNumbers(numbers);
    PrintArray(numbers);

    int Even = countEven(numbers);
    Console.Write($"\nКоличество чётных чисел массива: {Even}");
    

    

    



  }
}