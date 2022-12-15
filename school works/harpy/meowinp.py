def meow(n: int)-> None: # : type suggest python make the var in this case n that type, however this is a suggestion to python rather then law, can use mypy to check if python is respecting the type suggestions
    """ MEOW n times  
    :param n: number of times to meow
    :type n: int
    :raise TypeError: If n is not an int
    :return: A string of n meows, one per line
    :rtype: str
    """
    
#for professional doucmention notes use triple qoutes within functions and documentation can be generation from these docstrings, this is all third party convention non python per se
# can be used to auto generate documentation
# """ MEOW n times  """
    for _ in range(n):# -> None just says this should return None so no return
        print("meow")
        #can avoid this weird stuff by using -> str to retrun str
        # and use return "meow\n" * n

number = int(input("Number: "))# a strong type assertation is generally still needed, so really type hints as ^^ are for programmers reading/nderstanding
#meow(number)
meows: str = meow(number)# can be usefull for testing we return meows and None using this def hyas no return so returns none because meows is assigned to the return of def meow
print(meows)

