int n = new Random().Next(1,10);
int saturday = 6;
int sunday = 7;
Console.Write("Цифра, обозначающая день недели = ");
Console.Write(n);
Console.WriteLine();

if(n==saturday)
{
    Console.WriteLine("ДА");
}
if(n==sunday)
{
    Console.WriteLine("ДА");
}
else 
{
    Console.WriteLine("НЕТ");
}