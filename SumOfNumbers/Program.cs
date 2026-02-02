public static class Program
{
    public static void Main(string[] args)
    {
        int maxRandomNumber = 100;
        var number = new Random().Next(0, maxRandomNumber + 1);
        int sumNumbers = 0;
        int firstDivider = 3;
        int secondDivider = 5;

        for (var i = firstDivider; i <= number; i++)
        {
            if (i % firstDivider != 0 && i % secondDivider != 0)
            {
                continue;
            }

            sumNumbers += i;
        }

        Console.WriteLine(sumNumbers);
    }
}
