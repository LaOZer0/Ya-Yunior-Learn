public static class Program
{
    static void Main(string[] args)
    {
        int numberRowForSum = 0;
        int numberColumnForMultiplier = 1;

        int sumOfFirstRow = 0;
        int multiplierOfSecondColumn = 1;

        int[,] matrix = new int[2, 3] {
                        { 1, 2, 3 },
                        { 4, 5, 6 }
        };

        int countColumns = matrix.GetLength(0);
        int countElementsInRow = matrix.GetLength(1);
        
        for (int i = 0; i < countColumns; i++)
        {
            for (int j = 0; j < countElementsInRow; j++)
            {
                Console.Write($"{matrix[i, j]} ");

                if (i == numberRowForSum)
                {
                    sumOfFirstRow += matrix[i, j];
                }

                if (j == numberColumnForMultiplier)
                {
                    multiplierOfSecondColumn *= matrix[i, j];
                }
            }

            Console.Write("\n");
        }

        Console.WriteLine($"Сумма: {sumOfFirstRow}, произведение: {multiplierOfSecondColumn}");
    }
}