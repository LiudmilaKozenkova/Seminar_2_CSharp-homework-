int count = 3;
int[] array = new int[count];
int index = 0;

Console.WriteLine();
while(index<count)
{
    array[index]=new Random().Next(1,10);
    Console.Write(array[index]+ " ");
    index++;
}
Console.WriteLine(" - трехзначное число");
Console.Write("Вторая цифра трехзначного числа = ");
Console.Write(array[1]);