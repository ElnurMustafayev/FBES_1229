#print("start")

#while True:
#    print("1")

#    while True:
#        print("2")

#    break

#print("end")


#import random;

#while True:
#    print("Get up")

#    print("Cook breakfast")
#    print("Start to eat")

#    eatCount = random.randint(5, 10)

#    while eatCount != 0:
#        print("Eating...")
#        eatCount -= 1

#        if eatCount == 0:
#            break

#    print("Go to sleep")



#while True:
#    print("one")
#    print("two")
#    print("three")
#    #break
#    continue
#    print("four")
#    print("five")



#num = int(input())

## GOOD practice
#while True:
#    num -= 1

#    if (num % 3) != 0:
#        continue

#    print(num)

#    if num == 0:
#        break

## BAD practice
#num -= 1
#print(num)
#num -= 1
#print(num)
#num -= 1
#print(num)
#num -= 1
#print(num)
#num -= 1
#print(num)



# input:    10
# ouptut:   9 6 3 

# input:    -10
# ouptut:   -9 -6 -3 

num = -33

while num != 0:
    num += (1) if num < 0 else (-1)

    if num % 5 == 0:
        print(num)