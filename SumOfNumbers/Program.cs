public static class Program
{
    public static void Main(string[] args)
    {
        var number = new Random().Next(0, 101);
        var sumNumbers = 0;
        var multipleThree = 3;
        var multipleFive = 5;

        for (var i = multipleThree; i <= number; i++)
        {
            if (i % multipleThree != 0 && i % multipleFive != 0)
            {
                continue;
            }

            sumNumbers += i;
        }

        Console.WriteLine(sumNumbers);
    }
}