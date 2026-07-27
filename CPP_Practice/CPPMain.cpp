#include <iostream>
#include <windows.h>

using namespace std; // using standard to avoid declaring it before every function or variable in entire program

/// C++ Practice, basics

/*first create function definition, before calling it in Main. Usually definitions are placed above Main.
However,This standard practice, not requirement; a definition can be created after Main with no consequence.

However a declaration must happen before any function (No nested functions) or any global variable is used.
This is critical to a C++ program. The declaration can be placed in the global space above Main or inside of Main,
as long as it appears BEFORE its first use. */

// funtion that returns a type of double. the double type must return something.
double square(double x)
{
    return x*x;
}

/* funtion that returns a type of void. the void type is used to perform an action, but not to produce a value.
A void type tells the program "this function is an action, not a computation",
or to the user "I will do something, or produce a side-effect (like print a file or display a message), but not return a value"
in other words "Do something but return nothing".
*/

//Do nothing
void empty()
{ return;}

// "Do something but return nothing". In this case, logging.
void logMessage(const std::string& msg) {
    std::cout << msg << "\n";
}

// "Do something but return nothing". In this scenario, update a global or static variable.
int counter = 12;

void increment() {
    counter++;
}

// "Do something but return nothing". Here we greet someone.
void greet() {
    std::cout << "Hello!\n";
}


// use functions, global variables and local variables in Main
int main()
{   
    //this is unncessary as it is already declared globally, but it does not hurt the program.
    // the debugger may give you a warning 'thinking' that you are redifining the same variable
    // It is BAD PRACTICE to name variables the same! this is just to demonstrate you can do this legally.
    //extern int counter; 
    
    int counter;  //local counter variable
    counter = 0;

    double num;
    cout << "\nEnter a numer: ";
    cin >> num;
    
    increment();
    //typical/classic c++ clout chaining
    cout << "\nThe square of " << num << " is "<<square(num)<< "\n" << endl;
    
    //old C-style, printf- style formatting still works in C++ it is not type-safe but it is widely used.
    printf("Global counters %d, local counter is %d\n", ::counter, counter);

    cout<<"\n Basics are 90% of all programming :)\n\n";
    return 0;
}