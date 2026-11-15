public static class Program
{
    public static void Main(string[] args)
    {
        int[] array = {1, 2, 3, 4, 5, 6, 7, 8, 9};
        var randomizer = new Random();

        Shuffle(array, randomizer);

        Console.WriteLine(string.Join(", ", array));
    }

    private static void Shuffle(int[] array, Random randomizer)
    {
        for (int i = array.Length - 1; i >= 0; i--)
        {
            int j = randomizer.Next(i + 1);
            Swap(ref array[i], ref array[j]);
        }
    }

    private static void Swap(ref int firstElement, ref int secondElement)
    {
        int temp = firstElement;
        firstElement = secondElement;
        secondElement = temp;
    }
}