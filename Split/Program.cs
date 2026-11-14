public static class Program
{
    public static void Main(string[] args)
    {
        string text = "Сегодня утром я выпил чашку крепкого кофе и отправился на прогулку по осеннему парку";
        string[] wordsArray = text.Split();

        foreach (string word in wordsArray)
        {
            Console.WriteLine(word);
        }
    }
}