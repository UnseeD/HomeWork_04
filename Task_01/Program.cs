﻿// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

System.Console.Write("Введите число A: ");
int numberA = int.Parse(Console.ReadLine());
System.Console.Write("Введите число B: ");
int numberB = int.Parse(Console.ReadLine());
int Pow(int firstNumber, int secondNumber)
{
    int result = 1;

    for(int i = 0; i < numberB; i++)
    {
        result *= numberA;
    }
    return result;
}
System.Console.WriteLine($"{numberA} в степени {numberB} равен {Pow(numberA, numberB)}");

