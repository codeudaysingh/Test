

array = [56,75,36,367,36]
print(array[0], array[1], array[2], array[3],array[4])


# def num(a,b):
input_1 = input("Enter The integer NO.:")
input_2 =  input("Enter The integer NO.:")
try: 
    a = int(input_1)
    b = int(input_2)
    x = a / b
    print("The value is:",x)
    # y = hello
    # z = x + y
except ZeroDivisionError :
    print("can't devide zero")
except IndentationError :
    print("identation error occour")
# except ValueError:
#     print("enter valid value")
# except :
#     print("An unexpected error occour")

finally :
    print("its done")