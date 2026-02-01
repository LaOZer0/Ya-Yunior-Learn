public static class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Введите сообщение для повтора: ");
        var message = Console.ReadLine();
        Console.Write("Введите кол-во повторов сообщения: ");
        
        if (int.TryParse(Console.ReadLine(), out var countRepeat) == false || countRepeat < 0)
        {
            Console.WriteLine("Кол-во повторов должно быть число большее 0");
        }

        for (var i = 0; i < countRepeat; i++)
        {
            Console.WriteLine(message);
        }
    }
}