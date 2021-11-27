int numberA = new Random().Next(1, 100); //1 2 3 4 ...
Console.WriteLine(numberA);
int numberB = new Random(). Next(1, 100);
Console.WriteLine(numberB);
int max = 0;
int min = 0;
if (numberA > numberB) max = numberA; min = numberB;
if (numberB > numberA) max = numberB; min = numberA;
Console.Write("Максимальное: ");
Console.WriteLine(max);
Console.Write("Минимальное: ");
Console.WriteLine(min);