public static class Program
{
    public static void Main(string[] args)
    {
        int[] array = 
        {
            47, 82, 13, 65, 91, 27, 58, 34, 76, 19,
            63,  5, 88, 42, 70, 11, 95, 23, 54, 37,
            29, 74, 16, 98, 51,  8, 66, 43, 85, 12
        };

        for (int i = 0; i < array.Length; i++)
        {
            if (i == 0 && array[i] > array[i + 1])
            {
                Console.WriteLine(array[i]);
                i++;
                continue;
            }

            if (i == array.Length - 1 && array[i] > array[i - 1])
            {
                Console.WriteLine(array[i]);
                i++;
                continue;
            }

            if (array[i] > array[i + 1] && array[i] > array[i - 1])
            {
                Console.WriteLine(array[i]);
                i++;
                continue;
            }
        }
    }
}