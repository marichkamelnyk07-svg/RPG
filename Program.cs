Console.OutputEncoding = System.Text.Encoding.UTF8;

int heroHealth = 100;
int monsterHealth = 100;

while (true)
{
    int heroDamage = Attack();
    monsterHealth -= heroDamage;
    if (monsterHealth <= 0)
    {
        Console.WriteLine($"Герой наносить {heroDamage} урону та перемагає!");
        break;
    }
    else
    {
        Console.WriteLine($"Герой вдарив на {heroDamage} урону. У монстра залишилось {monsterHealth} HP\n");
    }
    int monsterDamage = Attack();
    heroHealth -= monsterDamage;
    if (heroHealth <= 0)
    {
        Console.WriteLine($"Монстр наносить {monsterDamage} урону та перемагає!");
        break;
    }
    else
    {
        Console.WriteLine($"Монстр вдарив на {monsterDamage} урону. У героя залишилось {heroHealth} HP\n");
    }
}

static int Attack()
{
    Random random = new Random();
    return random.Next(5, 21);
}