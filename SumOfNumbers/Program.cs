public static class Program
{
    public static void Main(string[] args)
    {
        var number = new Random().Next(0, 101);
        var sumNumbers = 0;
        var multipleOfThree = 3;
        var multipleOfFive = 5;

        for (var i = 1; i * multipleOfFive < number && i * multipleOfThree < number;  i++)
        {
            sumNumbers += i * multipleOfThree + i * multipleOfFive;
        }

        Console.WriteLine(sumNumbers);
    }
}