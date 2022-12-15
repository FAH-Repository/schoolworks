get_cam = input("camelCase: ")
for i in get_cam:
    if i.isupper() == True:
        c1, c2 , c3= get_cam.partition(i)
#final_str = c1+"_"+c2.lower()+c3     works but an extra line so why
print("snake_case: ", c1, "_",c2.lower(), c3, sep="")