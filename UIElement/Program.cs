public static class Program
{
    public static void Main(string[] args)
    {
        PrintBar(40, 10, '#');
        PrintBar(70, 10, '*');
    }

    private static void PrintBar(int barPercentage, int barLength, char barSymbol)
    {
        const char EmptyBarSymbol = '_';

        char[] bar = new char[barLength];

        int fillBarLength = (int) ((float) barLength / 100 * barPercentage);

        for (int i = 0; i < barLength; i++)
        {
            if (i < fillBarLength)
            {
                bar[i] = barSymbol;
            }
            else
            {
                bar[i] = EmptyBarSymbol;
            }
        }

        Console.WriteLine($"[{string.Join("", bar)}]");
    }
}