// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

System.Console.WriteLine();
int[] array = new int [8];
for (int i = 0; i < array.Length; i++)
{
    System.Console.WriteLine($"Введите элемент массива {i}");
    array[i] = int.Parse(Console.ReadLine());
}
for (int i = 0; i < array.Length; i++)
{
    System.Console.Write($"{array[i]} ");
}



