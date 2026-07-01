// Initial challenge code!

/*
string str = "The quick brown fox jumps over the lazy dog.";
// convert the message into a char array
char[] charMessage = str.ToCharArray();
// Reverse the chars
Array.Reverse(charMessage);
int x = 0;
// count the o's
foreach (char i in charMessage) { if (i == 'o') { x++; } }
// convert it back to a string
string new_message = new String(charMessage);
// print it out
Console.WriteLine(new_message);
Console.WriteLine($"'o' appears {x} times.");

*/


// MY IMPROVED VERSION OF THE CODE:

/*
   This code  creates an reverse message array from a string, counts the number of times 
   a particular character appears, then prints the results
   to the console window.
 */

string foxMessage = "The quick brown fox jumps over the lazy dog.";

char[] newMessageArray = foxMessage.ToCharArray();
Array.Reverse(newMessageArray);

int x = 0;
foreach (char i in newMessageArray) {
    if (i == 'o'){
         x++; }
    }

Console.WriteLine(newMessageArray);
Console.WriteLine($"'o' appears {x} times.");

// ADDITIONAL IMPROVEMENTS USING LINQ NOTATION, IDIOMATIC C#:
/*
   This code reverses a message, counts the number of times 
   a particular character appears, then prints the results
   to the console window.
 */
Console.WriteLine("\n\n");

string dogMessage = "The FAST brown Dog jumps high over the lazy fox.";

string reversed = new string(dogMessage.Reverse().ToArray());
int countO = reversed.Count(c => c == 'o');

Console.WriteLine(reversed);
Console.WriteLine($"'o' appears {countO} times.");
