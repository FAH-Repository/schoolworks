def total(galleons, sickles, gnuts):
    return(galleons * 17 + sickles) * 29 + gnuts

coins = [100, 50, 25]
print(total(*coins), " gnuts")# using unpacked list

coins2 = {"galleons":100,"sickles": 50,"gnuts": 25}
print(total(**coins2), " gnuts")#unpacking dict



def f(*args, **kwargs):#takes variable number of positional arguments the names are convention the * are operators, kwargs is names args, args is positional args
    print("Named:", kwargs)


f(galleons= 100,sickles=50,gnuts=25)

