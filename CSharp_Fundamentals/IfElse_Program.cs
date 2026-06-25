using System;

// Challenge: Business logic for a store's promotional discount system
Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

// Your challenge code goes here
Console.WriteLine($"Days until subscription expiration: {daysUntilExpiration}");

if (daysUntilExpiration == 0)
{
    Console.WriteLine("Your subscription has expired.");
}
else if (daysUntilExpiration == 1)
{
    Console.WriteLine("Your subscription expires within a day!");
    discountPercentage = 20;
}
else if (daysUntilExpiration <= 5)
{
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
    discountPercentage = 10;
}
else if (daysUntilExpiration <= 10)
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}

if (discountPercentage > 0)
{
    Console.WriteLine($"Renew now and save {discountPercentage}%.");
}

// End of challenge code
Console.Write("\n");

await Task.Delay(5000);
Console.Clear();

//Game Logic Challenge: Dice Game
Random dice = new();
int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

//int roll1 = 5;
//int roll2 = 4;
//int roll3 = 4;

int totalRoll = roll1 + roll2 + roll3;

Console.WriteLine($"\nDice roll: {roll1} + {roll2} + {roll3} = {totalRoll}\n");

if ((roll1 == roll2) || (roll1 == roll3) || (roll2 == roll3))
{
        if ((roll1 == roll2) && (roll1 == roll3))
            {
        Console.WriteLine("You rolled a triple! +6 bonus to your Total!");

        totalRoll += 6;
        Console.WriteLine($"New Total: {totalRoll}\n");
            }
            
        else{Console.Write("You rolled a pair! +2 bonus to your Total! ");

        totalRoll += 2;
        Console.WriteLine($"New Total: {totalRoll}\n");
            }
}

if (totalRoll >= 16)
{
    Console.WriteLine("You win a new car!");
}
else if (totalRoll >= 10)
{
    Console.WriteLine("You win a new laptop!");
}
else if (totalRoll == 7)
{
    Console.WriteLine("You win a trip for two!");
}
else
{
    Console.WriteLine("You win a kitten!");
}

Console.Write("\n");

await Task.Delay(5000);
Console.Clear();