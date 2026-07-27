# Keep rehearsing your programming in Python.
# This demonstrates a simple use case of Match Statements
#Bonus: using user input to match

# The C++ equivalent is the Switch statement.

#! first define some functions to use

def positivePhrase():
    return "Match statements are cool!"

def negativePhrase():
    return "Maybe use and if elif chain instead?"



#! now define your match statement.


def sayPhrase ():
    words = input("enter Y or N: ")

    match words:
        case w if w in ("y", "Y") :
            return positivePhrase() + " they are so useful!"
        case w if w in ("n", "N"):
            return negativePhrase() + " you hear?!"
        case _:
            return " i am not sure what to make of this"


# A cleaner version would just call .lower on the input before matching!

# like this:

def cleanerPhrase():
    yesOrNo = input(" enter Y or N: ").lower()


#then match only to y or n

def cleanerPhrase():
    yesOrNo = input(" enter Y or N: ").lower()

    match yesOrNo:
        case "y":
            return positivePhrase() + " they are so useful!"
        case "n":
            return negativePhrase() + " you hear?!"
        case _:
            return " i am not sure what to make of this"