import random

class Hat:# inits create a new for every instance, just creating means all Hats/objs have this by default
    houses = ["Gryffindor", "Hufflepuff", "Ravenclaw", "Slytherin"]#list of constants/ commonly used mainly used stuff at the top

    @classmethod
    def sort(cls, name):#cls means class
        print(name, "in house", random.choice(cls.houses))#cls.var makes it a class variable accessible by cls.houses so you dont have to make hat objects


#hat = Hat()
Hat.sort("Harry")# capital H calling the class instead of an object from the class, we dont need multiple sorting hats we dont need students with seperate stats, just need a static tool


