public static class Program
{
    public static void Main(string[] args)
    {
        var step = 7;
        var lastNumber = 103;
        var currentNumber = 5;

        while (currentNumber <= lastNumber)
        {
            Console.WriteLine(currentNumber);
            currentNumber += step;
        }
    }
}