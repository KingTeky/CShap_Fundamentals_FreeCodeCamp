###################################
# Practice the basics or risk getting rusty
import math
import tkinter as tk

"""TKinter GUI Window"""

"""def say_hello():
    name = entry.get()
    output_label.config(text=f"Hello, {name}!")

root = tk.Tk()
root.title("Tkinter Example")

label = tk.Label(root, text="Enter your name:")
label.pack()

entry = tk.Entry(root)
entry.pack()

button = tk.Button(root, text="Submit", command=say_hello)
button.pack()

output_label = tk.Label(root, text="")
output_label.pack()

root.mainloop()"""

"""Console Program"""

"""print(" Please Enter a first name: >")
name= input()
print(" Please Enter a last name: >")
lastName= input()

age = 35.631
currency= "$"
money= 2000

phrase= f"\n My name is {name}. I have {currency}{money} dollars in my pocket, and my age is {round(age)}!\n"

def phraseFun():
    if name.strip().lower() == "john" and lastName.strip().lower() == "apple":
        print(phrase)
    else:
        print(f"\nIt is not John Apple in here, it is {name.capitalize()} {lastName.capitalize()} instead!\n")

phraseFun()"""

"""TKinter GUI Window With the previous console logic added"""

def phraseFun():
    name = entry_first.get()
    lastName = entry_last.get()

    age = 35.631
    currency = "$"
    money = 2000

    phrase = f"\nMy name is {name} {lastName}. I have {currency}{money} dollars in my pocket, and my age is {round(age)}!\n"

    if name.strip().lower() == "john" and lastName.strip().lower() == "apple":
        output_label.config(text=phrase)
    else:
        output_label.config(
            text=f"\nIt is not John Apple in here, it is {name.capitalize()} {lastName.capitalize()} instead!\n"
        )

def display_Twice(bruce):
    print(bruce)
    print(bruce)

display_Twice("bruce")

root = tk.Tk()
root.title("Name Checker")
root.geometry("400x300") # Set Window size
#root.resizable(False,False) # lock windows size

tk.Label(root, text="Please Enter a first name:").pack()
entry_first = tk.Entry(root)
entry_first.pack()

tk.Label(root, text="Please Enter a last name:").pack()
entry_last = tk.Entry(root)
entry_last.pack()

tk.Button(root, text="Submit", command=phraseFun).pack()

output_label = tk.Label(root, text="", wraplength=300, justify="left")
output_label.pack()

root.mainloop()