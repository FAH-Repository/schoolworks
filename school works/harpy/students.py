import csv

name = str(input("what is your name? "))
home = str(input("where's your home? "))


with open("students.csv", "a") as file:
    writer = csv.writer(file)
    writer.writerow([name, home])

    