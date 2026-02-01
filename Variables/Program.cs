public static class Program
{
    static void Main(string[] args)
    {
        bool isSomething = true;
        int integerNumber = 10;
        float floatNumber = 5F;
        uint unsignedIntegerNumber = 10;
        string name = "Oleg";
        double doubleNumber = 5d;
        char letter = 'a';
        char anotherLetter = (char)(letter + 1);
        char[] letters = { 'a', 'b', 'c' };
        object[] objects = { isSomething, integerNumber, floatNumber, unsignedIntegerNumber, name, doubleNumber, letter, anotherLetter };
        foreach (var obj in objects)
        {
            Console.WriteLine(obj);
        }
    }
}