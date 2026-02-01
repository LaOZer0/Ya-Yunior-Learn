public static class Program
{
    public static void Main(string[] args)
    {
        var picturesInRow = 3;
        var totalPictures = 52;
        var fullRows = totalPictures / picturesInRow;
        var extraPictures = totalPictures % picturesInRow;
        Console.WriteLine($"Полных рядов по {picturesInRow} картинки: {fullRows}");
        Console.WriteLine($"Лишних картинок: {extraPictures}");
    }
}