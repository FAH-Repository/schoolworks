def main():
    yell("This is me", "and me", "don't forget me")

def yell(*words):
    uppercased = [word.upper() for word in words]
    print(*uppercased)

    #uppercased = map(str.upper, words)
    #print(*uppercased)


    #uppercased = []
    #for word in words:
    #    uppercased.append(word.upper())
    #print(*uppercased)# the star unpacks it to print the content of the list rather then the actual list
    

if __name__ == "__main__":
    main()
