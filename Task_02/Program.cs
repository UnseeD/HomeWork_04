// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
System.Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine());
int result = 0;
while (N > 0)
{
    result += N % 10;
    N = N / 10;
}
System.Console.WriteLine(result);

// System.Console.WriteLine("Введите число: ");
// String N = Console.ReadLine();
// int result = 0;
// for (int i = 0; i < N.Length; i++)
// {
//     result = result + N[i];
// }
// System.Console.WriteLine(result);

