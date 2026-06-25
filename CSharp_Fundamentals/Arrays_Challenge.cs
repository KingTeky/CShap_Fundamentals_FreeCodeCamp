using System;

/*
Arrays Module challenge: You work for an investigative team.

Sort the array of order IDs and find the fraudulent IDs that start with the letter "B".
*/

namespace TestProject
{
    class Program
    {
        static void Main()
        {
            string[] orderIds = [ "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" ];

            Array.Sort(orderIds);

            string[] sortedIDs =  orderIds;

            var fraudulentIDs = new List<string>();

            Console.WriteLine("-These are the fraudulent IDs:\n");
            foreach ( string ID in sortedIDs )
            {
                if (ID.StartsWith("B"))
                {
                    fraudulentIDs.Add(ID);
                   
                }
            }

            Console.WriteLine(string.Join(", ", fraudulentIDs));

            Console.WriteLine("");

            Console.WriteLine("Successfully parsed through the sorted array, and joined in the List<T>()! \n");
            
        }
        
    }
}