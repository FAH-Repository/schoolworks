groc = ["tomato", "banana", "ice-cream"]

#for x, element in enumerate(groc):
#    print(x, element)
    
def guess_Game(x):
    while True:
        guess = int(input("guess a number:"))
        if guess < x:
            print("nope too low")
        elif guess > x:
            print("nope too high")
        else:
            print("you got it, it was", x)
            break

#guess_Game(50)

def get_index(string, character):
    for index,element in enumerate(string):
        if element == character:
            print(f"{element} at {index}")

#get_index("skyscraper", "c")

def mults_of_five(number):
    nums = []
    i = 1
    while i < number:
        if i % 3 == 0 or i % 5 == 0:
            nums.append(i)
        i+=1    

    print(nums)


#mults_of_five(0)

def list_to_set(inp_list):
    setList = []
    for i in inp_list:
        if i not in setList:
            setList.append(i)
    return setList

testList = ["cow", "cow", "pig", "horse", "horse", "chicken", "rabbit"]
#print(list_to_set(testList))


