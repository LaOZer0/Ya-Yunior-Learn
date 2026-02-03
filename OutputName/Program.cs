using System.Text;

public static class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите символ");
        string symbol = Console.ReadLine();
        Console.WriteLine("Введите ваше имя");
        var nameWithFrame = $"{symbol}{Console.ReadLine()}{symbol}";
        var symbolsLine = new StringBuilder(nameWithFrame.Length).Insert(0, symbol, nameWithFrame.Length).ToString();
        Console.WriteLine(symbolsLine);
        Console.WriteLine(nameWithFrame);
        Console.WriteLine(symbolsLine);
    }
}
