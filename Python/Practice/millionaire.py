import random

bank = 0
isCorrect = True

fiftyfifty = True
audience = True
call = True

question1 = "2 + 2 = ?"
variant1A = "A) 4"
variant1B = "B) 3"
variant1C = "C) 2.5"
variant1D = "D) 10"
correctAnswer1 = variant1A


question2 = "5 // 3 = ?"
variant2A = "A) 1"
variant2B = "B) 23"
variant2C = "C) 42.5"
variant2D = "D) 14.4"
correctAnswer2 = variant2A




print("Welcome to Millionaire Game! \n\n\n")

print("Victory table")
print("3-rd. question - 50000$")
print("2-nd. question - 5000$")
print("1-st. question - 1000$")



# 1 QUESTION
if isCorrect:
    print("\n\n\n")
    print("1. " + question1)
    print(variant1A)
    print(variant1B)
    print(variant1C)
    print(variant1D)

    print("Also you can press: ")

    if fiftyfifty:
        print("1 to '50/50'")
    if audience:
        print("2 to 'audience'")
    if call:
        print("3 to 'call'")

    answer = input("Select variant: ")





    # 50/50
    if answer == "1" and fiftyfifty:
        fiftyfifty = False
        incorrectVariantIndex = random.randint(1, 3)
        isCorrectFirst = random.randint(1, 2) == 1

        if isCorrectFirst:
            print(correctAnswer1)

            if incorrectVariantIndex == 1:
                print(variant1B)
            elif incorrectVariantIndex == 2:
                print(variant1C)
            elif incorrectVariantIndex == 3:
                print(variant1D)

        elif not(isCorrectFirst):
            if incorrectVariantIndex == 1:
                print(variant1B)
            elif incorrectVariantIndex == 2:
                print(variant1C)
            elif incorrectVariantIndex == 3:
                print(variant1D)

            print(correctAnswer1)

        answer = input("Select variant: ")





    isCorrect = answer == "A" or answer == "a"
    if isCorrect:
        bank += 1000



# 2 QUESTION
if isCorrect:
    print("\n\n\n")
    print("2. " + question2)
    print(variant2A)
    print(variant2B)
    print(variant2C)
    print(variant2D)

    print("Also you can press: ")
    if fiftyfifty:
        print("1 to '50/50'")
    if audience:
        print("2 to 'audience'")
    if call:
        print("3 to 'call'")

    answer = input("Select variant: ")

    # 50/50
    if answer == "1" and fiftyfifty:
        fiftyfifty = False
        incorrectVariantIndex = random.randint(1, 3)
        isCorrectFirst = random.randint(1, 2) == 1

        if isCorrectFirst:
            print(correctAnswer2)

            if incorrectVariantIndex == 1:
                print(variant2B)
            elif incorrectVariantIndex == 2:
                print(variant2C)
            elif incorrectVariantIndex == 3:
                print(variant2D)

        elif not(isCorrectFirst):
            if incorrectVariantIndex == 1:
                print(variant2B)
            elif incorrectVariantIndex == 2:
                print(variant2C)
            elif incorrectVariantIndex == 3:
                print(variant2D)

            print(correctAnswer2)

        answer = input("Select variant: ")

    isCorrect = answer == "A" or answer == "a"
    if isCorrect:
        bank += 4000

if isCorrect:
    print(f"You won! Your bank: {bank}")
else:
    print(f"You lose with bank: {bank}")