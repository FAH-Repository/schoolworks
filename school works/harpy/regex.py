import re
#didnt do much here, you can define regular expressions and search for things of that form like the phone number form below

pnr = re.compile(r'\d\d\d-\d\d\d-\d\d\d\d')
mo = pnr.search("my number is 425-412-0951")
