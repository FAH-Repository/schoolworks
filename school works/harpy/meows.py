class Cat:
    MEOW = 3

    def meow(self):
        for _ in range(Cat.MEOW):
            print("Meow!")

cat = Cat()
cat.meow()