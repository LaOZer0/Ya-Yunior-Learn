public static class Program
{
    public static void Main(string[] args)
    {
        var step = 7;
        var lastNumber = 103;
        var startNumber = 5;

        //Выбрал данный цикл, так как есть известные конец и шаг 
        for (var i = startNumber; i <= lastNumber; i += step)
        {
            Console.WriteLine(i);
        }
    }
}
