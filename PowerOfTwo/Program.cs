public static class Program
{
    public static void Main(string[] args)
    {
        long raisedNumber = 1;
        int randomNumber = new Random().Next();
        int degree = 0;

        Console.WriteLine($"Случайное число: {randomNumber}");

        for (degree = 0; raisedNumber <= randomNumber; raisedNumber *= 2)
        {
            degree++;
        }

        Console.WriteLine($"Искомая степень: {degree}");
    }
}