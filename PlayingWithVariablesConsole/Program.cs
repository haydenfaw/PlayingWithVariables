// See https://aka.ms/new-console-template for more information
int age;
string name;
bool isAlive;
char atSymbol;
double valueOfPi;
decimal valueOfGravity;

age = 30;
name = "Hayden";
isAlive = true;
atSymbol = '@';
valueOfPi = 3.141592653;
valueOfGravity = 9.8m;

Console.WriteLine($"Hello, my name is {name}, I am {age} years old. If someone asked me if I were alive then I would say that statement is {isAlive}. Don't {atSymbol} me bro.");
Console.WriteLine($"When learning about physics, gravity is accepted as reasonably having 2 sig figs for most probelms we can use the decimal variable type in programming since it is small. The value of gravity for our use will be {valueOfGravity} m/s^2.");
Console.WriteLine($"When we use the value of pi, the exact value is incredibly long so in order to use as many sig figs as we would like, we use a double variable type. For this example we will stop short at 10 sig figs but in theory this is an infinite decimal which is just silly. For now we will say pi = {valueOfPi}.");
