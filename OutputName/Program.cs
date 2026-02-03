using System.Text;

public static class Program
{


    public static void Main(string[] args)
    {
        int countExtraSymbol = 2;
        Console.WriteLine("Введите ваше имя");
        var name = Console.ReadLine();
        Console.WriteLine("Введите символ");
        int totalLength = name.Length + countExtraSymbol;
        var symbols = new StringBuilder(totalLength).Insert(0, Console.ReadLine(), totalLength).ToString();
        
        for (var i = 0; i < 3; i++)
        {
            if (i == 1)
            {
                Console.WriteLine(symbols.Remove(1, name.Length).Insert(1, name));
                continue;
            }

            Console.WriteLine(symbols);
        }
    }
}