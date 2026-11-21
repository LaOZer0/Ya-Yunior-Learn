public static class Program
{
    public static void Main(string[] args)
    {
        const string AddCommand = "1";
        const string PrintCommand = "2";
        const string DeleteCommand = "3";
        const string SearchCommand = "4";
        const string ExitCommand = "5";

        string[] arrayNames = [];
        string[] arrayPosts = [];

        string inputCommand = "";

        while (inputCommand != ExitCommand)
        {
            Console.WriteLine("Выберите команду");
            Console.WriteLine($"[{AddCommand}] Добавить пользователя");
            Console.WriteLine($"[{PrintCommand}] Вывести всех пользователей");
            Console.WriteLine($"[{DeleteCommand}] Удалить пользователя с конкретной позиции");
            Console.WriteLine($"[{SearchCommand}] Найти всех пользователей по фамилии");
            Console.WriteLine($"[{ExitCommand}] Выйти");
            inputCommand = Console.ReadLine();

            switch (inputCommand)
            {
                case AddCommand:
                    Console.WriteLine("Введите новое имя: ");
                    string newName = Console.ReadLine();
                    AddElement(ref arrayNames, newName);

                    Console.WriteLine("Введите новую должность: ");
                    string newPost = Console.ReadLine();
                    AddElement(ref arrayPosts, newPost);
                    break;

                case PrintCommand:
                    PrintDossier(arrayNames, arrayPosts);
                    break;

                case DeleteCommand:
                    int position;
                    Console.WriteLine("Введите позицию для удаления");

                    if (int.TryParse(Console.ReadLine(), out position) == false)
                    {
                        break;
                    }

                    DeleteDossier(ref arrayNames, ref arrayPosts, position);
                    break;

                case SearchCommand:
                    Console.WriteLine("Введите фамилию для поиска");
                    string surname = Console.ReadLine();
                    SearchOnSurname(arrayNames, arrayPosts, surname);
                    break;
                    
                case ExitCommand:
                    break;

                default:
                    Console.WriteLine("Неизвестная команда");
                    break;
            }

        }
    }

    private static void AddElement(ref string[] array, string newElement)
    {
        ResizeArray(ref array);
        
        int arrayLastIndex = array.Length - 1;
        array[arrayLastIndex] = newElement;
    }

    private static void ResizeArray(ref string[] array)
    {
        int newArrayLength = array.Length + 1;
        string[] tempArray = new string[newArrayLength];

        for (int i = 0; i < array.Length; i++)
        {
            tempArray[i] = array[i];
        }

        array = tempArray;
    }

    private static void ResizeArray(ref string[] array, int position)
    {
        int newArrayLength = array.Length - 1;

        if (newArrayLength == 0)
        {
            array = new string[0];
        }

        string[] tempArray = new string[newArrayLength];

        for (int i = 0; i < array.Length; i++)
        {
            if (i < position)
            {
                tempArray[i] = array[i];
            }
            else if (i > position)
            {
                tempArray[i - 1] = array[i];
            }
        }

        array = tempArray;
    }

    private static void PrintDossier(string[] arrayNames, string[] arrayPosts)
    {
        for (int i = 0; i < arrayNames.Length; i++)
        {
            Console.WriteLine(arrayNames[i] + " - " + arrayPosts[i]);
        }
    }

    private static void PrintDossier(string name, string post)
    {
        Console.WriteLine(name + " - " + post);
    }

    private static void SearchOnSurname(string[] arrayNames, string[] arrayPosts, string surname)
    {
        for (int i = 0; i < arrayNames.Length;i++)
        {
            string currentSurname = arrayNames[i].Split()[0];

            if (currentSurname == surname)
            {
                PrintDossier(arrayNames[i], arrayPosts[i]);
            }
        }
    }

    private static void DeleteDossier(ref string[] arrayNames, ref string[] arrayPosts, int position)
    {
        ResizeArray(ref arrayNames, position);
        ResizeArray(ref arrayPosts, position);
    }
}