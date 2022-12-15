
class Student:
    def __init__(self, name, house):       
        self.name = name
        self.house = house
    def __str__ (self):
        return f"{self.name} from {self.house}"

    @property
    def name(self):
        return self._name
    
    @name.setter
    def name(self, name):
        if not name:
            raise ValueError("Missing name")
        self._name = name

    #getter  the @ property TELLS PYTHON THIS IS A GETTER
    @property          
    def house(self):
        return self._house

    #setter, this is just @gettername.setter
    @house.setter
    def house(self, house):
        if house not in ["Gryffindor", "Hufflepuff", "Ravenclaw", "Slytherin"]:
            raise ValueError("Invalid House")
        self._house = house

    @classmethod
    def get(cls):
        name = input("Name: ")
        house = input("House: ")
        return cls(name, house)

def main():
    student = Student.get()
    #student.house = "Number Four, Privet Drive"  this will be caught as an error in the code, using _ however would still set it, there is no private or pretected in python so its honor system _ means dont touch __ means super dont pls no 
    print(student)


if __name__ == "__main__":
    main()