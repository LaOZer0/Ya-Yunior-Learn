public static class Program
{
    public static void Main(string[] args)
    {
        int[] array = new int[30]
        {
            5, 5, 5, 5,            // 4 раза
            9, 9, 9, 9, 9, 9,      // 6 раз
            2,                     // 1 раз
            7, 7, 7,               // 3 раза
            4, 4, 4, 4, 4,         // 5 раз
            8, 8,                  // 2 раза
            1, 1, 1, 1, 1, 1, 1,   // 7 раз
            6, 6                  // 2 раза
        };

        int maxRepeatableNumber = 0;
        int maxRepeat = 0;

        int startIndex = 0;

        for (int i = 0; i <= array.Length; i++)
        {
            if (i < array.Length && array[i] == array[startIndex])
            {
                continue;
            }

            if (i - startIndex > maxRepeat)
            {
                maxRepeat = i - startIndex;
                maxRepeatableNumber = array[startIndex];
                startIndex = i;
            }
            else
            {
                startIndex = i;
            }
        }

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]} ");
        }

        Console.WriteLine($"- число {maxRepeatableNumber} повторяется {maxRepeat} раза подряд.");
    }
}