public static class Program
{
    private const int CommandText = 0;
    private const int CommandAnotherText = 1;
    private const int CommandRandomNumber = 2;
    private const int CommandClear = 3;
    private const int CommandExit = 4;

    public static void Main(string[] args)
    {
        bool isStillWorks = true;
        var numberRandomizer = new Random();
        string firstText = "текста";
        string secondText = "другого текста";
        int numberOfCommand;

        while (isStillWorks)
        { 
            Console.WriteLine("Выберите номер команды: ");
            Console.WriteLine($"{CommandText}. Команда для вывода {firstText}");
            Console.WriteLine($"{CommandAnotherText}. Команда для вывода {secondText}");
            Console.WriteLine($"{CommandRandomNumber}. Команда для случайного числа");
            Console.WriteLine($"{CommandClear}. Команда для отчистки консоли");
            Console.WriteLine($"{CommandExit}. Команда для выхода");

            if (int.TryParse(Console.ReadLine(), out numberOfCommand) == false)
            {
                Console.WriteLine("Номер команды должен быть числом");
                continue;
            }

            switch (numberOfCommand)
            {
                case CommandText:
                    Console.WriteLine("текста");
                    break;
                case CommandAnotherText:
                    Console.WriteLine("другого текста");
                    break;
                case CommandRandomNumber:
                    Console.WriteLine(numberRandomizer.Next());
                    break;
                case CommandClear:
                    Console.Clear();
                    break;
                case CommandExit:
                    isStillWorks = false;
                    break;
                default:
                    Console.WriteLine("Неизвестная команда");
                    break;
            };
        }
        
    }
}