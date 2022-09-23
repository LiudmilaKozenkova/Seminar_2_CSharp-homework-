int count = new Random().Next(1,10);
int[] array = new int[count];
int index = 0;
Console.Write("Count = ");
Console.WriteLine(count);
Console.Write("Дано число: ");

while (index < count)
{
    array[index] = new Random().Next(1, 10);
    Console.Write(array[index] + " ");
    index += 1;
}

index = 0;
bool element = false;

if (array[2] >= 0)
{
    element = true;
}
if (element)
{
    Console.Write("\nТретья цифра заданного числа = ");
    Console.WriteLine(array[2]);
}
else
{
    Console.WriteLine("Такого числа нет");
}