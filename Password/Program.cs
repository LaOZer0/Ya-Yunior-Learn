public static class Program
{
    public static void Main(string[] args)
    {
        int countTries = 3;
        string password = "password";
        string secretMessage = "message";
        Console.WriteLine("Введите пароль для доступа");
        string userInput;

        for (var i = 0; i < countTries; i++)
        {
            userInput = Console.ReadLine();
            if (userInput == password)
            {
                Console.WriteLine(secretMessage);
                continue;
            }

            Console.WriteLine("Попробуйте ещё раз");
        }
    }
}