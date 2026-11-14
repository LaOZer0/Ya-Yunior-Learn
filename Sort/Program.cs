public static class Program
{
    public static void Main(string[] args)
    {
        int[] array = { 42, 8, 91, 3, 67, 15, 29, 54, 76, 11 };

        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array.Length - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    int temp = array[j + 1];
                    array[j + 1] = array[j];
                    array[j] = temp;
                }
            }
        }

        Console.WriteLine(string.Join(", ", array));
    }
}