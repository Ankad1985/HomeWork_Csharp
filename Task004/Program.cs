// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Clear(); // Очистка консоли перед запуском программы

Console.Write("Введите целое число: ");
int number  = Convert.ToInt32(Console.ReadLine()); // Ввод числа пользователем

int evenNumber = 2; // Чётные числа

while(evenNumber <= number)
{
    Console.WriteLine(evenNumber);
    evenNumber = evenNumber + 2;
}
