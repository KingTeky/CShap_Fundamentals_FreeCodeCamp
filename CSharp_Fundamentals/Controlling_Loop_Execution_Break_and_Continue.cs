//Controlling Loop Execution with Break and Continue

//Managing FOR loops with Break and Continue

//Break: exit the loop early.

for (int count = 0; count <10; count++)
{
    if (count == 5)
    {
        break; // Exit the loop early when count is 5
    }
    Console.WriteLine($"Count: {count}...");
}
Console.WriteLine("Break condition reached: loop ended.\n");

//Continue: skip the current iteration and move to the next one.
for (int count = 0; count < 10; count++)
{
    if (count == 5)
    {
        continue; // Skip the rest of the loop body when count is 5
    }
    Console.WriteLine(count);
}
Console.WriteLine("Continue loop ended.\n");

//Managing WHILE loops with Break and Continue

while (true)
{
    Console.Write("Type 'exit' to stop the loop...");
    string  userInput= Console.ReadLine();
    if (userInput.ToLower() == "exit")
    {
        break; // Exit the loop immediately
    }
    Console.WriteLine($"You typed: {userInput}");
}
Console.WriteLine("Goodbye!");
Console.WriteLine("Break condition reached: while loop ended.\n");

// Using continue in a WHILE loop
// Attention: make sure to avoid infinite loops when using continue in a while loop
// Must update conditions first to avoid infinite loops when using continue in a while loop.

int currentSlot=0;

while (currentSlot < 5)
{
    currentSlot++; //Crucial: the update happens before the continue check to avoid an infinite loop.
    if (currentSlot == 3)
    {
        Console.WriteLine($"Skipping current item slot {currentSlot}");
        continue; // Skip the rest of the loop body when currentSlot is 3
    }
    Console.WriteLine($"Successfully processed item in Slot: {currentSlot}.");
}
Console.WriteLine("Current inventory scan complete!\n");

Console.WriteLine(" End of examples...\n");