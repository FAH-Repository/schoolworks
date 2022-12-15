import random
grocerylist = ["tomato", "banana", "ice-cream"]
prices = [5.4, 53, 9.7]
def all_snacks(snack, spacer, num):
    print((snack+spacer)*num)

def in_grocery(grocery_item):
    if grocery_item in grocerylist:
        return True
    else:
        return False

def price_matcher():
    rando = random.randint(0,len(prices)-1)
    item = grocerylist[rando]
    price = prices[rando]
    return item, price

def free_change():
    item, price = price_matcher()
    print(item, abs(10-price))


free_change()
print(in_grocery("tomato"))
all_snacks("choccytaco", "-", 1)