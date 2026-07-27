#include <iostream>
#include <windows.h>

// Revisiting Lambdas

// Lambda is a definition of functionality that can be defined inside statements and expressions
[] {
    std:: cout<< "Hello Lambda" << std:: endl;
}

// you can call it directly
[] {
    std::cout << "hello lambda" << std::endl;
} ();   //prints "hellow lambda"

// or pass it to objects to get called
auto 1 = [] {
    std::cout << "hello lambda" << std::endl;
};


1(); // prints "hello lambda"

