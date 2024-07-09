class Person:

    def __init__(self, name, salary):
        self.name = name
        self.salary = salary

    def salary(self):
        return self._salary

    def salary(self, value):
        self._salary = value

    def say_hi(self):
        print(f'Hello, my name is {self.name} and my salary is {self.salary}$')


obj1 = Person('Uday singh', 10000)
obj1.say_hi()


# obj2 = Person()
# obj2.say_hi()