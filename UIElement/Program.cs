public static class Program
{
    public static void Main(string[] args)
    {
        PrintBar(40, 10, 0, '#');
        PrintBar(70, 10, 1, '*');
    }

    private static void PrintBar(int barPercentage, int barLength, int position, char barSymbol = '#')
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

        Console.SetCursorPosition(0, position);
        Console.WriteLine($"[{string.Join("", bar)}]");
    }
}
