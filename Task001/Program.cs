// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Clear();

Console.WriteLine("Введите первое число: ");
int a  = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int b  = Convert.ToInt32(Console.ReadLine());

if(a>b)
{
    Console.WriteLine("Большее число: ");
    Console.WriteLine(a);
    Console.WriteLine("Меньшее число: ");
    Console.WriteLine(b);
}
else
{
    Console.WriteLine("Большее число: ");
    Console.WriteLine(b);
    Console.WriteLine("Меньшее число: ");
    Console.WriteLine(a);
}

