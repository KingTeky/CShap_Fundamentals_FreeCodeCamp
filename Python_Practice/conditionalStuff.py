"""" RANDOM CONDITIONAL STUFF """
#print("Enter a number")
userName = input(" Enter your name: ")
userNumber = int(input(" Enter a number: "))

remainderDigits = 88 % userNumber

print(f" % (modulus) is {remainderDigits}")


x = remainderDigits

#function prints x
"""def displayX():
    global x
    if x < 0:
        pass

    if x== 0:
        print(f"X is {x}!")

    if x > 0:
        print(f" X is {x * remainderDigits}")"""
#function returns x
def displayX():
    global x
    if x < 0:
        return x

    if x == 0:
        return x

    if x > 0:
        return x * remainderDigits

displayX()


def jumpingCharacter():
    
    valuex = displayX()

    if valuex > 0:
        print(f" {userName} is jumping ahead!\n")
    elif valuex < 0:
        print(f" {userName} will take a step back!\n")
    else:
        print(f" {userName} will move {valuex} places in any direction\n")

jumpingCharacter()


