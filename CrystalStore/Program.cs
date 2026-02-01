public static class Program
{
    public static void Main(string[] args)
    {
        var objectCountMin = 0;
        
        Console.Write("Введите начальное кол-во золота: ");

        if (int.TryParse(Console.ReadLine(), out var playerGoldCount) == false || playerGoldCount < objectCountMin)
        {
            Console.WriteLine($"Кол-во золота должно быть числом больше {objectCountMin}");
            return;
        }

        var crystalPrice = 10;
        Console.Write($"Введите кол-во кристаллов, которое вы хотите купить. Цена {crystalPrice}: ");

        if (int.TryParse(Console.ReadLine(), out var boughtCrystalCount ) == false || boughtCrystalCount < objectCountMin)
        {
            Console.WriteLine($"Кол-во кристаллов должно быть числом больше {objectCountMin}");
            return;
        }

        playerGoldCount = Math.Max(playerGoldCount - boughtCrystalCount * crystalPrice, objectCountMin);
        Console.WriteLine($"Остаток золота: {playerGoldCount} \nКуплено кристаллов: {boughtCrystalCount}");
    }
}