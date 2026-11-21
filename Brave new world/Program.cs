public static class Program
{
    public static void Main(string[] args)
    {
        char[,] map = { { '#', '#', '#', '#' }, { '#', ' ', ' ', '#' }, { '#', ' ', ' ', '#' }, { '#', '#', '#', '#' } };
        char player = '@';
        int playerX = 1;
        int playerY = 1;

        var pressedKey = new ConsoleKeyInfo();

        while (true)
        {
            Console.Clear();
            DrawMap(map);
            
            Console.SetCursorPosition(playerX, playerY);
            Console.Write(player);

            pressedKey = Console.ReadKey();
            HandlePlayerInput(pressedKey, ref playerX, ref playerY, map);
        }
    }

    private static void HandlePlayerInput(ConsoleKeyInfo pressedKey, ref int playerX, ref int playerY, char[,] map)
    {
        int[] playerDirection = GetDirection(pressedKey);

        int newPlayerX = playerX + playerDirection[0];
        int newPlayerY = playerY + playerDirection[1];

        if (map[newPlayerX, newPlayerY] == ' ')
        {
            playerX = newPlayerX;
            playerY = newPlayerY;
        }
    }

    private static int[] GetDirection(ConsoleKeyInfo pressedKey)
    {
        int[] direction = { 0, 0 };

        if (pressedKey.Key == ConsoleKey.UpArrow)
        {
            direction[1] -= 1;
        }
        else if (pressedKey.Key == ConsoleKey.DownArrow)
        {
            direction[1] += 1;
        }
        else if (pressedKey.Key == ConsoleKey.LeftArrow)
        {
            direction[0] -= 1;
        }
        else if (pressedKey.Key == ConsoleKey.RightArrow)
        {
            direction[0] += 1;
        }

        return direction;
    }

    private static void DrawMap(char[,] map)
    {
        for (int y = 0; y < map.GetLength(1); y++)
        {
            for (int x = 0; x < map.GetLength(0); x++)
            {
                Console.Write(map[x, y]);
            }
            Console.WriteLine();
        }
    }
}