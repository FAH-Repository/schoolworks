import random
p=100000
q=999000

def isPrime(n):
    for i in range(2,int(n**0.5)+1):
        if n%i==0:
            return False

    return True


primes = [i for i in range(p,q) if isPrime(i)]
n = random.choice(primes)
z = random.choice(primes)
print(n)
print(z)