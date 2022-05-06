import random;

question1 = "1. 2 + 2 = ?"
variant1A = "A) 4"
variant1B = "B) 3"
variant1C = "C) 2.5"
variant1D = "D) 10"
correctAnswer1 = variant1A


print(question1)

print(variant1A)
print(variant1B)
print(variant1C)
print(variant1D)

print("\n\n\n")

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