class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.Write("Введите трёхзначное число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        
        string TwoDigitNumber = Convert.ToString(number); 
       
        Console.WriteLine("Вторая цифра этого числа: "+TwoDigitNumber[1]);
    }
}
//Convert.ToString(int value) - Преобразует значение указанного
//32-разрядного целого числа со знаком в его эквивалентное строковое представление.


