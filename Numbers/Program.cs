public static class Program
{
    public static void Main(string[] args)
    {
        int beginningOfRange = 10;
        int endOfRange = 25;
        int randomDivider = new Random().Next(beginningOfRange, endOfRange + 1);

        beginningOfRange = 50;
        endOfRange = 150;
        int countOfMultiples = 0;

        Console.WriteLine($"Ваш делитель: {randomDivider}");

        for (var i = 0; i < endOfRange; i += randomDivider)
        {
            if (i > beginningOfRange)
            {
                countOfMultiples += 1;
            }
        }

        Console.WriteLine(countOfMultiples);
    }
}