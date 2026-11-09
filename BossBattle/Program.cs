public static class Program
{
    public static void Main(string[] args)
    {
        int swordAttack = 1;
        int fireball = 2;
        int explosion = 3;
        int recovery = 4;

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
            Console.WriteLine($"[{swordAttack}] Удар мечом. Урон: {swordDamage}");
            Console.WriteLine($"[{fireball}] Огненный шар. Урон: {fireballDamage}. Затраты маны: {fireballManacost}");
            Console.WriteLine($"[{explosion}] Взрыв. Урон: {explosionDamage}. Предварительно необходимо использовать огненный шар");
            Console.WriteLine($"[{recovery}] Восстановление здоровья и маны. Оставшееся количество использований: {recoveryCount}");

            Int32.TryParse(Console.ReadLine(), out playerAction);

            switch (playerAction)
            {
                case swordAttack:
                    bossHealth -= swordDamage;
                    break;

                case fireball:
                    if (playerManapull < fireballManacost)
                    {
                        Console.WriteLine("Недостаточно маны");
                        break;
                    }

                    bossHealth -= fireballDamage;
                    playerManapull -= fireballManacost;
                    isFireballCasted = true;
                    break;

                case explosion:
                    if (isFireballCasted == false)
                    {
                        Console.WriteLine("Перед использованием необходимо использовать огненный шар!");
                        break;
                    }

                    bossHealth -= explosionDamage;
                    isFireballCasted = false;
                    break;

                case recovery:
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
                    Console.WriteLine("Неизвестное действие. Вы упустили свой ход.");
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
