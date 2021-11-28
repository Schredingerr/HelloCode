int numberA = new Random().Next(1, 100); // 1 2 3 4 ...
Console.WriteLine(numberA);
if(numberA %2!=0);
{
    Console.Write("Число : ");
    Console.Write(numberA);
    Console.WriteLine(" - чётное");
}
else
{
    Console.Write("Число : ");
    Console.Write(numberA);
    Console.WriteLine(" - не чётное");
}