using System;

class Program {
  public static void Main (string[] args) {
    //Напишите цикл, который принимает на вход два числа (A и B) и            возводит число A в натуральную степень B.
    //3, 5 -> 243 (3⁵)
    //2, 4 -> 16

    Console.Write("Введите число A: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число B: ");
    int b = Convert.ToInt32(Console.ReadLine());
    int extent = a;

    for(int count = 1; count < b; count++)
    {
     extent = extent * a;
    }
  /*int count = 1;
    int extent = a;
    while(count < b)
    {
      extent = extent * a;
      count++;  
    }*/
    Console.WriteLine($"A в степени B равно: {extent}");

  //Console.WriteLine($"A в степени B равно: {Math.Pow(a,b)}");
       
  }
}
