p =5 
q =11
e =3
d =67
m = 2

n = p * q
k = (p-1) * (q-1)
res  = (d*e) % k == 1
c= pow(m, e) % n
md  = pow(c, d) % n


print(res)
print(c)  
print(md)
#answers for 2, 3, and 4 are decrypted as 8, 27, 9