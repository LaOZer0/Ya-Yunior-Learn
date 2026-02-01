public static class Program
{
    public static void Main(string[] args)
    {
        var firstValue = 1;
        var secondValue = 2;
        Console.WriteLine($"{firstValue}, {secondValue}");
        Swap(ref firstValue, ref secondValue);
        Console.WriteLine($"{firstValue}, {secondValue}");
    }
    
    private static void Swap<T>(ref T firstValue, ref T secondValue)
    {
        T temp = firstValue;
        firstValue = secondValue;
        secondValue = temp;
    }
}