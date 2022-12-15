from ast import Return


def isdivisibleby7(num):
    if num % 7 == 0:
        return True
    else:
        return False


def isdivisibleby(num, divisor):
    if num % divisor == 0:
        return True
    else:
        return False

def shout_words(words):
    words = words.upper()
    sepWords = words.split(" ")
    for i in sepWords:
        print(i)

def extract_longer(length,sentance):
    sepWords = sentance.split(" ")
    finalWords = []
    for i in sepWords:
        if len(i) > length:
            finalWords.append(i)
    if finalWords:
        return finalWords
    else:
        return False

print(extract_longer(4, "this has some greater than four letter words"))
#shout_words("puppy is mad")
#print(isdivisibleby7(14))
#print(isdivisibleby(14, 7))
'''
i=0
while(True):
    i+=1
    if i == 10:
        print("Wow we got 10 :)")
        continue
    print(i)
    if i >= 20:
        break
    '''