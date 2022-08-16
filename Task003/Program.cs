// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным.

Console.Clear();

Console.WriteLine("Введите целое число: ");
int a  = Convert.ToInt32(Console.ReadLine());

if(a %2 == 0)
{
    Console.WriteLine("Это число является четным");
}
else
{
    Console.WriteLine("Это число является нечетным");
}
