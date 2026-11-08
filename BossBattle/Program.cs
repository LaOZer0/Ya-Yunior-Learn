public static class Program
{
    public static void Main(string[] args)
    {
        int maxPlayerHealth = 100;
        int maxPlayerManapull = 30;
        int swordDamage = 10;
        int fireballDamage = 20;
        int fireballManacost = 10;
        int explosionDamage = 30;
        int recoveryCount = 2;
        int playerHealth = 100;
        int playerManapull = 30;
        int playerAction;

        bool isFireballCasted = false;

        int bossHealth = 150;
        int bossDamage = 20;

        while (bossHealth > 0 && playerHealth > 0)
        {
            Console.WriteLine($"Ваше здоровье: {playerHealth}. Мана: {playerManapull}");
            Console.WriteLine($"Здоровье босса: {bossHealth}");
            Console.WriteLine("Выберите действие:");
            Console.WriteLine($"[1] Удар мечом. Урон: {swordDamage}");
            Console.WriteLine($"[2] Огненный шар. Урон: {fireballDamage}. Затраты маны: {fireballManacost}");
            Console.WriteLine($"[3] Взрыв. Урон: {explosionDamage}. Предварительно необходимо использовать огненный шар");
            Console.WriteLine($"[4] Восстановление здоровья и маны. Оставшееся количество использований: {recoveryCount}");

            Int32.TryParse(Console.ReadLine(), out playerAction);

            switch (playerAction)
            {
                case 1:
                    bossHealth -= swordDamage;
                    break;

                case 2:
                    if (playerManapull <= 0)
                    {
                        Console.WriteLine("Недостаточно маны");
                        break;
                    }

                    bossHealth -= fireballDamage;
                    playerManapull -= fireballManacost;
                    isFireballCasted = true;
                    break;

                case 3:
                    if (isFireballCasted == false)
                    {
                        Console.WriteLine("Перед использованием необходимо использовать огненный шар!");
                        break;
                    }

                    bossHealth -= explosionDamage;
                    isFireballCasted = false;
                    break;

                case 4:
                    if (recoveryCount == 0)
                    {
                        Console.WriteLine("Вы истратили всё восстановление");
                        break;
                    }

                    playerHealth = maxPlayerHealth;
                    playerManapull = maxPlayerManapull;
                    recoveryCount -= 1;
                    break;

                default:
                    Console.WriteLine("Неизвестное действие");
                    break;
            }

            playerHealth -= bossDamage;
        }

        if (playerHealth <= 0 && bossHealth <= 0)
        {
            Console.WriteLine("Вы оба мертвы. Ничья");
        }

        else if (playerHealth <= 0)
        {
            Console.WriteLine("Вы мертвы. Поражение");
        }

        else
        {
            Console.WriteLine("Босс мертв. Победа");
        }
    }
}