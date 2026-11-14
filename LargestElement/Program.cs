public static class Program
{
    public static void Main(string[] args)
    {
        int[,] matrix = new int[10, 10]
        {
            { 47, 82, 13, 65, 91, 27, 58, 34, 76, 19 },
            { 63,  5, 88, 42, 70, 11, 99, 23, 54, 37 },
            { 29, 74, 16, 99, 51,  8, 99, 43, 85, 12 },
            { 99, 38, 57, 21, 79, 45,  3, 68, 14, 99 },
            { 10, 96, 99, 72, 99, 84, 99, 61, 7,  52 },
            { 55, 18, 90, 41, 67, 24, 78, 6,  83, 39 },
            { 31, 69, 44, 97, 15, 60, 2,  86, 53, 28 },
            { 81, 26, 73, 9,  94, 36, 59, 17, 88, 99 },
            { 20, 64, 35, 89, 50, 4,  77, 22, 93, 99 },
            { 68, 48, 12, 56, 83, 30, 99, 62, 5,  99 }
        };

        int countColoums = matrix.GetLength(0);
        int countRows = matrix.GetLength(1);

        int? maxElement = null;

        for (int i = 0; i < countColoums; i++)
        {
            for (int j = 0; j < countRows; j++)
            {
                if (!maxElement.HasValue || maxElement < matrix[i, j])
                {
                    maxElement = matrix[i, j];
                }
            }
        }

        Console.WriteLine($"max element: {maxElement}");

        for (int i = 0; i < countColoums; i++)
        {
            for (int j = 0; j < countRows; j++)
            {
                Console.Write($"{matrix[i, j]} ");

                if (matrix[i, j] == maxElement)
                {
                    matrix[i, j] = 0;
                }
            }

            Console.Write("\n");
        }

        Console.WriteLine();

        for (int i = 0; i < countColoums; i++)
        {
            for (int j = 0; j < countRows; j++)
            {
                Console.Write($"{matrix[i, j]} ");
            }

            Console.Write("\n");
        }
    }
}