using System;

class Program {
  public static void Main (string[] args) {
      //Напишите программу, которая принимает на вход пятизначное     
      //число и проверяет, является ли оно палиндромом.
      //14212 -> нет
      //12821 -> да
      //23432 -> да

    Console.Clear();
    Console.Write("Введите пятизначное число: ");
    int number = Convert.ToInt32(Console.ReadLine());

    string FiveDigitNumber = Convert.ToString(number);
    if(FiveDigitNumber[0] == FiveDigitNumber[4] || FiveDigitNumber[1] == FiveDigitNumber[3])
    {
      Console.Write("Данное число является палиндромом.");
    }
    else
    {
      Console.Write("Данное число не является палиндромом.");
    }  
  }
}