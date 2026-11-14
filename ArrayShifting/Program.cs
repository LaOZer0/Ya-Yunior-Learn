public static class Program
{
    public static void Main(string[] args)
    {
        int[] array = { 7, 2, 9, 4, 1, 8, 3, 6, 5, 10 };

        if (int.TryParse(Console.ReadLine(), out var shift) == false)
        {
            return;
        }

        shift %= array.Length;

        for (int s = 0; s < shift; s++)
        {
            int startElement = array[0];

            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }

            array[array.Length - 1] = startElement;
        }

        Console.WriteLine(string.Join(", ", array));
    }
}