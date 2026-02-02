public static class Program
{
    private const int COMMAND_TEXT = 0;
    private const int COMMAND_ANOTHER_TEXT = 1;
    private const int COMMAND_RANDOM_NUMBER = 2;
    private const int COMMAND_CLEAR = 3;
    private const int COMMAND_EXIT = 4;

    public static void Main(string[] args)
    {
        bool isStillWorks = true;
        var randomNumber = new Random();
        string firstText = "текста";
        string secondText = "другого текста";
        int numberOfCommand;

        while (isStillWorks)
        { 
            Console.WriteLine("Выберите номер команды: ");
            Console.WriteLine($"{COMMAND_TEXT}. Команда для вывода {firstText}");
            Console.WriteLine($"{COMMAND_ANOTHER_TEXT}. Команда для вывода {secondText}");
            Console.WriteLine($"{COMMAND_RANDOM_NUMBER}. Команда для случайного числа");
            Console.WriteLine($"{COMMAND_CLEAR}. Команда для отчистки консоли");
            Console.WriteLine($"{COMMAND_EXIT}. Команда для выхода");

            if (int.TryParse(Console.ReadLine(), out numberOfCommand) == false)
            {
                Console.WriteLine("Номер команды должен быть числом");
                continue;
            }

            switch (numberOfCommand)
            {
                case COMMAND_TEXT:
                    Console.WriteLine("текста");
                    break;
                case COMMAND_ANOTHER_TEXT:
                    Console.WriteLine("другого текста");
                    break;
                case COMMAND_RANDOM_NUMBER:
                    Console.WriteLine(randomNumber.Next());
                    break;
                case COMMAND_CLEAR:
                    Console.Clear();
                    break;
                case COMMAND_EXIT:
                    isStillWorks = false;
                    break;
                default:
                    Console.WriteLine("Неизвестная команда");
                    break;
            };
        }
        
    }
}