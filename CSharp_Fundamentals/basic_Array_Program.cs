using System;

// Challenge: Security department is focused on finding a pattern for fraudulent orders

/* string[] fraudulentOrderIDs = new string[3];

fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";
//fraudulentOrderIDs[3] = "D000"; */

string[] fraudulentOrderIDs = ["A123", "B456", "C789"];

Console.WriteLine(" Fraudulent Order IDs:");
Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

Console.Write("\n");

fraudulentOrderIDs[0] = "F000";

Console.WriteLine("Updated Fraudulent Order IDs:");
Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

// Challenge: Iterate through the array and print each order ID to the console.

Console.WriteLine("\nIterating through the array of fraudulent order IDs:");

foreach (string orderID in fraudulentOrderIDs)
{
    Console.WriteLine($"Order ID: {orderID}");
    
}
Console.WriteLine($"\nThere are '{fraudulentOrderIDs.Length}' fraudulent order Ids to process.");
Console.Write(" Done! \n");

//  Challenge: Calculate the total number of inventory items in stock.");

Console.WriteLine("\nIterating through the array of inventory items in stock:");

int[] inventoryItems = [200, 450, 700, 150, 250];

int IndexNumber = 0;
int Sum = 0;

foreach (int items in inventoryItems)
{
    IndexNumber++;
    Sum += items;
    Console.WriteLine($"Inventory: Order # {IndexNumber} | Items per order = {items} | Running Total is {Sum}");
    
    
}


Console.WriteLine($"\nWe have {Sum} items in inventory.\n");
