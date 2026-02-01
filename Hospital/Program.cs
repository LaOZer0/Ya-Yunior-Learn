public static class Program
{
    public static void Main(string[] args)
    {
        var minCountPeople = 0;
        Console.Write("Введите кол-ов пациентов в очереди: ");

        if (int.TryParse(Console.ReadLine(), out var countPeople) == false || countPeople < minCountPeople)
        {
            Console.WriteLine($"Кол-во людей должно быть числом большим {minCountPeople}");
            return;
        }

        var baseWaitingTimeInMinutes = 10;
        var waitingYourTurnInMinutes = countPeople * baseWaitingTimeInMinutes;

        var minutesInHour = 60;
        var countHoursInQueue = waitingYourTurnInMinutes / minutesInHour;
        var countMinutesInQueue = waitingYourTurnInMinutes % minutesInHour;

        Console.WriteLine($"Вы должны отстоять в очереди {countHoursInQueue} часа и {countMinutesInQueue} минут.");

    }
}