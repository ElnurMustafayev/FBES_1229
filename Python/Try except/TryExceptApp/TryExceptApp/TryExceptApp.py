#print("start")

#numstrasd = input()

## if numstr.isdigit() and int(numstr) != 0: 
#try:
#    print(10 / int(numstr))
#except Exception as ex:
#    print(ex)

#print("end")


#print("Hello World")

#try:
#    print(10 / 0)
#except Exception as ex:
#    print(ex)


#def AskNumber():
#    numstr = input("Input number: ")
#    num = int(numstr)
#    return num

#try:
#    print(AskNumber())
#    print("end")
#except Exception as ex:
#    print(ex)

#print("after except")


#group = []

#def PrepareNewUser(name, surname, age):
#    if(int(age) < 0):
#        print("Age can not be less than 0")
#        raise Exception("Age can not be less than 0")
#    else:
#        return f"{name} {surname} {age}"


#def AddUserInGroup(newUser):
#    global group
#    group.append(newUser)
    

#def ShowGroup():
#    global group

#    for user in group:
#        print(user)


#while True:
#    try:
#        newUser = PrepareNewUser(input("Name: "), input("Surname: "), input("Age: "))
#        AddUserInGroup(newUser)
#        ShowGroup()
#    except Exception as ex:
#        print(ex)





#def PrepareNewUser(name, surname, age):
#    if(int(age) < 0):
#        raise Exception("Age can not be less than 0")
#    else:
#        return f"{name} {surname} {age}"



#print(PrepareNewUser(input("Name: "), input("Surname: "), input("Age: ")))