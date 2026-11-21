public static class Program
{
    public static void Main(string[] args)
    {
        var dictionary = new Dictionary<string, string>() 
        {
            {"Mom", "Mask of madness" },
        };

        string inputWord = "";

        while (true)
        {
            inputWord = Console.ReadLine();

            if (dictionary.TryGetValue(inputWord, out var wordMean))
            {
                Console.WriteLine($"{inputWord} - {wordMean}");
            }
            else
            {
                Console.WriteLine($"В словаре отсутствует значение для слова {inputWord}");
            }
        }
    }
}