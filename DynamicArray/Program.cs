public static class Program
{
    public static void Main(string[] args)
    {
        const string SumCommand = "sum";
        const string ExitCommand = "exit";

        const int IncreaseFactor = 2;

        int currentLength = 4;
        int countElements = 0;
        int sumElements = 0;

        int[] array = new int[currentLength];

        string? inputCommand = "";

        while (inputCommand != ExitCommand)
        {
            for (int i = 0; i < countElements; i++)
            {
                Console.Write($"{array[i]} ");
            }

            Console.WriteLine();

            inputCommand = Console.ReadLine();

            switch (inputCommand)
            {
                case SumCommand:
                    Console.WriteLine(sumElements);
                    break;

                case ExitCommand:
                    break;

                default:
                    if (int.TryParse(inputCommand, out var currentElement) == false)
                    {
                        break;
                    }

                    if (countElements == currentLength)
                    {
                        currentLength *= IncreaseFactor;
                        int[] tempArray = new int[currentLength];

                        for (int i = 0; i < countElements; i++)
                        {
                            tempArray[i] = array[i];
                        }

                        array = tempArray;
                    }

                    array[countElements] = currentElement;
                    countElements++;
                    sumElements += currentElement;
                    break;
            }
        }
    }
}