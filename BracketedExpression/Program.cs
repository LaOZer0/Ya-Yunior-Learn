public static class Program
{
    public static void Main(string[] args)
    {
        const char OpenBracket = '(';
        const char CloseBracket = ')';

        int countBracket = 0;
        int maxDepthExpression = 0;

        string? bracketedExpression = Console.ReadLine();

        if (bracketedExpression == null)
        {
            return;
        }

        foreach (var bracket in bracketedExpression)
        {
            if (bracket == OpenBracket)
            {
                countBracket++;
            }
            else if (bracket == CloseBracket)
            {
                countBracket--;
            }

            if (countBracket < 0)
            {
                break;
            }

            if (countBracket > maxDepthExpression)
            {
                maxDepthExpression = countBracket;
            }
        }

        if (countBracket != 0)
        {
            Console.WriteLine("Некорректное выражение");
        }
        else
        {
            Console.WriteLine($"“{bracketedExpression}” -строка корректная и максимум глубины равняется {maxDepthExpression}");
        }
        
    }
}