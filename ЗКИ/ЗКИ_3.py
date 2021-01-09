# Фурман Владислав Владимирович вариант 8 - 3 Шифр Цезаря
alfavit = "абвгдеёжзийклмнопрстуфхцчшщъыьэюяабвгдеёжзийклмнопрстуфхцчшщъыьэюя"
clovo = input("Введите слово для щифрвания: ")
key = int(input("Введите ключ 1-32: "))
clovo = clovo.lower()
otvet = ""
for i in clovo:
    position = alfavit.find(i)
    NewPosition = position + key
    if i in alfavit:
        clovo = clovo + alfavit[NewPosition]
print(clovo)
