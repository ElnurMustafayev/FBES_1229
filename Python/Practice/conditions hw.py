# 1) по деволфу переменной var задаётся какое-то значение. 
# Дальше в условии проверяется, если переменная имеет тип данных int - вывести на экран сообщение "It is integer"
# В противном случае - "It is not integer"

# input: 123 
# output: "It is integer"

# input: "qwerty" 
# output: "It is not integer"



# 1
# var = 123

# if type(var) == type(0):
#     print("It is integer")
# if type(var) != type(0):
#     print("It is not integer")



# 2
# var = 123

# isInteger = type(var) == type(0)

# if isInteger:
#     print("It is integer")
# if not isInteger:
#     print("It is not integer")



# 3
# var = True

# message = "It is integer" if type(var) == type(0) else "It is not integer"

# print(message)



# 4
# var = 123

# print("It is integer" if type(var) == type(0) else "It is not integer")





# 2) Если денег больше 40к и есть виза - "Go to USA"
# В противном случае "Error"

# money = float(input("Input your money: "))
# #hasVisa = bool(int(input("Input 0 if you don't have visa...")))
# hasVisa = input("Input 'yes' if you have visa... ") == "yes"

# if money >= 40000 and hasVisa:
#     print("Go to USA")
# else:
#     print("Error")





# 3) В программе зарезервировано 3 валюты и их курсы. 
# Пользователь вводит количество денег
# Дальше, перед пользователем ставится выбор о том, в какую валюту ему нужно сконвертировать свои деньги
# Если выбор не соотвествует условиям - выдать ошибку
# Eсли всё ок - сконвертировать его деньги по указанному курсу

# AZN = 1
# EUR = 1.78
# USD = 1.70

# money = float(input("Input your money: "))

# print("Select currency for exchange: ")
# print("'1' \t for \t AZN")
# print("'2' \t for \t EUR")
# print("'3' \t for \t USD")

# select = input()

# if select == "1":
#     print(money * AZN)
# elif select == "2":
#     print(money * EUR)
# elif select == "3":
#     print(money * USD)
# else:
#     print("Error")