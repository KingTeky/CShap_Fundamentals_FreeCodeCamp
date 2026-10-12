// This is a FOR loop

for (int i = 0; i < 5; i++)
{
    Console.WriteLine(i);
}

// This is a WHILE loop
int j = 0;
while (j < 5)
{
    Console.WriteLine(j);
    j++;
}
Console.WriteLine("...\n");

// This is a WHILE loop

int health  = 3;

while (health > 0)
{
    Console.WriteLine($"Player is alive. Health: {health}");
    health--;
}
Console.WriteLine("...\n");

// THis is a DO-WHILE loop.

int attempts = 0;

do
{
    attempts++;
    Console.WriteLine($"Attempt number: {attempts}");
} //Notice the "while" condition comes after the loop body
while (attempts < 5);
Console.WriteLine(" End of examples...\n");