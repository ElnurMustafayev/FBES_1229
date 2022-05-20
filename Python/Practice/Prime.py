def IsNumberPrime(num):
    for item in range(2, num):
        if num % item == 0:
            return False
    return True

def ShowPrimeNumbers(num):
    for item in range(2, num):
        if IsNumberPrime(item):
            print(item)

ShowPrimeNumbers(20)