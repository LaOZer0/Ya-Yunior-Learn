public static class Program
{
    public static void Main(string[] args)
    {
        var rightBorder = 101;
        var number = new Random().Next(0, rightBorder);
        var sumNumbers = 0;
        var firstDivider = 3;
        var secondDivider = 5;

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
