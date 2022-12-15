class Vault:
    def __init__(self, galleons=0, sickles=0, gnuts=0):
        self.galleons = galleons
        self.sickles = sickles
        self.gnuts = gnuts

    def __str__(self):
        return f"{self.galleons} Galleons, {self.sickles} sickles, {self.gnuts} gnuts"

    def __add__(self, other):
        galleons = self.galleons + other.galleons
        sickles = self.sickles + other.sickles
        gnuts = self.gnuts + other.gnuts
        return Vault(galleons, sickles, gnuts)



potter = Vault(100, 50, 25)
print(potter)

weasley = Vault(25, 50, 100)
print(weasley)


total = potter + weasley
print(total)