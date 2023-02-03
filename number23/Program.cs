// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
Console.Clear();
Console.Write("ВВедите N: ");
int N = int.Parse(Console.ReadLine()!);
int count = 1;
if (N > 0)
{
    while (count <= N)
    {
        // Console.Write(count * count * count + " ");
        // count++;
        Console.Write($"{Math.Pow(count, 3)}");
        if (N != count)
        {
            Console.Write($", ");
        }
        count += 1;
    }
}
else
{
    while (count >= N)
    {
        // Console.Write(count * count * count + " ");
        // count++;
        Console.Write($"{Math.Pow(count, 3)}");
        if (N != count)
        {
            Console.Write($", ");
        }
        count -= 1;
    }
}