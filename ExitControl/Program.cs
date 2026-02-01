public static class Program
{
    public static void Main(string[] args)
    {
        var exitMessage = "exit";
        var playerInput = "";
        while (playerInput != exitMessage)
        {
            Console.Write("Введите слово: ");
            playerInput = Console.ReadLine();
        }
    }
}