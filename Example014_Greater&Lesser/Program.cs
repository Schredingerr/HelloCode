int numberA = new Random().Next(1, 100); //1 2 3 4 ...
Console.WriteLine(numberA);
int numberB = new Random(). Next(1, 100);
Console.WriteLine(numberB);
int max = 0;
if (numberA > numberB) max = numberA;
if (numberB > numberA) max = numberB;
Console.WriteLine (max);