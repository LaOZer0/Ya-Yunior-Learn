public static class Program
{
    private const int MIN_AGE = 0;
    private const int MAX_AGE = 130;

    public static void Main(string[] args)
    {
        Console.Write("Введите ваше имя: ");
        var name = Console.ReadLine();
        Console.Write($"Введите ваш возраст от {MIN_AGE} до {MAX_AGE}: ");

        if (int.TryParse(Console.ReadLine(), out var age) == false || CheckAge(age))
        {
            Console.WriteLine($"Возраст должен быть положительным числом от {MIN_AGE} до {MAX_AGE}");
            return;
        }

        Console.Write("Введите ваш знак зодиака: ");
        var zodiac = Console.ReadLine();
        Console.Write("Введите вашу профессию: ");
        var job = Console.ReadLine();
        Console.WriteLine($"Вас зовут {name}, ваш возраст {age}, ваш знак зодиака {zodiac}, ваша профессия {job}");
    }

    private static bool CheckAge (int age)
    {
        return age >= MIN_AGE && age <= MAX_AGE;
    }
}