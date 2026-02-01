public static class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Введите ваше имя: ");
        var name = Console.ReadLine();
        Console.Write("Введите ваш возраст от 0 до 130: ");
        if (!Int32.TryParse(Console.ReadLine(), out var age) || age < 0 || age > 130)
        {
            Console.WriteLine("Возраст должен быть положительным числом от 0 до 130");
            return;
        }
        Console.Write("Введите ваш знак зодиака: ");
        var zodiac = Console.ReadLine();
        Console.Write("Введите вашу профессию: ");
        var job = Console.ReadLine();
        Console.WriteLine($"Вас зовут {name}, ваш возраст {age}, ваш знак зодиака {zodiac}, ваша профессия {job}");
    }
}