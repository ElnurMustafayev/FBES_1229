#def Method():
#    print("1")
#    print("2")
#    print("3")
#    raise Exception()
#    print("4")
#    print("5")
#    print("6")

#try:
#    Method()
#except Exception as ex:
#    print(type(ex))



#import random;

#numbersToShow = list(range(1, int(input()) + 1))

#while len(numbersToShow) != 0:
#    index = random.randint(0, len(numbersToShow) - 1)
#    currentNum = numbersToShow[index]
#    numbersToShow.remove(currentNum)
#    print(currentNum)



def Factorial(num):
    if num == 0:
        return 1
    return num * Factorial(num - 1)





#while True:
#    try:
#        num = int(input())
#        raise FloatingPointError("test")
#        result = Factorial(num)
#        print(result)
#        break

#    except RecursionError:
#        print("Recursion Error!!!")
#        break

#    except ValueError:
#        print("Input has symbols!")
#        continue

#    except Exception as ex:
#        print(f"Some other error here... {type(ex)}")

        
#    #except Exception as ex:
#    #    if type(ex) == RecursionError:
#    #        print("Recursion Error!!!")
#    #        break

#    #    if type(ex) == ValueError:
#    #        print("Input has symbols!")
#    #        continue
    


try:
    print("start")
    print(10 / 0)
except Exception as ex:
    raise ex
finally:
    print("Goodbye User!")


print("End")