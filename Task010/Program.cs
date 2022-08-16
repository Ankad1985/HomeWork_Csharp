using System;

class Program
{
    public static void Main(string[] args)
    {
        //Напишите программу, которая принимает на вход число (N) и выдаёт      // таблицу кубов чисел от 1 до N.
        //3 -> 1, 8, 27
        //5 -> 1, 8, 27, 64, 125

        Console.Write("Введите целое число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int tableCube = 1;

        if (number < 1) Console.WriteLine("Перезапустите программу и введите целое число больше или равное 1");

        while (tableCube <= number)
        {
            Console.Write(Math.Pow(tableCube, 3) + "; ");
            tableCube++;
        }
    }
}