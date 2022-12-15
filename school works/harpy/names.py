import csv

students = []
with open("students.csv")as file:
    reader = csv.DictReader(file)
    for row in reader:
        students.append({"name": row["name"], "home": row["home"], "house": row["house"]})

for student in sorted(students, key=lambda student: student["name"]):
    print(f"{student['name']} is from {student['home']} and is from house {student['house']}")

"""
with open("names.txt", "r") as file:
    for line in file:
        print("Hello,", li ne.rstrip())


********************************


name = input("Give name: ")
with open("names.txt", "a") as file:
    file.write(f"{name}\n")
    """
