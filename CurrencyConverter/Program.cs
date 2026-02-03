public static class Program
{
    

    public static void Main(string[] args)
    {
        const int CommandRubleToDollar = 0;
        const int CommandDollarToRuble = 1;
        const int CommandRubleToEuro = 2;
        const int CommandEuroToRuble = 3;
        const int CommandDollarToEuro = 4;
        const int CommandEuroToDollar = 5;
        const int CommandExit = 6;

        const float ExchangeRateDollarsToEuro = 10;
        const float ExchangeRateRublesToDollar = 50;
        const float ExchangeRateRublesToEuro = 100;
        const float ExchangeRateEuroToDollar = 1f / ExchangeRateDollarsToEuro;
        const float ExchangeRateDollarsToRuble = 1f / ExchangeRateRublesToDollar;
        const float ExchangeRateEuroToRuble = 1f / ExchangeRateRublesToEuro;

        bool isStillWorks = true;
        int numberOfCommand;

        Console.Write("Введите изнальное кол-во рублей: ");
        
        if (float.TryParse(Console.ReadLine(), out float rubles) == false)
        {
            Console.WriteLine("Количество денег должно быть числом");
            return;
        }

        Console.Write("Введите изнальное кол-во долларов: ");

        if (float.TryParse(Console.ReadLine(), out float dollars) == false)
        {
            Console.WriteLine("Количество денег должно быть числом");
            return;
        }

        Console.Write("Введите изнальное кол-во евро: ");

        if (float.TryParse(Console.ReadLine(), out float euro) == false)
        {
            Console.WriteLine("Количество денег должно быть числом");
            return;
        }

        while (isStillWorks)
        {
            Console.WriteLine($"Кол-во рублей: {rubles}");
            Console.WriteLine($"Кол-во долларов: {dollars}");
            Console.WriteLine($"Кол-во евро: {euro}");

            Console.WriteLine("Выберите номер команды: ");
            Console.WriteLine($"{CommandRubleToDollar}. Обмен рублей на доллары {ExchangeRateRublesToDollar} к 1");
            Console.WriteLine($"{CommandDollarToRuble}. Обмен долларов на рубли {ExchangeRateDollarsToRuble} к 1");
            Console.WriteLine($"{CommandRubleToEuro}. Обмен рублей на евро {ExchangeRateRublesToEuro} к 1");
            Console.WriteLine($"{CommandEuroToRuble}. Обмен евро на рубли {ExchangeRateEuroToRuble} к 1");
            Console.WriteLine($"{CommandDollarToEuro}. Обмен долларов на евро {ExchangeRateDollarsToEuro} к 1");
            Console.WriteLine($"{CommandEuroToDollar}. Обмен евро на доллары {ExchangeRateEuroToDollar} к 1");
            Console.WriteLine($"{CommandExit}. Команда для выхода");

            if (int.TryParse(Console.ReadLine(), out numberOfCommand) == false)
            {
                Console.WriteLine("Номер команды должен быть числом");
                continue;
            }

            int amountOfMoney;

            switch (numberOfCommand)
            {
                case CommandRubleToDollar:
                    Console.WriteLine("Сколько долларов вы хотите получить?");

                    if (int.TryParse(Console.ReadLine(), out amountOfMoney) == false)
                    {
                        Console.WriteLine("Количество денег должно быть числом");
                        break;
                    }

                    if (rubles - amountOfMoney * ExchangeRateRublesToDollar < 0)
                    {
                        Console.WriteLine("У вас мало рублей");
                        break;
                    }

                    dollars += amountOfMoney;
                    rubles -= amountOfMoney * ExchangeRateRublesToDollar;

                    break;
                case CommandDollarToRuble:
                    Console.WriteLine("Сколько рублей вы хотите получить");

                    if (int.TryParse(Console.ReadLine(), out amountOfMoney) == false)
                    {
                        Console.WriteLine("Количество денег должно быть числом");
                        break;
                    }

                    if (dollars - amountOfMoney * ExchangeRateDollarsToRuble < 0)
                    {
                        Console.WriteLine("У вас мало долларов");
                    }

                    rubles += amountOfMoney;
                    dollars -= amountOfMoney * ExchangeRateDollarsToRuble;

                    break;
                case CommandRubleToEuro:
                    Console.WriteLine("Сколько евро вы хотите получить");

                    if (int.TryParse(Console.ReadLine(), out amountOfMoney) == false)
                    {
                        Console.WriteLine("Количество денег должно быть числом");
                        break;
                    }

                    if (rubles - amountOfMoney * ExchangeRateRublesToEuro < 0)
                    {
                        Console.WriteLine("У вас мало рублей");
                    }

                    euro += amountOfMoney;
                    rubles -= amountOfMoney * ExchangeRateRublesToEuro;

                    break;
                case CommandEuroToRuble:
                    Console.WriteLine("Сколько рублей вы хотите получить");

                    if (int.TryParse(Console.ReadLine(), out amountOfMoney) == false)
                    {
                        Console.WriteLine("Количество денег должно быть числом");
                        break;
                    }

                    if (euro - amountOfMoney * ExchangeRateEuroToRuble < 0)
                    {
                        Console.WriteLine("У вас мало евро");
                    }

                    rubles += amountOfMoney;
                    euro -= amountOfMoney * ExchangeRateEuroToRuble;

                    break;
                case CommandDollarToEuro:
                    Console.WriteLine("Сколько евро вы хотите получить");

                    if (int.TryParse(Console.ReadLine(), out amountOfMoney) == false)
                    {
                        Console.WriteLine("Количество денег должно быть числом");
                        break;
                    }

                    if (dollars - amountOfMoney * ExchangeRateDollarsToEuro < 0)
                    {
                        Console.WriteLine("У вас мало долларов");
                    }

                    euro += amountOfMoney;
                    dollars -= amountOfMoney * ExchangeRateDollarsToEuro;

                    break;
                case CommandEuroToDollar:
                    Console.WriteLine("Сколько долларов вы хотите получить");

                    if (int.TryParse(Console.ReadLine(), out amountOfMoney) == false)
                    {
                        Console.WriteLine("Количество денег должно быть числом");
                        break;
                    }

                    if (euro - amountOfMoney * ExchangeRateEuroToDollar < 0)
                    {
                        Console.WriteLine("У вас мало евро");
                    }

                    dollars += amountOfMoney;
                    euro -= amountOfMoney * ExchangeRateEuroToDollar;

                    break;
                case CommandExit:
                    isStillWorks = false;
                    break;
                default:
                    Console.WriteLine("Неизвестная команда");
                    break;
            }
            ;
        }

    }
}