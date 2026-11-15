public static class Program
{
    public static void Main (string[] args)
    {
        Console.WriteLine(RequestNumber());
    }

    private static int RequestNumber()
    {
        int number;

        while (int.TryParse(Console.ReadLine(), out number) != true)
        {
            continue;
        }

        return number;
    }
}