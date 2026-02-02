public static class Program
{
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
            Console.WriteLine($"0. Команда для вывода {firstText}");
            Console.WriteLine($"1. Команда для вывода {secondText}");
            Console.WriteLine("2. Команда для случайного числа");
            Console.WriteLine("3. Команда для отчистки консоли");
            Console.WriteLine("4. Команда для выхода");

            if (int.TryParse(Console.ReadLine(), out numberOfCommand) == false)
            {
                Console.WriteLine("Номер команды должен быть числом");
                continue;
            }

            switch (numberOfCommand)
            {
                case 0:
                    Console.WriteLine("текста");
                    break;
                case 1:
                    Console.WriteLine("другого текста");
                    break;
                case 2:
                    Console.WriteLine(randomNumber.Next());
                    break;
                case 3:
                    Console.Clear();
                    break;
                case 4:
                    isStillWorks = false;
                    break;
                default:
                    Console.WriteLine("Неизвестная команда");
                    break;
            };
        }
        
    }
}