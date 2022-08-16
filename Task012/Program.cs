using System;

class Program {
  public static void Main (string[] args) {
    //Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
    //452 -> 11
    //82 -> 10
    //9012 -> 12
    
    Console.Clear();
    Console.Write("Введите целое число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    int sum = 0;
    
    while(number > 0)
    {
      int digit = number % 10;
      sum = sum + digit;
      number = number/10;
    } 
    
    Console.Write($"Сумма цифр в числе: {sum}");
    
  }
}