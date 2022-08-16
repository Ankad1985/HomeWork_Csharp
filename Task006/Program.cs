class Program
{
    static void Main(string[] args)
    {
        //Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
        Console.Clear();
    
        Console.Write("Введите трёхзначное число: ");
        int number  = Convert.ToInt32(Console.ReadLine());
        string Digit = Convert.ToString(number);
    
        if(Digit.Length >2) 
        {
            Console.WriteLine("Третья цифра введённого числа:"+Digit[2]);
        }  
        else
        {
        Console.WriteLine("Третьей цифры нет.");
        } 
    }
}