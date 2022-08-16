using System;

class Program {
  public static void Main (string[] args) {
    //Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
    //1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
    //6, 1, 33 -> [6, 1, 33]
    Console.Write("Введите количество элементов массива: ");
    int elementCounts = Convert.ToInt32(Console.ReadLine());
    int [] numbers = new int[elementCounts];
    for(int index = 0; index < numbers.Length; index++)
    {
      Console.Write($"\nВведите элемент массива под индексом {index}: ");
      numbers[index] = Convert.ToInt32(Console.ReadLine());
    }  
    Console.Write("\nВывод массива: " );
    for(int index = 0; index < numbers.Length; index++)
    {
      Console.Write($"{numbers[index]} ");
    }  
      
  }
}