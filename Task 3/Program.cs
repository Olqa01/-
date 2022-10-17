// Task 3. Найти максимальное из трех чисел

int numberA = new Random().Next(1,55);
Console.WriteLine(numberA);
int numberB = new Random().Next(55,110);
Console.WriteLine(numberB);
int numberC = new Random().Next(110,165);
Console.WriteLine(numberC);

int max = numberA;

if (numberA > max) max = numberA;
if (numberB  >max) max = numberB;
if (numberC > max) max = numberC;

Console.Write("max = ");
Console.WriteLine(max);