public static class Program
{
    public static void Main(string[] args)
    {
        int countTries = 3;
        string password = "password";
        string secretMessage = "message";
        Console.WriteLine("Введите пароль для доступа");

        for (var i = 0; i < countTries; i++)
        {
            if (Console.ReadLine() == password)
            {
                Console.WriteLine(secretMessage);
                break;
            }

            Console.WriteLine("Попробуйте ещё раз");
        }
    }
}
