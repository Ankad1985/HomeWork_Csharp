class Program
{
    static void Main(string[] args)
    {
        //Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
        //является ли этот день выходным.
        //6 -> да
        //7 -> да
        //1 -> нет
        Console.Clear();
        Console.Write("Введите цифру от 1 до 7 обозначающую день недели: ");
        int NumberDayWeek = Convert.ToInt32(Console.ReadLine());
        
        if(NumberDayWeek == 6 || NumberDayWeek == 7)
        {
        Console.WriteLine("Да -это выходной.");
        }
        else
        {
        Console.WriteLine("Нет -это не выходной.");
        }   
    }
}
