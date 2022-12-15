balance = 0
MEOWS = 3 #all caps says this should be constant dont modify, honor system

def main():# vars defined within a func are local, vars outside vars can be read but not set
    #balance = 0
    print("Balance: ", balance)
    deposit(100)
    withdraw(50)
    print("Balance: ", balance)

def deposit(n):
    global balance# wow kinda stupid but have to manually say your val is global within the def trying to modify it
    balance += n

def withdraw(n):
    global balance
    balance -= n



if __name__ == "__main__":
    main()