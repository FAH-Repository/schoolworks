def main():
    print(f"{convert_fuel()}")


def convert_fuel():
    while True:
        try:
            x = str(input("give us your fuel fraction: "))
            x1, x2 , x3= x.partition("/")
            xf = (int(x1)/int(x3))*100
            if(xf <= 1):
                xf = "E"
            elif xf == 99 or xf == 100:
                xf = "F"            
            return xf    
        except ValueError:
            print("that isnt a fraction")
        except ZeroDivisionError:
            print("dividing by zero is a nono")
        

      
main()
